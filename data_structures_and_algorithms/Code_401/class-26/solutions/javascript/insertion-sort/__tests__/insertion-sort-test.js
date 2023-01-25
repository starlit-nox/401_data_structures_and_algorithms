'use strict';

const sort = require('../insertion-sort.js');

// Note we're always testing using the javascript built in sort() method because we know it works ...

describe('insertion sort', () => {
  it('sorts an array of 1', () => {
    let arr = [1];
    expect(sort(arr)).toEqual(arr.sort());
  });

  it('sorts an array of 2', () => {
    let arr = [2,1];
    expect(sort(arr)).toEqual(arr.sort());
  });

  it('sorts an array of 3', () => {
    let arr = [2,3,1];
    let expected = [1,2,3];
    expect(sort(arr)).toEqual(arr.sort());
  });

  it('sorts an array of n', () => {
    let arr = [];
    for( let i = 1; i <= 10; i++ ) { arr.push( Math.floor(Math.random() * 10) ); }
    expect(sort(arr)).toEqual(arr.sort());
  });

});
