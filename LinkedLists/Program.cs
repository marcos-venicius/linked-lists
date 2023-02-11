namespace LinkedLists;

// - [ ] write a function that prints a singly linked list on display
// - [ ] write a function to get the last node in a singly linked list
// - [ ] write a function that converts a singly linked list to an array

public static class Program
{
    public static void Main()
    {
        var integers = new SinglyLinkedList<int>();
        var doubles = new SinglyLinkedList<double>();
        
        integers.Add(1);
        integers.Add(2);
        integers.Add(3);
        
        doubles.Add(1);
        doubles.Add(2.1);
        doubles.Add(2.9);

        Console.WriteLine(integers);
        Console.WriteLine(integers.Sum());
        
        Console.WriteLine(doubles);
        Console.WriteLine(doubles.Sum());
        
        var structure = new SinglyLinkedList<char>();
        
        structure.Add('B');
        structure.Add('C');
        structure.Add('D');
        structure.AddOnTop('A');

        var array = structure.ToArray();
        
        Console.WriteLine(structure);

        Console.WriteLine($"HAS 'B': {structure.Has('B')} {structure.FindFirst('B')?.Value}");

        Console.WriteLine();
        
        foreach (var value in array)
            Console.WriteLine(value);
    }
}