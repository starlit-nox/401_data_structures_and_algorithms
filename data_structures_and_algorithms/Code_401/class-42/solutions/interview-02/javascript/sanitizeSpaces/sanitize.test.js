'use strict';

const sanitize = require('./sanitize.js');

describe('Testing our string sanitizing function', () => {
  test('Should remove all spaces from a string', () => {

    let string = "http://code.org/hour of code.html";

    expect(sanitize(string)).toEqual("http://code.org/hour%20of%20code.html");
  });
});
