import java.util.*;

class LinkedList <T> {
  public static void main(String[] args) throws Exception{
    LinkedList<Integer> linky = new LinkedList<>();
    linky.append(1);
    linky.append(3);
    linky.append(5);
    System.out.println(linky);
    System.out.println(linky.nthFromEnd(0));
    System.out.println(linky.nthFromEnd(1));
    System.out.println(linky.nthFromEnd(2));

  }

  Node<T> head;
  Node<T> tail;

  public T nthFromEnd(int k) throws Exception{
    if(head == null) throw new Exception("LinkedList is empty");
    Node<T> fast = head;
    Node<T> slow = head;

    while(fast.next != null && k > 0){
      fast = fast.next;
      k--;
    }

    if(fast == null) throw new Exception("Index out of bounds");

    while(fast.next != null){
      fast = fast.next;
      slow = slow.next;
    }

    return slow.value;

  }

  public void insert(T value){
    head = new Node<T>(value, head);
    if(tail == null) tail = head;
  }

  public void append(T value){
    if(tail == null) {
      insert(value);
      return;
    }
    tail.next = new Node<T>(value, null);
    tail = tail.next;
  }

  public String toString(){
    StringBuilder stringified = new StringBuilder();
    Node<T> current = this.head;

    while(current != null){
      stringified.append("{" + current.value + "} -> ");
      current = current.next;
    }
    stringified.append("NULL");
    return stringified.toString();
  }

}

class Node<T> {
  T value;
  Node<T> next;

  public Node(T value, Node<T> next){
    this.value = value;
    this.next = next;
  }
}
