# Code Challenge

Implement a simplified LEFT JOIN for 2 Hashmaps.

## Specifications

- Read all of these instructions carefully.
- Name things exactly as described.
- Do all your work in a your `data-structures-and-algorithms` public repository.
- Create a new branch in your repo named as noted below.
- Follow the language-specific instructions for the challenge type listed below.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.

### Challenge Setup & Execution

**Branch Name:** `hashmap-left-join`

**Challenge Type:** Code Challenge / Algorithm

## Feature Tasks

Write a function that [LEFT JOINs](https://www.tutorialspoint.com/sql/sql-left-joins.htm){:target="_blank"} two hashmaps into a single data structure.

- Write a function called left join
- Arguments: two hash maps
  - The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
  - The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
- Return: The returned data structure that holds the results is up to you. It doesn't need to exactly match the output below, so long as it achieves the LEFT JOIN logic

**NOTES**:

- Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
- LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the "right" hashmap, they are appended to the result row.
- If no values exist in the right hashmap, then some flavor of `NULL` should be appended to the result row.

## Structure and Testing

Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write at least three test assertions for each method that you define.

Ensure your tests are passing before you submit your solution.

## Example

### INPUT

| Synonyms Hash Table |          |   | Antonyms Hash Table |         |
|---------------------|----------|---|---------------------|---------|
| **Key**             | **Value** |   | **Key**            | **Value**   |
| diligent            | employed |   | diligent            | idle    |
| fond                | enamored |   | fond                | averse  |
| guide               | usher    |   | guide               | follow  |
| outfit              | garb     |   | flow                | jam     |
| wrath               | anger    |   | wrath               | delight |
| ...                 | ...      |   | ...                 | ...     |

### OUTPUT

```javascript
[
   ["font", "enamored", "averse"],
   ["wrath", "anger", "delight"],
   ["diligent", "employed", "idle"],
   ["outfit", "garb", NULL],
   ["guide", "usher","follow"]
]
```

## Stretch Goals

Consider a RIGHT JOIN. Can you implement this as a new function? How about by passing an optional parameter to your initial function, to specify if LEFT JOIN or RIGHT JOIN logic should be used?

## Documentation: Your README.md

```markdown
# Hashmap LEFT JOIN
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

## Solution
<!-- Embedded whiteboard image -->

```

## Submission Instructions

1. Take a photo of your completed whiteboard, matching the [example whiteboard layout](../../Whiteboard_Workflow.md){:target="_blank"}
     1. Copy your photo into an `/assets` directory in your repo
     1. Give the image file the same name as the branch you are working on
     1. Embed the image in your README.md documentation
1. Create a pull request from your branch to your `main` branch
1. In your open pull request, leave as a comment [a checklist](https://github.com/blog/1825-task-lists-in-all-markdown-documents){:target="_blank"} of the specifications and tasks above, with the actual steps that you completed checked off
1. Submitting your completed work:
    1. Copy the link to your open pull request and paste it into the corresponding assignment
    1. Leave a description of how long this assignment took you in the comments box
    1. Add any additional comments you like about your process or any difficulties you may have had with the assignment
1. Merge your branch into `main`, and delete your branch (don't worry, the PR link will still work)
