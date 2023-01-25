import { LinkedList } from "./LinkedList";
import { reverse } from "./reverse";

export function isPalindrome<T>(ll: LinkedList<T>): boolean {
  // Palindrome is pretty straightforward. We could do back and front indexes,
  // or we can reverse the list and compare each pair of node items!
  let ll1 = ll.head;
  let ll2 = reverse(ll).head;

  // This should look like a very normal ll traversal, but with two lists at
  // the same time.
  while (ll1 && ll2) {
    // Comparison is strict equality between items
    if (ll1.item !== ll2.item) {
      // The first pair of items that aren't equal, we know it's not a pal
      return false;
    }
    ll1 = ll1.next;
    ll2 = ll2.next;
  }

  // All pairs of forward and reverse matched, so it's a palindrome!
  return true;
}
