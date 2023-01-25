'use strict';

const rotateMatrix = require('./rotateMatrix.js');

describe('Testing the matrix rotation function', () => {
  test('Should rotate a 2 x 2 matrix', () => {
    let matrix = [
      [1, 1],
      [2, 2],
    ]
    rotateMatrix(matrix);
    expect(matrix).toEqual([
      [2, 1],
      [2, 1],
    ]);
  });
  test('Should rotate a 3 x 3 matrix', () => {
    let matrix = [
      [1, 1, 1],
      [2, 2, 2],
      [3, 3, 3]
    ]
    rotateMatrix(matrix)
    expect(matrix).toEqual([
      [3, 2, 1],
      [3, 2, 1],
      [3, 2, 1]
    ]);
  });

  test('Should rotate another 3 x 3 matrix', () => {
    let matrix = [
      [3, 2, 1],
      [3, 2, 1],
      [3, 2, 1]
    ];
    rotateMatrix(matrix);
    expect(matrix).toEqual([
      [3, 3, 3],
      [2, 2, 2],
      [1, 1, 1]
    ]);
  })
});
