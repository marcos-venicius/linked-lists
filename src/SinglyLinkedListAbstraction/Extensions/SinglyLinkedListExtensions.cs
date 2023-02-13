namespace SinglyLinkedListAbstraction.Extensions;

public static class SinglyLinkedListExtensions
{
    /// <summary>
    /// transform the linked list into an IEnumerable&lt;<typeparamref name="T" />&gt;
    /// </summary>
    /// <param name="linkedList">singly linked list</param>
    /// <typeparam name="T">singly linked list value type</typeparam>
    /// <returns>singly linked list as an array</returns>
    public static IEnumerable<T> ToArray<T>(this SinglyLinkedList<T> linkedList)
    {
        var list = new List<T>();
        
        linkedList.ForEach(value =>
        {
            list.Add(value);
        });

        return list;
    }

    /// <summary>
    /// iterate over each node on list
    /// </summary>
    /// <param name="linkedList">singly linked list</param>
    /// <param name="predicate">predicate</param>
    /// <typeparam name="T">list value type</typeparam>
    public static void ForEach<T>(this SinglyLinkedList<T> linkedList, Action<T> predicate)
    {
        var current = linkedList.Head;

        while (current is not null)
        {
            predicate(current.Value);

            current = current.Next;
        }
    }

    /// <summary>
    /// sum nodes
    /// </summary>
    /// <param name="singlyLinkedList">singly linked list</param>
    /// <returns>nodes sum</returns>
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
    
    /// <summary>
    /// sum nodes
    /// </summary>
    /// <param name="singlyLinkedList">singly linked list</param>
    /// <returns>nodes sum</returns>
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
    
    /// <summary>
    /// sum nodes
    /// </summary>
    /// <param name="singlyLinkedList">singly linked list</param>
    /// <returns>nodes sum</returns>
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
}
