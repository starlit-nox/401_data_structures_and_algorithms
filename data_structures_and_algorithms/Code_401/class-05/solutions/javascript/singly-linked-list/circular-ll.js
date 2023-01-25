'use strict';

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
    if (!this.head) {
      this.head = new Node(value);
      return;
    }
    let current = this.head;
    while (current.next) {
      current = current.next;
    }
    current.next = new Node(value);
  }
  
  createCycle(a,b) {
    let current = this.head;
    let badSpot = null;
    while (current.next) {
      if ( current.value === a ) { badSpot = current; }
      if ( current.value === b ) { current.next = badSpot; break; }
      current = current.next;
    }
  }

  hasCycleRace() {

    let tortoise = this.head;
    let hare = this.head;
    
    if ( hare.next === null ) { return false; }
    
    hare = hare.next;
    
    while (hare.next != null) {
      hare = hare.next;
      tortoise = tortoise.next;
      if (hare === tortoise) { return true; }
      else {
        if (hare.next !== null) {
          hare = hare.next;
        }
      }
    }
      
    return false;
    
  }
  
  hasCycleHash() {
    let seen = new Map();
    let current = this.head;
    while (current.next) {
      seen.set(current);
      current = current.next;
      if ( seen.has(current) ) { return true; }
    }
    return false;
  }
}

let list = new LinkedList();
list.append(1);
list.append(2);
list.append(3);
list.append(4);
list.append(5);

console.log('Cycle?', list.hasCycleRace())
console.log('Cycle?', list.hasCycleHash())
list.createCycle(1,4);
console.log('Cycle?', list.hasCycleRace())
console.log('Cycle?', list.hasCycleHash())
