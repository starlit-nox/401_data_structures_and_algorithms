'use strict';

const isAnagram = require('./isAnagram.js');

describe('Testing the isAnagram function', () => {
  test('Should return false for strings that are not anagrams', () => {

    expect(isAnagram('jacob', 'not jacob')).toEqual(false);
  });

  test('should return true for string that are anagrams', () => {

    expect(isAnagram('tacocat', 'catotac')).toEqual(true);
  });

  test('should return true for strings with extra spaces and ignoring capitalization', () => {

    expect(isAnagram('I am a string of characters', 'A string of characters I am')).toEqual(true);
  });
});
