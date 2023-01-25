'use strict';
/**
 * rotates a square array 90 degrees clockwise
 * @param {Array<Array<Number>>} matrix
 */
function rotateMatrix(matrix) {
  let n = matrix.length;
  for (let x = 0; x < n / 2; x++) {
    for (let y = x; y < n - x - 1; y++) {
      // store current cell in temp variable.
      let temp = matrix[x][y];

      // Move values from TOP to RIGHT
      matrix[x][y] = matrix[n - 1 - y][x];
      // move values from LEFT to TOP
      matrix[n - 1 - y][x] = matrix[n - 1 - x][n - 1 - y];
      // move values from RIGHT to BOTTOM
      matrix[n - 1 - x][n - 1 - y] = matrix[y][n - 1 - x];
      // assign temp to RIGHT
      matrix[y][n - 1 - x] = temp;
    }
  }
}


module.exports = rotateMatrix;
