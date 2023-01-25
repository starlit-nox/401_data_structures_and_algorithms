import { isPalindrome } from "./palindrome";
import { LinkedList } from "./LinkedList";

describe("Linked List", () => {
  it("checks if it is a palindrome", () => {
    const ll = new LinkedList<number>();

    ll.insert(3);
    ll.insert(2);
    ll.insert(1);
    ll.insert(2);
    ll.insert(3);

    expect(isPalindrome(ll)).toBe(true);
  });

  it("checks if it is not a palindrome", () => {
    const ll = new LinkedList<number>();

    ll.insert(3);
    ll.insert(2);
    ll.insert(1);

    expect(isPalindrome(ll)).toBe(false);
  });
});
