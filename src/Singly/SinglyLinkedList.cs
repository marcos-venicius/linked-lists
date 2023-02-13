using System.Text;

namespace Singly;

/// <summary>
/// singly linked list data structure abstraction
/// </summary>
/// <typeparam name="T">value type you to store</typeparam>
public sealed class SinglyLinkedList<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }

    /// <summary>
    /// add a new node at the end of the linked list
    /// </summary>
    /// <param name="data">data to add to the list</param>
    public void Add(T data)
    {
        var node = new Node<T>(data);

        if (Tail is not null)
        {
            Tail.Next = node;
            Tail = Tail.Next;
        }
        else
        {
            Head = node;
            Tail = node;
            Head.Next = Tail;
            Tail.Next = null;
        }
    }

    /// <summary>
    /// add node to head of linked list
    /// </summary>
    /// <param name="data">data</param>
    public void AddOnTop(T data)
    {
        var node = new Node<T>(data);

        if (Head is not null)
        {
            node.Next = Head;
            Head = node;
        }
        else
        {
            Head = node;
            Tail = node;
            Head.Next = Tail;
            Tail.Next = null;
        }
    }

    /// <summary>
    /// find the first node that has the <paramref name="data"/> or default value
    /// </summary>
    /// <param name="data">value to search</param>
    /// <returns>if found, node. if not found, null</returns>
    public Node<T>? FindFirstOrDefault(T data)
    {
        var current = Head;

        while (current is not null)
        {
            if ((bool)data?.Equals(current.Value))
                return current;

            current = current.Next;
        }

        return default;
    }

    /// <summary>
    /// check if have a node with this <paramref name="data"/>
    /// </summary>
    /// <param name="data">data to find</param>
    /// <returns>return true if at least one node with this value is found</returns>
    public bool Has(T data) => FindFirstOrDefault(data) is { };

    private Node<T>? FindByIndex(uint index)
    {
        var current = Head;
        uint currentIndex = 0;

        while (current is not null)
        {
            if (currentIndex == index)
                return current;

            currentIndex++;
            current = current.Next;
        }

        return null;
    }

    /// <summary>
    /// find a node by your <paramref name="index" />
    /// </summary>
    /// <param name="index">node index</param>
    public Node<T>? this[uint index] => FindByIndex(index);

    public Node<T>? GetMiddle()
    {
        var end = Head;
        var middle = Head;

        while (end?.Next is not null)
        {
            middle = middle?.Next;
            end = end.Next.Next;
        }

        return middle;
    }

    /// <summary>
    /// reverse the linked list
    /// </summary>
    public void Reverse()
    {
        // imagine we have the following list: A -> B -> C -> D
        // we will point:
        // A -> Null
        // B -> A
        // C -> B
        // D -> C

        // making the D to be the head and A to be the tail

        if (Head is null)
            return;

        Tail = Head;

        Node<T>? prev = null;
        var current = Head;

        while (current is not null)
        {
            var next = current.Next;

            current.Next = prev;

            prev = current;
            current = next;
        }

        Head = prev;
        Tail.Next = null;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        var current = Head;

        while (current is not null)
        {
            stringBuilder.Append(current.Value);

            if (current.Next is not null)
                stringBuilder.Append(" -> ");

            current = current.Next;
        }

        return stringBuilder.ToString();
    }
}