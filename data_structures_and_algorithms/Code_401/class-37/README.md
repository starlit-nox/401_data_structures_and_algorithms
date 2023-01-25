# Code Challenge

Given a business trip itinerary, and an Alaska Airlines route map,
is the trip possible with direct flights? If so, how much will the total trip cost be?

## Specifications

- Read all of these instructions carefully.
- Name things exactly as described.
- Do all your work in a your `data-structures-and-algorithms` public repository.
- Create a new branch in your repo named as noted below.
- Follow the language-specific instructions for the challenge type listed below.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.

### Challenge Setup & Execution

**Branch Name:** `graph-business-trip`

**Challenge Type:** Code Challenge / Algorithm

## Feature Tasks

- Write a function called business trip
- Arguments: graph, array of city names
- Return: the cost of the trip (if it's possible) or null (if not)

Determine whether the trip is possible with direct flights, and how much it would cost.

## Structure and Testing

Utilize the Single-responsibility principle: any methods you write should be clean,
reusable, abstract component parts to the whole challenge. You will be given feedback and
marked down if you attempt to define a large, complex algorithm in one function definition.

Write at least three test assertions for each method that you define.

Ensure your tests are passing before you submit your solution.

## Example

![Example](GraphDay27.PNG)

| Input | Output |
|-----| ----|
| [Metroville, Pandora, ]  | $82  |
| [Arendelle, New Monstropolis, Naboo] | $115 |
| [Naboo, Pandora] | null |
| [Narnia, Arendelle, Naboo] | null |

## Documentation: Your README.md

```markdown
# Find Edges
<!-- Short summary or background information -->

## Challenge
<!-- Description of the challenge -->

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

## Requirements
Ensure your complete solution follows the standard requirements.

1. Write [unit tests](../../Challenge_Testing){:target="_blank"}
1. Follow the [template for a well-formatted README](../../Challenge_Documentation){:target="_blank"}
1. Submit the assignment following [these instructions](../../Challenge_Submission){:target="_blank"}
