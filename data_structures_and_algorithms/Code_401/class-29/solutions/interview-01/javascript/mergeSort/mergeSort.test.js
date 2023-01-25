'use strict';

const mergeSort = require('./mergeSort.js');

describe('Merge Sort', () => {
  test('Merge sort on small reverse order array', () => {
    let array = [10, 8, 4, 2, 1];
    let output = [1, 2, 4, 8, 10];

    expect(mergeSort(array)).toEqual(output);
  });

  test('Merge sort on large array with random placement', () => {
    let array = [40, 82, 2, 55, 1, 12, 67, 89, 36, 78, 6, 244];
    let output = [1, 2, 6, 12, 36, 40, 55, 67, 78, 82, 89, 244];

    expect(mergeSort(array)).toEqual(output);
  });
});
