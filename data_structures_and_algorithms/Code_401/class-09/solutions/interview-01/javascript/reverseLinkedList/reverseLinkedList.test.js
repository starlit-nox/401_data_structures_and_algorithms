'use strict';

const reverseLinkedList = require('./reverseLinkedList');

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

  values() {
    let data = [];
    let current = this.head;

    while(current) {
      data.push(current.value);
      current = current.next;
    }

    return data;
  }
}

describe('Reverse Linked List', () => {
  test('Should reverse a linked list of numbers', () => {
    let list = new LinkedList();
    list.head = new Node(3);
    list.head.next = new Node(2);
    list.head.next.next = new Node(1);

    reverseLinkedList(list);
    expect(list.head.value).toEqual(1);
    expect(list.head.next.value).toEqual(2);
    expect(list.head.next.next.value).toEqual(3);
  });

  test('Should reverse a linked list of characters', () => {
    let list = new LinkedList();
    list.head = new Node('a');
    list.head.next = new Node('b');
    list.head.next.next = new Node('c');

    reverseLinkedList(list);
    expect(list.head.value).toEqual('c');
    expect(list.head.next.value).toEqual('b');
    expect(list.head.next.next.value).toEqual('a');
  });
});
