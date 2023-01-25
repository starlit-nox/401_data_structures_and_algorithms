def direct_flights(graph, location_names):

    cost = 0

    for origin_name, destination_name in zip(
        location_names, location_names[1:]
    ):
        nodes = graph.get_nodes()

        origin_node = None

        for candidate_node in nodes:
            if candidate_node.value == origin_name:
                origin_node = candidate_node
                break

        if not origin_node:
            return False, 0

        edges = graph.get_neighbors(origin_node)

        destination_node = None

        for edge in edges:
            if edge.vertex.value == destination_name:
                cost += edge.weight
                destination_node = edge.vertex
                break

        if not destination_node:
            return False, 0

    return True, cost
