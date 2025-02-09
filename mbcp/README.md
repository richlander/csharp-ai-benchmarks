# Mostly Basic C# Problems Dataset

The benchmark consists of around 1,000 C# programming problems, designed to be solvable by entry level programmers, covering programming fundamentals, standard library functionality, and so on. Each problem consists of a task description, code solution and 3 automated test cases.

The dataset is in [mbcp.jsonl](./mbcp.jsonl) in .jsonl format (json per line).

The C# dataset was generated via ChatGPT using a [prompt](./prompt.txt). The intent was to convert the entire file via a single prompt and to generate the directory structure locally (using GitHub Copilot). That didn't work. Instead, the only practical (with some sense of "practical") was to prompt line by line and not copy/paste the results for browser to editor.

Inspired and derived from:

- [Mostly Basic Python Problems Dataset](https://github.com/google-research/google-research/tree/master/mbpp)
- [Program Synthesis with Large Language Models](https://arxiv.org/abs/2108.07732).

Credit to Google for the original dataset and the associated research.

## Approach

JSONL datasets are handy for managing large numbers of AI examples, but not great for reading and editing. We've addressed that significant tension by exploding/uncompressing (and translating) the original [mbpp.jsonl](./mbpp.jsonl) file into a set of directories. A tool is run over the directories to tranform/compress them into the analogous [mbcp.jsonl](./mbcp.jsonl) file, for C#. We think this approach is significantly more OSS-friendly.

The `README.md` in each directory is the source of truth for the generated `.jsonl` file. The source code for each problem is stored in C# with associated project files to make it easy to read, edit, and build the code. A copy of the code also exists in a README.md file per the [template](./template/README.md) format. If the code is ever changed, the README.md file needs to be manually updated.
