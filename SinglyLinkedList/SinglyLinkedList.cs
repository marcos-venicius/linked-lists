using System.Text;

namespace SinglyLinkedList;

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
        }
    }

    /// <summary>
    /// find the first node that has the <paramref name="data"/>
    /// </summary>
    /// <param name="data">value to search</param>
    /// <returns>if found, node. if not found, null</returns>
    public Node<T>? FindFirst(T data)
    {
        var current = Head;

        while (current is not null)
        {
            if ((bool)data?.Equals(current.Value))
                return current;

            current = current.Next;
        }

        return null;
    }

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

        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }
}