class Test {
  public static void main(String[] args){
    BinaryTree<String> bt = new BinaryTree<>();
    BTNode<String> node1 = new BTNode<>("Ginger");
    BTNode<String> node2 = new BTNode<>("Snowdrop");
    BTNode<String> node3 = new BTNode<>("Molly");
    BTNode<String> node4 = new BTNode<>("Sadie");
    BTNode<String> node5 = new BTNode<>("Rufus");
    BTNode<String> node6 = new BTNode<>("Garfield");
    BTNode<String> node7 = new BTNode<>("Rosy");

    bt.root = node1;
    node1.left = node2;
    node1.right = node3;
    node2.left = node4;
    node2.right = node5;
    node3.left = node6;
    node3.right = node7;

    System.out.println(bt);
    System.out.println(bt.preorder());
    System.out.println(bt.inOrder());
    System.out.println(bt.postOrder());

    BinarySearchTree bst = new BinarySearchTree();
    bst.add(10);
    bst.add(5);
    bst.add(3);
    bst.add(7);
    bst.add(2);
    bst.add(9);
    bst.add(15);
    bst.add(17);
    bst.add(18);
    bst.add(19);
    bst.add(20);
    bst.add(14);

    System.out.println(bst);
    System.out.println("contains 9 should be true" + bst);
    System.out.println(bst);
  }
}
