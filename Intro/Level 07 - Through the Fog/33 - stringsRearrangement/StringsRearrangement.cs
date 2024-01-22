/*  
    Problem
    --------------------------------------------------------------------------------
    Given an array of equal-length strings, you'd like to know if it's possible
    to rearrange the order of the elements in such a way that each consecutive
    pair of strings differ by exactly one character. Return true if it's possible,
    and false if not.
    
    Note: You're only rearranging the order of the strings, not the order of the
    letters within the strings!

    Example

    For inputArray = ["aba", "bbb", "bab"], the output should be
    solution(inputArray) = false.

    There are 6 possible arrangements for these strings:
    ["aba", "bbb", "bab"]
    ["aba", "bab", "bbb"]
    ["bbb", "aba", "bab"]
    ["bbb", "bab", "aba"]
    ["bab", "bbb", "aba"]
    ["bab", "aba", "bbb"]
    None of these satisfy the condition of consecutive strings differing by 1 
    character, so the answer is false.

    For inputArray = ["ab", "bb", "aa"], the output should be
    solution(inputArray) = true.

    It's possible to arrange these strings in a way that each consecutive pair
    of strings differ by 1 character (eg: "aa", "ab", "bb" or "bb", "ab", "aa"),
    so return true.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    In graph theory, a Hamiltonian path in a directed graph is a path that visits
    every vertex exactly once. It is named after Sir William Rowan Hamilton, an
    Irish mathematician who introduced the concept. Unlike Hamiltonian cycles,
    which form a closed loop by returning to the starting vertex, Hamiltonian
    paths do not have this requirement.
    
    Formally, a Hamiltonian path in a directed graph is a sequence of vertices
    (or nodes) such that each vertex is visited exactly once, and there is a
    directed edge from one vertex to the next in the sequence.
    
    In a directed graph, finding a Hamiltonian path can be a challenging problem,
    as it requires exploring all possible paths to determine whether a Hamiltonian
    path exists. The problem is known to be NP-complete, meaning that there is no
    known efficient algorithm to solve it in polynomial time unless P equals NP.
    
    A Hamiltonian decision problem is a computational problem related to the
    existence of Hamiltonian paths or cycles in a graph. The problem is often
    stated as a decision problem, which means it seeks a yes-or-no answer based
    on a particular property of the input graph.
*/

class Node
{
    readonly List<Edge> edges;

    public List<Edge> Edges { get { return edges; } }

    public Node()
    {
        edges = new List<Edge>();
    }

    public void AddEdge(Edge edge)
    {
        edges.Add(edge);
    }
}

class Edge
{
    readonly Node left;
    readonly Node right;

    public Node Left { get { return left; } }
    public Node Right { get { return right; } }

    public Edge(Node left, Node right)
    {
        this.left = left;
        this.right = right;
    }
}

bool solution(string[] inputArray)
{
    var edges = new List<Edge>();
    var nodes = inputArray.Select(node => new Node()).ToList();

    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = i + 1; j < inputArray.Length; j++)
        {
            var differences = 0;

            for (int k = 0; k < inputArray[i].Length && differences <= 1; k++)
            {
                if (inputArray[i][k] != inputArray[j][k])
                {
                    differences++;
                }
            }

            if (differences == 1)
            {
                var edge = new Edge(nodes[i], nodes[j]);

                edges.Add(edge);
                nodes[i].AddEdge(edge);
                nodes[j].AddEdge(edge);
            }
        }
    }

    if (nodes.Any(node => node.Edges.Count == 0))
    {
        return false;
    }

    return HamiltonianDecision(edges, nodes);
}

bool HamiltonianDecision(List<Edge> edges, List<Node> nodes, HashSet<Node> path, Node currentNode)
{
    if (path.Count == nodes.Count)
    {
        return true;
    }

    foreach (var edge in currentNode.Edges)
    {
        var node = edge.Left == currentNode ? edge.Right : edge.Left;

        if (!path.Contains(node))
        {
            path.Add(node);
            if (HamiltonianDecision(edges, nodes, path, node))
            {
                return true;
            }

            path.Remove(node);
        }
    }

    return false;
}

bool HamiltonianDecision(List<Edge> edges, List<Node> nodes)
{
    nodes.Sort(CompareNodes);

    var path = new HashSet<Node>();

    foreach (var node in nodes)
    {
        path.Clear();
        path.Add(node);
        
        if (HamiltonianDecision(edges, nodes, path, node))
        {
            return true;
        }
    }

    return false;
}

int CompareNodes(Node a, Node b)
{
    return a.Edges.Count.CompareTo(b.Edges.Count);
}

