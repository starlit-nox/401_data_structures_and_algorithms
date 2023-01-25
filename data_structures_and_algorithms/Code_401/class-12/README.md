# Code Challenge

First-in, First out Animal Shelter.

## Specifications

- Read all of these instructions carefully.
- Name things exactly as described.
- Do all your work in a your `data-structures-and-algorithms` public repository.
- Create a new branch in your repo named as noted below.
- Follow the language-specific instructions for the challenge type listed below.
- Update the "Table of Contents" - in the README at the root of the repository - with a link to this challenge's README file.

### Challenge Setup & Execution

**Branch Name:** `stack-queue-animal-shelter`

**Challenge Type:** Code Challenge / Algorithm

## Feature Tasks

- Create a class called AnimalShelter which holds only dogs and cats.
- The shelter operates using a *first-in, first-out* approach.
- Implement the following methods:
  - enqueue
    - Arguments: animal
      - `animal` can be either a dog or a cat object.
  - dequeue
    - Arguments: pref
      - `pref` can be either `"dog"` or `"cat"`
    - Return: either a dog or a cat, based on preference.
      - If `pref` is not `"dog"` or `"cat"` then return null.

## Stretch Goal

If a cat or dog isn't preferred, return whichever animal has been waiting in the shelter the longest.

## Requirements

Ensure your complete solution follows the standard requirements.

1. Write [unit tests](../../Challenge_Testing){:target="_blank"}
1. Follow the [template for a well-formatted README](../../Challenge_Documentation){:target="_blank"}
1. Submit the assignment following [these instructions](../../Challenge_Submission){:target="_blank"}
