import java.util.*;

class LinkedList <T> {
  public static void main(String[] args) throws Exception{
    LinkedList<Integer> linky1 = new LinkedList<>();
    linky1.append(1);
    linky1.append(3);
    linky1.append(5);

    LinkedList<Integer> linky2 = new LinkedList<>();
    linky2.append(2);
    linky2.append(4);
    linky2.append(6);
    linky2.append(8);
    linky2.append(10);
    System.out.println(linky1);
    System.out.println(linky2);
    LinkedList<Integer> newList1 = linky1.zipLists(linky2, linky1);

    System.out.println(newList1);

  }

  Node<T> head;
  Node<T> tail;

  public LinkedList<T> zipLists(LinkedList<T> first, LinkedList<T> second){
    first.head = zip(first.head, second.head);
    return first;
  }

  public Node<T> zip(Node<T> first, Node<T> second){
    if(first == null) return second;
    first.next = zip(second, first.next);
    return first;
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
