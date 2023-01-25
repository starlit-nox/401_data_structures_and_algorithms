import java.util.HashSet;
import java.util.Set;

public class Node<T> {
    public T value;
    public HashSet<NodeAndWeight<T>> edges;

    public Node() {
        this(null);
    }

    public Node(T value) {
        this.value = value;
        this.edges = new HashSet<NodeAndWeight<T>>();
    }

    protected void addEdge(int weight, Node<T> neighbor) {
        NodeAndWeight<T> newEdge = new NodeAndWeight(weight, neighbor);
        this.edges.add(newEdge);
    }
}
