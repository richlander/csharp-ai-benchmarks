# HumanEval

This directory is a readable version of [HumanEval from Amazon Science](https://github.com/amazon-science/mxeval).

- [HumanEval.jsonl (updated)](./humaneval.jsonl)
- [HumanEval_csharp_v1.jsonl (original; Amazon Science)](https://github.com/amazon-science/mxeval/blob/main/data/multilingual_humaneval/HumanEval_csharp_v1.jsonl)

The updated `.jsonl` file includes `name` and `short_description` properties generated via the OpenAI API. They were added to make it possible to generate stable markdown (and directory names). The `task_id` property was simplified to an integer. The other properties are unchanged.

Based on ["Multi-lingual Evaluation of Code Generation Models"](https://arxiv.org/abs/2210.14868).

Thanks to Amazon Science for supporting C# in their AI efforts.
