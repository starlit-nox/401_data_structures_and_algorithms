'use strict';

const isPalindrome = require('./isPalindrome.js');

class Node {
  constructor(value) {
    this.value = value;
    this.next = null;
  }
}

class LinkedList {
  constructor() {
    this.head = null;
  }

  append(value) {
    let node = new Node(value);
    if (!this.head) {
      this.head = node;
      return node;
    }

    let current = this.head;

    while(current.next) {
      current = current.next;
    }

    current.next = node;
    return node;
  }
}

describe('isPalidrome', () => {
  test('Shuold pass using "tacocat"', () => {
    let list = new LinkedList();
    list.append('t');
    list.append('a');
    list.append('c');
    list.append('o');
    list.append('c');
    list.append('a');
    list.append('t');

    expect(isPalindrome(list)).toEqual(true);
  });

  test('Should fail for non palindrome', () => {
    let list = new LinkedList();
    list.append('h');
    list.append('o');
    list.append('u');
    list.append('s');
    list.append('e');

    expect(isPalindrome(list)).toEqual(false);
  });
});
