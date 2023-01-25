// ASSUME Everything in this file is available to the interviewee.
// They ONLY need to write the reverse or isPalindrome method.
// isPalindrome may use the reverse method as if it were complete and correct.
export class LinkedList<T> {
  head: Node<T> | undefined;

  insert(t: T) {
    this.head = { item: t, next: this.head };
  }

  toString(): string {
    let node = this.head;

    let str = "";
    while (node) {
      str += `{ ${node.item} } -> `;
      node = node.next;
    }
    str += "NULL";
    return str;
  }
}

// A node tracks one item and the next node
export interface Node<T> {
  item: T;
  next: Node<T> | undefined;
}
