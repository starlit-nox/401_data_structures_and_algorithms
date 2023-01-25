'use strict';

/**
 *
 * algorithm largestProduct
 *
 * sort all values from smallest to largest, ignoring polarity
 *
 * select the last 3 numbers,
 *    if they are all negative, find the next number that is no negative
 *
 *  iterate through the last three values and return the product of all three
 *
 * @param {Array<Integer>} list
 * @returns {Number} value
 *
 */


// sort an array from smallest to largest absolute value
const sortList = (list) => list.sort((a, b) => {
  if (Math.abs(a) > Math.abs(b)) {
    return 1
  } else if (Math.abs(a) < Math.abs(b)) {
    return -1
  } else {
    return 0;
  }
});

// find all negative values
const getNegatives = (nums) => nums.reduce((prev, curr, idx) => {
  if (Math.abs(curr) + curr === 0 && curr !== 0) {
    prev.push(curr);
  }
  return prev;
}, []);

// multiply all elements in an array together.
const getProduct = (nums) => nums.reduce((prev, curr) => prev * curr, 1);

// replace negative numbers with the next largest positive value
const replaceNegatives = (lastThree, list) => {
  for (let i in lastThree) {
    if (Math.abs(lastThree[i]) + lastThree[i] === 0) {
      for (let j = list.length - 4; j > 0; j--) {
        if (Math.abs(list[j]) + list[j] !== 0) {
          lastThree[i] = list[j];
        }
      }
    }
  }
  return lastThree;
}

function largestProductWithNegatives(list) {
  if (list.length < 3) {
    throw new Error('List Length Error');
  }
  let value = null;
  let smallestToLargest = sortList(list);
  let lastThree = smallestToLargest.slice(smallestToLargest.length - 3, smallestToLargest.length);
  let negatives = getNegatives(smallestToLargest);

  if (negatives.length && getNegatives(lastThree).length) {
    if (negatives.length === smallestToLargest.length) {
      value = getProduct(smallestToLargest.slice(0, 3));
    } else if (getNegatives(lastThree).length % 2 === 0) {
      value = getProduct(lastThree);
    } else {
      value = getProduct(replaceNegatives(lastThree, smallestToLargest));
    }
  } else {
    value = getProduct(lastThree);
  }
  return value;
}

module.exports = largestProductWithNegatives;
