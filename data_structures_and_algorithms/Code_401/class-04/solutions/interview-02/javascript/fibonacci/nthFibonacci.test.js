'use strict';

const nthFibonacci = require('./nthFibonacci');

describe('Nth Fibonacci', () => {
  test('Recursive Solution', () => {
    expect(nthFibonacci.recursive(14)).toEqual(377);
  });

  test('Iterative Solution', () => {
    expect(nthFibonacci.iterative(14)).toEqual(377);
  });
});
