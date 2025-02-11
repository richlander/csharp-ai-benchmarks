using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace MarkdownToJsonlConverter
{
    // This class models the JSON document.
    public class Document
    {
        public string text { get; set; }                 // The prompt text
        public string code { get; set; }                 // The solution code (in Python)
        public int task_id { get; set; }                 // The numeric task ID
        public string test_setup_code { get; set; }      // Always an empty string
        public List<string> test_list { get; set; }      // A list of test code fragments
        public List<string> challenge_test_list { get; set; }  // Typically an empty list
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Check that a directory was provided.
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: MarkdownToJsonlConverter <directory>");
                return;
            }

            string parentDirectory = args[0];

            // Validate that the directory exists.
            if (!Directory.Exists(parentDirectory))
            {
                Console.Error.WriteLine($"Error: Directory '{parentDirectory}' does not exist.");
                return;
            }

            // Build the output file path:
            // Use the directory name with a ".jsonl" extension inside the directory.
            string dirName = new DirectoryInfo(parentDirectory).Name;
            string outputFilePath = Path.Combine(parentDirectory, $"{dirName}.jsonl");

            // List to hold all documents.
            List<Document> documents = new List<Document>();

            // Iterate over each immediate child directory.
            string[] childDirectories = Directory.GetDirectories(parentDirectory);
            foreach (string childDir in childDirectories)
            {
                // Look for a README.md file in the child directory.
                string readmePath = Path.Combine(childDir, "README.md");
                if (!File.Exists(readmePath))
                {
                    Console.WriteLine($"Warning: README.md not found in '{childDir}'. Skipping this directory.");
                    continue;
                }

                try
                {
                    // Read the entire markdown file.
                    string markdown = File.ReadAllText(readmePath);

                    // Process the markdown to create a Document object.
                    Document doc = ProcessMarkdown(markdown);

                    // Add the document to our list.
                    documents.Add(doc);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Error processing file '{readmePath}': {ex.Message}");
                }
            }

            // Sort documents by task_id in ascending order.
            documents.Sort((d1, d2) => d1.task_id.CompareTo(d2.task_id));

            // Open the output file for writing.
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                // Write each Document as a JSON line.
                foreach (var doc in documents)
                {
                    string jsonLine = JsonSerializer.Serialize(doc);
                    sw.WriteLine(jsonLine);
                }
            }

            Console.WriteLine("Conversion complete.");
        }

        /// <summary>
        /// Processes the markdown text and returns a Document object.
        /// Assumes the markdown has the following structure:
        /// 
        ///   # $TASK_ID -- $DESCRIPTION
        ///
        ///   $NAME
        ///
        ///   ## Prompt
        ///
        ///   $PROMPT
        ///
        ///   ## Solution
        ///
        ///   $SOLUTION
        ///
        ///   ## Tests
        ///
        ///   $TESTS
        /// 
        /// Code fences (```) will be removed.
        /// </summary>
        static Document ProcessMarkdown(string markdown)
        {
            // Split the file into lines.
            string[] lines = markdown.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            // === Extract the header line (first line that starts with "# ") ===
            string headerLine = null;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("# "))
                {
                    headerLine = lines[i];
                    break;
                }
            }
            if (headerLine == null)
                throw new Exception("Header line (starting with '# ') not found.");

            // Expected header format: "# $TASK_ID -- $DESCRIPTION"
            // Remove "# " and split by " -- "
            string headerContent = headerLine.Substring(2).Trim();
            string[] headerParts = headerContent.Split(new string[] { " -- " }, StringSplitOptions.None);
            if (headerParts.Length < 1)
                throw new Exception("Invalid header format. Expected '# TASK_ID -- DESCRIPTION'.");

            // Parse the task ID.
            string taskIdString = headerParts[0].Trim();
            if (!int.TryParse(taskIdString, out int taskId))
                throw new Exception("Task ID is not a valid integer.");

            // === Locate section markers ===
            // We expect the markers: "## Prompt", "## Solution", "## Tests"
            int promptIndex = -1, solutionIndex = -1, testsIndex = -1;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("## Prompt"))
                    promptIndex = i;
                else if (lines[i].StartsWith("## Solution"))
                    solutionIndex = i;
                else if (lines[i].StartsWith("## Tests"))
                    testsIndex = i;
            }

            if (promptIndex == -1 || solutionIndex == -1 || testsIndex == -1)
                throw new Exception("One or more required section markers (## Prompt, ## Solution, ## Tests) were not found.");

            // === Extract section contents ===
            string prompt = ExtractSection(lines, promptIndex, solutionIndex);
            string solution = ExtractSection(lines, solutionIndex, testsIndex);
            string testsRaw = ExtractSection(lines, testsIndex, lines.Length);

            // Remove markdown code fences from the prompt and solution.
            prompt = RemoveCodeFences(prompt);
            solution = RemoveCodeFences(solution);

            // For tests, extract any code blocks.
            List<string> testList = ExtractCodeBlocks(testsRaw);
            // If no code fences were found, use the tests content (after cleaning) as one block.
            if (testList.Count == 0)
            {
                string trimmedTests = RemoveCodeFences(testsRaw).Trim();
                if (!string.IsNullOrEmpty(trimmedTests))
                    testList.Add(trimmedTests);
            }

            // Build the Document object.
            Document doc = new Document
            {
                text = prompt.Trim(),
                code = solution.Trim(),
                task_id = taskId,
                test_setup_code = "",
                test_list = testList,
                challenge_test_list = new List<string>()
            };

            return doc;
        }

        /// <summary>
        /// Extracts the content of a section from lines[startMarkerIndex+1] up to (but not including) lines[endMarkerIndex].
        /// </summary>
        static string ExtractSection(string[] lines, int startMarkerIndex, int endMarkerIndex)
        {
            List<string> sectionLines = new List<string>();
            for (int i = startMarkerIndex + 1; i < endMarkerIndex; i++)
            {
                sectionLines.Add(lines[i]);
            }
            return string.Join("\n", sectionLines).Trim();
        }

        /// <summary>
        /// Removes markdown code fence lines (those that start with "```") from the text.
        /// </summary>
        static string RemoveCodeFences(string text)
        {
            var lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
            List<string> filtered = new List<string>();
            foreach (var line in lines)
            {
                if (line.Trim().StartsWith("```"))
                    continue;
                filtered.Add(line);
            }
            return string.Join("\n", filtered).Trim();
        }

        /// <summary>
        /// Extracts code blocks from the given text.
        /// A code block is assumed to be delimited by lines that start with "```".
        /// </summary>
        static List<string> ExtractCodeBlocks(string text)
        {
            List<string> blocks = new List<string>();
            bool inBlock = false;
            List<string> currentBlock = new List<string>();
            string[] lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (line.Trim().StartsWith("```"))
                {
                    if (!inBlock)
                    {
                        // Start a new code block.
                        inBlock = true;
                        currentBlock.Clear();
                    }
                    else
                    {
                        // End of the current code block.
                        inBlock = false;
                        string blockContent = string.Join("\n", currentBlock).Trim();
                        if (!string.IsNullOrEmpty(blockContent))
                            blocks.Add(blockContent);
                    }
                    // Skip the fence line.
                    continue;
                }

                if (inBlock)
                {
                    currentBlock.Add(line);
                }
            }
            return blocks;
        }
    }
}
