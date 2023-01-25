import java.util.HashSet;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Set;

public class Graph<T> {
    public Set<Node<T>> nodes;

    public Graph() {
        this.nodes = new HashSet<>();
    }

    public Node<T> addNode(T value) {
        Node<T> newNode = new Node<>(value);
        nodes.add(newNode);
        return newNode;
    }

    public void addEdge(int weight, Node<T> node1, Node<T> node2) {
        if (!this.nodes.contains(node1) || !this.nodes.contains(node2)) {
            throw new IllegalArgumentException("Nodes must be contained in graph.");
        }
        node1.addEdge(weight, node2);
    }

    public void addUndirectedEdge(int weight, Node<T> node1, Node<T> node2) {
        addEdge(weight, node1, node2);
        addEdge(weight, node2, node1);
    }

    public Set<Node<T>> getNodes() {
        return this.nodes;
    }

    public Set<Node<T>> getNeighbors(Node<T> n) {
        if(!this.nodes.contains(n)) {
            throw new IllegalArgumentException("Node must be contained in graph");
        }
        HashSet <Node<T>> distinctNeighbors = new HashSet<Node<T>>();
        for(NodeAndWeight<T> edge : n.edges) {
            distinctNeighbors.add(edge.node);
        }
        return distinctNeighbors;
    }

    public int size() {
        return this.nodes.size();
    }

    // runtime?

    public static Iterable<Node> bfs(Node startNode) {
        LinkedList<Node> answer = new LinkedList<>();
        // keep track of nodes to visit in a queue
        Queue<Node> nodesToVisit = new LinkedList<>();
        nodesToVisit.add(startNode);
        // keep track of visited nodes in a HashSet
        HashSet<Node> visitedNodes = new HashSet<>();
        visitedNodes.add(startNode);

        while(!nodesToVisit.isEmpty()){
            // take first thing out of queue
            // add its neighbors to the queue if they haven't been seen yet
            Node currentNode = nodesToVisit.poll();
            answer.add(currentNode);
            for (NodeAndWeight neighbor : (Set<NodeAndWeight>) currentNode.edges) {
                Node neighborNode = neighbor.node;
                if(!visitedNodes.contains(neighborNode)) {
                    nodesToVisit.add(neighborNode);
                    visitedNodes.add(neighborNode);
                }
            }

        }

        // also keep track of seenness
        return answer;
    }
}
