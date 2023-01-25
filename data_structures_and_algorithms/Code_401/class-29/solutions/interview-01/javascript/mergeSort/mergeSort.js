'use strict';

function mergeSort(array) {
  if (array.length > 1) {
    let mid = Math.floor(array.length / 2);
    let left = array.slice(0, mid);
    let right = array.slice(mid, array.length - 1);

    mergeSort(left);
    mergeSort(right);
    merge(left, right, array);
  }
}

function merge(left, right, full) {
  let i = 0;
  let j = 0;
  // k starts at 0, does this need to be passed in?
  let k = 0;

  while (i < left.length && j < right.length) {
    if (left[i] <= right[j]) {
      full[k] = left[i];
      i++;
    } else {
      full[k] = right[j];
      j++;
    }
    k++;
  }

  while (i < left.length) {
    full[k] = left[i];
    i++;
    k++;
  }

  while(j < right.length) {
    full[k] = right[j];
    j++;
    k++;
  }
}

module.exports = mergeSort;
