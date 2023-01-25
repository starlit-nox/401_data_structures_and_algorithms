import org.junit.jupiter.api.Test;

import java.util.Iterator;

import static org.junit.jupiter.api.Assertions.*;

public class GraphTest {

    @Test
    public void testGraphConstructor() {
        Graph<String> g = new Graph<>();
        assertEquals(0, g.nodes.size(), "new graph should have no nodes");
    }

    @Test
    public void testAddingNodesToGraph() {
        Graph<String> g = new Graph<>();
        Node<String> node1 = g.addNode("A");
        assertEquals("A", node1.value, "value in node should match passed in value");
        assertEquals(1, g.nodes.size(), "one node adds to graph");
        assertEquals(node1, g.nodes.iterator().next(), "node returned is same as node in graph");
        Node<String> node2 = g.addNode("B");
        assertEquals("B", node2.value, "value in node should match passed in value");
        assertEquals(2, g.nodes.size(), "node adds to graph");
        for (Node<String> node : g.nodes) {
            assertTrue(node1 == node || node2 == node, "nodes in graph should be one of added nodes");
        }
        g.addNode("A");
        assertEquals(3, g.nodes.size(), "should allow two nodes with same value");
    }

    @Test
    public void testAddEdgesToGraph() {
        Graph<String> g = new Graph<>();
        Node<String> node1 = g.addNode("A");
        Node<String> node2 = g.addNode("B");
        g.addEdge(1, node1, node2);
        assertEquals(1, node1.edges.size(), "node 1 should have one neighbor");
        assertEquals(node2, node1.edges.iterator().next().node, "that neighbor should be node 2");
        assertEquals(1, node2.edges.size(), "node 2 should have one neighbor");
        assertEquals(node1, node2.edges.iterator().next().node, "that neighbor should be node 1");
        assertEquals(1, node2.edges.iterator().next().weight, "weight should be 1");
        assertEquals(1, node1.edges.iterator().next().weight, "weight should be 1");
    }

    @Test
    public void testAddEdges_failsOnNodesNotInGraph() {
        Node<String> node1 = new Node<>("A");
        Graph<String> g = new Graph<>();
        Node<String> node2 = g.addNode("B");
        // lambda:
        assertThrows(IllegalArgumentException.class, () -> g.addEdge(1, node1, node2));
    }

    @Test
    public void testGetNodes() {
        // todo: put code here
    }

    @Test
    public void testGetNeighbors() {
        // todo: put code here
        // todo: test error is thrown
    }

    @Test
    public void testGetSize() {
        Graph g = new Graph();
        assertEquals(0, g.size(), "new graph should be empty");
    }

    @Test
    public void testBFS() {
        Graph<String> g = new Graph<>();
        // A --- B --- C
        Node<String> node1 = g.addNode("A");
        Node<String> node2 = g.addNode("B");
        Node<String> node3 = g.addNode("C");
        g.addEdge(1, node1, node2);
        g.addEdge(1, node2, node3);

        Iterable<Node> bfsResult = (Iterable<Node>) Graph.bfs(node1);
        Iterator<Node> i = bfsResult.iterator();
        assertEquals(node1, i.next());
        assertEquals(node2, i.next());
        assertEquals(node3, i.next());
    }
}
