'use strict';

function isAnagram(string1, string2) {
  let normalized1 = string1.toLowerCase().trim();
  let normalized2  =string2.toLowerCase().trim();

  if (
    normalized1.length !== normalized2.length
  ) {
    return false;
  }

  let chars = {};

  for (let char of normalized1) {
    chars[char] = true;
  }

  for (let char of normalized2) {
    if (!chars[char]) {
      return false;
    }
  }

  return true;
}

module.exports = isAnagram;
