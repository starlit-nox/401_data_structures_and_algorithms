'use strict';

function reverseLinkedList(ll) {
  let current = ll.head;
  let previous = null;

  while(current) {
    let next = current.next;
    current.next = previous;
    previous = current;
    current = next;
  }

  ll.head = previous;

  return ll;
}

module.exports = reverseLinkedList;
