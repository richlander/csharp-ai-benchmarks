# HumanEval

This directory is a readable version of [HumanEval from Amazon Science](https://github.com/amazon-science/mxeval).

- [humaneval.jsonl (updated with `name` and `short-description` properties)](./humaneval.jsonl)
- [HumanEval_csharp_v1.jsonl (original Amazon Science file)](https://github.com/amazon-science/mxeval/blob/main/data/multilingual_humaneval/HumanEval_csharp_v1.jsonl)

The additional properties in the updated `.jsonl` file were generated via the OpenAI API. They were added to make it possible to generate stable markdown (and directory names). The `task_id` property was simplified to an integer. The other properties are unchanged.

Thanks to Amazon Science for supporting C# in their AI efforts.
