import java.util.LinkedList;
import java.util.Queue;

class BinarySearchTree {
  Node root;

  public void add(int value){
    Node node = new Node(value);
    if(root == null) {
      root = node;
    }
    Node current = root;
    while(current != null){
      if(value < current.value){
        if(current.left == null) {
          current.left = node;
          return;
        }
        current = current.left;
      } else if (value > current.value){
        if(current.right == null) {
          current.right = node;
          return;
        }
        current = current.right;
      } else {
        return;
      }
    }
  }

  public boolean contains(int value){
    Queue<Node> q = new LinkedList<>();
    if(root != null) q.add(root);

    while(!q.isEmpty()){
      Node current = q.poll();
      if(current.value == value) return true;
      if(current.left != null) q.add(current.left);
      if(current.right != null) q.add(current.right);
    }
    return false;
  }


  public String toString(){
    StringBuilder out = new StringBuilder();
    Queue<Node> q = new LinkedList<>();
    Queue<Node> q2 = new LinkedList<>();
    q.add(root);

    while(!q.isEmpty()){
      Node curr = q.poll();
      out.append(curr.value + ",");
      if(curr.left != null) q2.add(curr.left);
      if(curr.right != null) q2.add(curr.right);
      if(q.isEmpty()) {
        q = q2;
        q2 = new LinkedList<>();
        out.append("\n");
      }

    }
    return out.toString();
  }

  class Node {
    int value;
    Node left;
    Node right;

    public Node(int value){
      this.value = value;
    }
  }
}
