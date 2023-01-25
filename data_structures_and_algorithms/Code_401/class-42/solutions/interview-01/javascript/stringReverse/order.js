'use strict';

function stringReverse(string) {
  let result = '';

  for (let char of string) {
    result = char + result;
  }

  return result;
}

module.exports = stringReverse;
