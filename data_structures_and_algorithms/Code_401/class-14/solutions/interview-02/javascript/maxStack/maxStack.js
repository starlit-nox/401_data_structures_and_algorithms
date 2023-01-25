'use strict';

function maxStack(stack) {
  let largestSoFar = null;
  let current = stack.pop();

  while(current) {
    if (!largestSoFar || current > largestSoFar) {
      largestSoFar = current;
    }
    current = stack.pop();
  }

  return largestSoFar;
}

module.exports = maxStack;
