'use strict';

const integerToNumeral = require('./integerToNumeral.js');

describe('Testing integer to Roman Numeral function', () => {

  test('4 digit integer to numeral', () => {
    expect(integerToNumeral('1900')).toEqual('MCM');
  });

  test('634 should convert to DCXXXIV', () => {
    expect(integerToNumeral("634")).toEqual("DCXXXIV");
  });

  test('Random integer of 3 digits should convert to Roman Numeral', () => {
    expect(integerToNumeral('786')).toEqual('DCCLXXXVI');
  });
});
