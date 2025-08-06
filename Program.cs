class Program
{
    class Node
    {
        public int Value;
        public Node? Left, Right;
        public Node(int value) => Value = value;
    }

    static Node Build(int[] numbers)
    {
        int pivot = Array.IndexOf(numbers, numbers.Max());
        var root = new Node(numbers[pivot]);

        Node current = root;
        foreach (var n in numbers[..pivot].OrderByDescending(x => x))
        {
            current.Left = new Node(n);
            current = current.Left;
        }

        current = root;
        foreach (var n in numbers[(pivot + 1)..].OrderByDescending(x => x))
        {
            current.Right = new Node(n);
            current = current.Right;
        }

        return root;
    }

    static void Print(Node? node, int level = 0)
    {
        if (node == null) return;
        Console.WriteLine(new string(' ', level * 2) + node.Value);
        Print(node.Left, level + 1);
        Print(node.Right, level + 1);
    }

    static void Main()
    {
        int[] s1 = { 3, 2, 1, 6, 0, 5 };
        int[] s2 = { 7, 5, 13, 9, 1, 6, 4 };
        int[] s3 = { 30, 7, 5, 13, 9, 1, 6, 4, 20 };

        Console.WriteLine("Cenário 1:");
        Print(Build(s1));

        Console.WriteLine("\nCenário 2:");
        Print(Build(s2));

        Console.WriteLine("\nCenário 3:");
        Print(Build(s3));
    }
}
