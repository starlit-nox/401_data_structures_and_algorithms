import java.util.*;

class LinkedList <T> {
  public static void main(String[] args){
    LinkedList<Integer> ints = new LinkedList<>();
    ints.insert(1);
    ints.insert(5);
    ints.insert(6);
    System.out.println(ints);
    System.out.println(ints.includes(5));
    System.out.println(ints.includes(45));
  }
  Node<T> head;

  public void insert(T value){
    this.head = new Node<T>(value, this.head);
  }

  public boolean includes(T value){
    Node<T> current = head;
    while(current != null){
      if(current.value.equals(value)) return true;
      current = current.next;
    }
    return false;
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
