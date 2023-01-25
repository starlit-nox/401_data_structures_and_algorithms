'use strict';

const reverseRecursive = require('./recursive.js');
const reverseIterable = require('./iterable.js');
const reverseOrder = require('./array.js');

describe('Reversing a string 3 ways', () => {
  test('Reversal using a recursive strategy', () => {
    expect(reverseRecursive('Test string 1.')).toEqual('.1 gnirts tseT');
  });

  test('Reversal using an iterable strategy', () => {
    expect(reverseIterable('Test string 2.')).toEqual('.2 gnirts tseT');
  });

  test('Reversal using reverse order', () => {
    expect(reverseOrder('Test string 3.')).toEqual('.3 gnirts tseT');
  });
})
