import java.util.LinkedList;
import java.util.ArrayList;
import java.util.Queue;

class BinaryTree <T> {
  BTNode<T> root;

  public ArrayList<T> preorder(){
    ArrayList<T> vals = new ArrayList<>();
    preorder(root, vals);
    return vals;
  }
  public void preorder(BTNode<T> current, ArrayList<T> vals){
    if(current == null) return;
    vals.add(current.value);
    preorder(current.left, vals);
    preorder(current.right, vals);
  }

  public ArrayList<T> inOrder(){
    ArrayList<T> vals = new ArrayList<>();
    inOrder(root, vals);
    return vals;
  }
  public void inOrder(BTNode<T> current, ArrayList<T> vals){
    if(current == null) return;
    inOrder(current.left, vals);
    vals.add(current.value);
    inOrder(current.right, vals);
  }

  public ArrayList<T> postOrder(){
    ArrayList<T> vals = new ArrayList<>();
    postOrder(root, vals);
    return vals;
  }
  public void postOrder(BTNode<T> current, ArrayList<T> vals){
    if(current == null) return;
    postOrder(current.left, vals);
    postOrder(current.right, vals);
    vals.add(current.value);
  }

  public String toString(){
    StringBuilder out = new StringBuilder();
    Queue<BTNode<T>> q = new LinkedList<>();
    Queue<BTNode<T>> q2 = new LinkedList<>();
    q.add(root);

    while(!q.isEmpty()){
      BTNode<T> curr = q.poll();
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

  
}
