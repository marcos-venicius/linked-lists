namespace SinglyLinkedListAbstraction;

public sealed class Node<T>
{
    public T Value { get; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }

    public override string? ToString()
    {
        return Value?.ToString();
    }
}