'use strict';

function stringReverse(string) {
  let i = string.length - 1;
  let result = '';

  while (i >= 0) {
    result += string[i];
    i--;
  }

  return result;
}

module.exports = stringReverse;
