from codefellows.dsa.graph import Graph as BaseGraph
from codefellows.dsa.stack import Stack


class Graph(BaseGraph):
    def depth_first_search(self, vertex):

        if vertex not in self.get_nodes():
            # NOTE: this behavior not specified in the instructions
            # could alternately raise an exception
            return []

        result = []

        stack = Stack()

        stack.push(vertex)

        visited = set()

        while stack:

            top = stack.peek()

            if top not in visited:
                result.append(top.value)

            visited.add(top)

            has_unvisited = False

            children = [edge.vertex for edge in self.get_neighbors(top)]

            for child in children:

                if child not in visited:

                    has_unvisited = True

                    stack.push(child)

                    break

            if not has_unvisited:
                stack.pop()

        return result
