'use strict';

const maxStack = require('./maxStack.js');

describe('Max Stack', () => {
  test('Finding largest value in the middle of a Stack', () => {
    let input = [1, 4, 7, 20, 76, 48, 8, 38];
    expect(maxStack(input)).toEqual(76);
  });

  test('Should find largest number with a duplicate', () => {
    let input = [10, 30, 100, 45, 50, 100];
    expect(maxStack(input)).toEqual(100);
  });
});
