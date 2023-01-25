public class NodeAndWeight<T> {
    public int weight;
    public Node<T> node;

    public NodeAndWeight(Node<T> node) {
        this(1, node);
    }
    public NodeAndWeight(int weight, Node<T> node) {
        this.weight = weight;
        this.node = node;
    }
}
