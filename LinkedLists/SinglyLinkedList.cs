using System.Runtime.CompilerServices;
using System.Text;

namespace LinkedLists;

public delegate void ForEach<in T>(T data, int index);

public sealed class SinglyLinkedList<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        var current = Head;

        while (current is not null)
        {
            stringBuilder.Append(current.Value);

            if (current.Next is not null)
                stringBuilder.Append(" --> ");

            current = current.Next;
        }

        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }

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
        }
    }

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

    public bool Has(T data) => FindFirst(data) is not null;

    public Node<T>? FindFirst(T? data)
    {
        var current = Head;

        while (current is not null)
        {
            if ((bool)data?.Equals(current.Value))
                return current;

            current = current.Next;
        }

        return current;
    }

    public void ForEach(ForEach<T> predicate)
    {
        var current = Head;
        var index = 0;

        while (current is not null)
        {
            predicate(current.Value, index++);

            current = current.Next;
        }
    }

    private Node<T>? FindByIndex(int index)
    {
        var current = Head;
        var currentIndex = 0;

        while (current is not null)
        {
            if (currentIndex == index)
                return current;

            currentIndex++;
            current = current.Next;
        }

        return current;
    }

    [IndexerName("SinglyLinkedListIndexer")]
    public Node<T>? this[uint index] => FindByIndex((int)index);
}

public static class SinglyLinkedListExt
{
    public static int Sum(this SinglyLinkedList<int> singlyLinkedList)
    {
        var sum = 0;

        var current = singlyLinkedList.Head;

        while (current is not null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }

    public static double Sum(this SinglyLinkedList<double> singlyLinkedList)
    {
        var sum = 0.0;

        var current = singlyLinkedList.Head;

        while (current is not null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }

    public static float Sum(this SinglyLinkedList<float> singlyLinkedList)
    {
        var sum = 0f;

        var current = singlyLinkedList.Head;

        while (current is not null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }

    public static IEnumerable<T> ToArray<T>(this SinglyLinkedList<T> singlyLinkedList)
    {
        List<T> list = new();

        var current = singlyLinkedList.Head;

        while (current is not null)
        {
            list.Add(current.Value);

            current = current.Next;
        }

        return list;
    }
}