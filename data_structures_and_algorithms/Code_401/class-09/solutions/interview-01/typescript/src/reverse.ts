import { LinkedList } from "./LinkedList";

export function reverse<T>(ll: LinkedList<T>): LinkedList<T> {
  let next = undefined;
  let node = ll.head;
  let prev = undefined;
  while (node) {
    next = node.next; // Keep track of where we are going to go
    node.next = prev; // Make the current next point backwards
    prev = node; // But keep track of the current node for next time
    node = next; // Move the node forward
  }
  ll.head = prev; // Update the LL's head pointer to the last node seen

  // For this specifically, the challenge wants the code to modify the LL
  // in-place, that is, not to create a new linked list or create new nodes.
  // We need to modify each node - that's the extra challenge!
  return ll;
}
