'use strict';

const Navigator = require('./Navigator.js');

// run tests with `npx jest`
describe('Testing the Navigator class', () => {
  test('Should be able to go to a specified URL', () => {
    const nav = new Navigator();

    nav.go('test');
    expect(nav.current_url).toEqual('test');
  });

  test('Should be able to go backwards', () => {
    const nav = new Navigator();

    nav.go('first');
    nav.go('second');
    nav.back();
    expect(nav.current_url).toEqual('first');
  });

  test('Should be able to go forwards', () => {
    const nav = new Navigator();

    nav.go('first');
    nav.go('second');
    nav.back();
    nav.forward();
    expect(nav.current_url).toEqual('second');
  });
})
