'use strict';

function recursive(n) {
  if (n < 2) {
    return n;
  }

  return recursive(n - 1) + recursive(n - 2);
}

function iterative(n) {
  if (n < 2) {
    return n;
  }

  let sums = []
  sums.push(0);
  sums.push(1);

  for (let i = 2; i < n + 1; i++) {
    sums.push(sums[i - 1] + sums[i - 2]);
  }

  return sums[n];
}

module.exports = {
  recursive,
  iterative
}
