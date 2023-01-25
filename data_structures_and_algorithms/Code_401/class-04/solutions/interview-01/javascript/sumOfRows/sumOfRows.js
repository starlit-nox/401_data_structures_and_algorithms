'use strict';

function sumOfRows(matrix) {

  let sums = [];

  for (let row of matrix) {
    let sum  = 0;

    for (let value of row) {
      sum += value;
    }
    sums.push(sum);
  }

  return sums;
}

module.exports = sumOfRows;
