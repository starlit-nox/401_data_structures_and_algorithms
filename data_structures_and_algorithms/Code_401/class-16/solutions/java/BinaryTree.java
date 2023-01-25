import java.util.LinkedList;
import java.util.ArrayList;
import java.util.Queue;

class BinaryTree {
  Node root;

  public int findMaximumValue() throws Exception{
    if(root == null) throw new Exception("no values to compare");
    int max = root.value;
    Queue<Node> q = new LinkedList<>();
    q.add(root);

    while(!q.isEmpty()){
      Node curr = q.poll();
      if(curr.value > max) max = curr.value;
      if(curr.left != null) q.add(curr.left);
      if(curr.right != null) q.add(curr.right);
    }
    return max;
  }

  public ArrayList<Integer> preorder(){
    ArrayList<Integer> vals = new ArrayList<>();
    preorder(root, vals);
    return vals;
  }
  public void preorder(Node current, ArrayList<Integer> vals){
    if(current == null) return;
    vals.add(current.value);
    preorder(root.left, vals);
    preorder(root.right, vals);
  }

  public ArrayList<Integer> inOrder(){
    ArrayList<Integer> vals = new ArrayList<>();
    inOrder(root, vals);
    return vals;
  }
  public void inOrder(Node current, ArrayList<Integer> vals){
    if(current == null) return;
    inOrder(root.left, vals);
    vals.add(current.value);
    inOrder(root.right, vals);
  }

  public ArrayList<Integer> postOrder(){
    ArrayList<Integer> vals = new ArrayList<>();
    postOrder(root, vals);
    return vals;
  }
  public void postOrder(Node current, ArrayList<Integer> vals){
    if(current == null) return;
    postOrder(root.left, vals);
    postOrder(root.right, vals);
    vals.add(current.value);
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

  public static class Node {
    int value;
    Node left;
    Node right;

    public Node(int value){
      this.value = value;
    }
  }
}
