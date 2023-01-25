'use strict';
/**
 * Takes a map of integer keys, and numeral values, recursively calls itself if there are remainder values
 * @param {Number} digit
 * @param {Map<Integer:String>} numerals
 * @param {String} roman
 * @returns {String}
 */
const convertDigit = (digit, numerals, roman) => {
  let values = Object.keys(numerals);
  for (let i = values.length - 1; i >= 0; i--) {
    let remainder = digit - parseInt(values[i]);
    if (remainder > 0) {
      roman += numerals[values[i]];
      return convertDigit(remainder, numerals, roman);
    } else if(remainder === 0) {
      roman += numerals[values[i]];
      return roman;
    } else {
      continue;
    }
  }
}

function integerToNumeral(integer) {
  if (parseInt(integer) > 5000) {
    throw new Error('Integer Ranger Error: Integer must be less than 5000');
  }
  // map of possible integer index positions and values for each position
  let map = {
    3: {1: 'I', 4: "IV", 5: 'V', 9: 'IX'},
    2: {1: 'X', 4: 'XL', 5: 'L', 9: 'XC'},
    1: {1: 'C', 4: "CD", 5: 'D', 9: 'CM'},
    0: {1: 'M'}
  }
  let roman = '';
  let mapLength = Object.keys(map).length;
  let mapIndex = mapLength - integer.length;
  for (let digit in integer) {
    let value = integer[digit];
    let numeralMap = map[mapIndex++];
    if (value && value !== '0') {
      roman = convertDigit(value, numeralMap, roman);
    }
  }

  return roman;
}

module.exports = integerToNumeral;
