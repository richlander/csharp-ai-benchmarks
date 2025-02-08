# Mostly Basic C# Problems Dataset

The benchmark consists of around 1,000 C# programming problems, designed to be solvable by entry level programmers, covering programming fundamentals, standard library functionality, and so on. Each problem consists of a task description, code solution and 3 automated test cases.

The dataset is in [mbcp.jsonl](./mbcp.jsonl) in .jsonl format (json per line).

The C# dataset was generated via a combination of ChatGPT and GitHub Copilot using the prompt in a following section.

Inspired and derived from:

- [Mostly Basic Python Problems Dataset](https://github.com/google-research/google-research/tree/master/mbpp)
- [Program Synthesis with Large Language Models](https://arxiv.org/abs/2108.07732).

Credit to Google for the original dataset and the associated research.

## Approach

JSONL datasets are handy for managing large numbers of AI examples, but not great for reading and editing. We've addressed that significant tension by exploding/uncompressing (and translating) the original [mbpp.jsonl](./mbpp.jsonl) file into a set of directories. A tool is run over the directories to tranform/compress them into the analogous [mbcp.jsonl](./mbcp.jsonl) file, for C#. We think this approach is significantly more OSS-friendly.

The `README.md` in each directory is the source of truth for the generated `.jsonl` file. The source code for each problem is stored in C# with associated project files to make it easy to read, edit, and build the code. A copy of the code also exists in a README.md file per the [template](./template/README.md) format. If the code is ever changed, the README.md file needs to be manually updated. 

## Prompt

The file mbpp.jsonl is in JSONL format, containing one JSON document per line. It needs to be converted to a new format, to C# in both `.cs`, `.csproj`, and `.md` files.

Each JSON document has the following properties (sometimes called "columns"):

- `text`: A string prompt for an AI, to generate code in a particular coding language.
- `code`: A string for the code that is considered a good or correct answer for the prompt in the given language. In this case, the language is Python.
- `task_id`: An integer for the ID for the document.
- `test_setup_code`: A string for code that must be run before `code` can be run. This is most often an empty string.
- `test_list`: An array of test code fragments.
- `challenge_test_list`: An array. It is most often an empty array. I'm not sure what this is for.

Each line in the source JSONL file should result in a directory within the `mbcp` directory.

- Directory name: Should be a brief summary of `text`. Snake case is the preferred format. Limit name to 16 characters.
- Description: A brief summary of `text`. Limit to 48 characters. This will be used in the markdown file, described later.
- C# file: The Python code should be converted to C#, in Program.cs
- Project file: A project file targeting .NET 9 named the same as the directory, ending in `.csproj`.
- Markdown file: A markdown file written according to the format described below. It should be called `README.me`.

The C# should be written according to the following requirements:

- Use top-level statements.
- Use interpolated strings for Console.WriteLine calls that include data from the program.
- Interpolated string expressions should include variables not method calls.

The asserts should be written in the following format:

```csharp
// Test case 1
int[,] cost1 = new int[,] { { 1, 2, 3 }, { 4, 8, 2 }, { 1, 5, 3 } };
int result1 = MinCost(cost1, 2, 2);
Console.WriteLine($"Result: {result1}, Expected: 8, Test Passed: {result1 == 8}");
Debug.Assert(result1 == 8, "Test case 1 failed")
```

- The method should be called with test data and assigned to a variable.
- The "Result", "Expected" value(s), and whether the test passed should be printed.
- An assert should validate that the expected value was calculated.
- Every program should include `using System.Diagnostics` at the top so that the tests can use `Debug.Assert` without fully qualifying the type name.

The markdown README.me file should have the following format.

- Title should be an H1 in the format: "# ID -- Name of Problem"
- ID should be the value of the `task_id` property from the JSON document.
- "Name of Problem" should be the the brief description of `text` mentioned earlier.
- Prompt should be the value of the `text` property from the JSON document. If the text includes "Python", it should be changed to "C#".
- The solution should included the generated method and any preamble code in a `csharp` code fense. It shouldn't include the tests.
- Each solution can include a list of descriptive tags. For example, code that is fast or optimal include tags "MBCP_FAST" or "MBCP_NO-ALLOCATION". A solution that uses LINQ and is convenient might include tags "MBCP_LINQ" or "MBCP_CONVENIENT".
- Multiple solutions can be generated in different styles, for example low-level and high-level solutions. If multiple solutions are generated, they should be described by "MBCP_" tags.
- The tests section should include the asserts in a `csharp` code fense, one per test separated by a single line. Each test should be a `Debug.Assert` that includes a call to the generated method with the test data compared to the expected result. No assert message should be included.

A template for the `README.md` is provided in [./.template/README.md](./.template/README.md). It is also copied below in the following markdown code block.

````markdown
# ID -- Name of Problem

Note: Notes are comments that shouldn't be included in a generated markdown document.

Prompt

Note: The ID should match the task ID within the MBPP dataset.

## Solution

Note: In the case of multiple solutions, the title should be "Solution 1" and so on. Each solution will generate a line in the final JSONL file.

```csharp
Console.WriteLine();
```

Tags: MBCP_FAST

Note: Tags are intended to inform an AI on the nature of the solution. They can be space, coma, or semi-colon delimited. Every tag for this dataset should be prepended by `MBCP_`.

## Tests

Note: Each test should be in its own code fence section.

```csharp
Assert.
```
````