'use strict';

function isPalindrome(ll) {
  let current = ll.head;
  let stack = [];

  while(current) {
    stack.push(current.value);
    current = current.next;
  }

  current = ll.head;
  while (stack.length) {
    let value = stack.pop();
    if (current.value !== value) return false;
    current = current.next;
  }

  return true;
}

module.exports = isPalindrome;
