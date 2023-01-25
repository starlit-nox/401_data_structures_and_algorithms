'use strict';

const duckDuckGoose = require('./duckDuckGoose.js');

describe('Duck Duck Goose', () => {
  test('Testing simple string input', () => {
    let input = ['A', 'B', 'C', 'D', 'E'];

    expect(duckDuckGoose(input, 3)).toEqual('D')
  });

  test('Testing Longer String input', () => {
    let input = ['Sally', 'Todd', 'Rupert', 'Ava', 'Tedford', 'Hilda', 'Mia', 'Boris'];

    expect(duckDuckGoose(input, 5)).toEqual('Rupert');
  });
});
