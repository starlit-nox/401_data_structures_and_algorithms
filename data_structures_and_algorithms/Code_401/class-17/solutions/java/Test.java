class Test {
  public static void main(String[] args){
    BinaryTree binaryTree = new BinaryTree();
    BinaryTree.Node root = new BinaryTree.Node(1);
    BinaryTree.Node node1 = new BinaryTree.Node(10);
    BinaryTree.Node node2 = new BinaryTree.Node(11);
    BinaryTree.Node node3 = new BinaryTree.Node(21);
    BinaryTree.Node node4 = new BinaryTree.Node(31);
    BinaryTree.Node node5 = new BinaryTree.Node(100);
    BinaryTree.Node node6 = new BinaryTree.Node(101);
    BinaryTree.Node node7 = new BinaryTree.Node(2);

    binaryTree.root = root;
    root.left = node1;
    root.right = node2;
    node1.left = node3;
    node1.right = node4;
    node2.left = node5;
    node2.right = node6;
    node6.right = node7;

    System.out.println("should be [1, 10, 11, 21, 31, 100, 101, 2] and is : " + binaryTree.breadthFirst());
  }
}
