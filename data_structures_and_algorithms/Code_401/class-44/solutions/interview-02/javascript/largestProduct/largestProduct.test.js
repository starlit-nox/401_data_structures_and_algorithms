'use strict';

const largestProduct = require('./largestProduct.js');

describe('Finding the largest product in a list', () => {
  test('Should find the largest product using all negative values', () => {
    let product = largestProduct([-1,-2,-3,-4,-5]);

    expect(product).toBe(-6);
  });

  test('Should find the largest product using all positive values', () => {
    let product = largestProduct([18, 3, 42, 17, 9, 27]);

    expect(product).toEqual(20412);
  });

  test('Should find the largest product using a few negative values', () => {
    let product = largestProduct([4, 0, -5, 3, -1, -6, 2]);

    expect(product).toEqual(120);
  });

  test('Should find the largest product when negatives are shuffled', () => {
    let product = largestProduct([-4, 0, 5, -3, 1, 6, -2]);

    expect(product).toEqual(30);
  })
});
