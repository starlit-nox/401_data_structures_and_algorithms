'use strict';

const sumOfRows = require('./sumOfRows');

describe('Sum of Rows', () => {
  test('Sum Matrix rows test passing', () => {
    let input = [
      [1, 2, 3],
      [3, 5, 7],
      [1, 7, 10]
    ];
    let output = [6, 15, 18];

    expect(sumOfRows(input)).toEqual(output)
  });
});
