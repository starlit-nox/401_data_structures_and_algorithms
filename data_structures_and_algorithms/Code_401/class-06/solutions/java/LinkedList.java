import java.util.*;

class LinkedList <T> {
  public static void main(String[] args) throws Exception{
    LinkedList<Integer> linky = new LinkedList<>();
    linky.append(1);
    linky.append(3);
    linky.append(5);
    System.out.println(linky);
    linky.insertAfter(2, 1);
    linky.insertAfter(6, 5);
    System.out.println(linky);
    linky.insertBefore(0, 1);
    linky.insertBefore(4, 5);
    System.out.println(linky);
  }

  Node<T> head;
  Node<T> tail;

  public void insertBefore(T value, T target) throws Exception{
    if(head != null && head.value.equals(target)) {
      insert(value);
      return;
    }
    Node<T> current = head;;
    while(current != null){
      if(current.next.value.equals(target)){
       current.next = new Node(value, current.next); 
       return;
      }
      current = current.next;
    }
    throw new Exception("target value not in list");
  }

  public void insertAfter(T value, T target) throws Exception{
    Node<T> current = head;;
    while(current != null){
      if(current.value.equals(target)){
       current.next = new Node(value, current.next); 
       return;
      }
      current = current.next;
    }
    throw new Exception("target value not in list");
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
