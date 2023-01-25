'use strict';

function stringReverse(string) {
  let reversed = '';

  let reverse = (chars, i) => {
    if (i >= 0) {
      reversed+= chars[i];
      reverse(chars, i - 1);
    }
  }
  reverse(string, string.length - 1);
  return reversed;
}

module.exports = stringReverse;
