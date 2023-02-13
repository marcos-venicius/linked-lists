using Lib.Extensions;

namespace Lib.Tests;

public class SinglyLinkedListTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 3)]
    [InlineData(new[] { 1, 2, 3, 4 }, 3)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new int[] { }, null)]
    public void Should_Get_Middle_Node(int[] nodes, int? expected)
    {
        var structure = new SinglyLinkedList<int>();

        foreach (var node in nodes)
            structure.Add(node);

        var middleNode = structure.GetMiddle();

        Assert.Equal(expected, middleNode?.Value);
    }

    [Fact]
    public void Should_Start_Head_And_Tail_As_Null()
    {
        var structure = new SinglyLinkedList<int>();

        Assert.Null(structure.Head);
        Assert.Null(structure.Tail);
    }

    [Fact]
    public void Head_And_Tail_Should_Be_The_Same_When_Add_To_The_Top_As_First_Node()
    {
        var structure = new SinglyLinkedList<int>();

        structure.AddOnTop(10);

        Assert.Equal(10, structure.Head?.Value);
        Assert.Same(structure.Head, structure.Tail);

        Assert.Equal(10, structure.Tail?.Value);
        Assert.Null(structure.Tail?.Next);
    }

    [Fact]
    public void Node_Appended_Should_Be_The_List_Head_When_Add_On_Top_But_The_List_Already_Has_Nodes()
    {
        var structure = new SinglyLinkedList<int>();

        structure.Add(1);
        structure.Add(2);
        structure.Add(3);
        structure.AddOnTop(0);

        Assert.Equal(0, structure.Head?.Value);
        Assert.Equal(structure.Head?.Next?.Value, 1);

        Assert.Equal(3, structure.Tail?.Value);
        Assert.Null(structure.Tail?.Next);
    }

    [Fact]
    public void Head_And_Tail_Should_Be_The_Same_When_Add_First_Node()
    {
        var structure = new SinglyLinkedList<int>();

        structure.Add(10);

        Assert.Equal(10, structure.Head?.Value);
        Assert.Same(structure.Head, structure.Tail);

        Assert.Equal(10, structure.Tail?.Value);
        Assert.Null(structure.Tail?.Next);
    }

    [Fact]
    public void Head_Should_Be_The_First_Inserted_Element_And_Tail_The_Last_When_Add_More_Than_One()
    {
        var structure = new SinglyLinkedList<int>();

        structure.Add(10);
        structure.Add(20);
        structure.Add(30);

        Assert.NotSame(structure.Head, structure.Tail);
        Assert.Null(structure.Tail?.Next);
        Assert.Equal(10, structure.Head?.Value);
        Assert.Equal(30, structure.Tail?.Value);
    }

    [Fact]
    public void Should_Return_Node_With_Value_When_Call_FindFirstOrDefault()
    {
        var structure = new SinglyLinkedList<int>();

        for (var i = 0; i < 1000; i++)
        {
            structure.Add(i);
        }

        var node = structure.FindFirstOrDefault(567);

        Assert.Equal(node?.Value, 567);
        Assert.Equal(node?.Next?.Value, 568);
    }

    [Fact]
    public void Should_Return_Null_With_Node_Not_Found_In_FindFirstOrDefault()
    {
        var structure = new SinglyLinkedList<int>();

        for (var i = 0; i < 1000; i++)
        {
            structure.Add(i);
        }

        var node = structure.FindFirstOrDefault(-1);

        Assert.Null(node);
    }

    [Fact]
    public void Should_Return_Node_When_Find_By_Index_If_Node_Index_Exists()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        var node = structure[1];

        Assert.Equal(node?.Value, 'B');
        Assert.Equal(node?.Next?.Value, 'C');
    }

    [Fact]
    public void Should_Return_Null_When_Find_By_Index_Not_Found_Node()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        var node = structure[3];

        Assert.Null(node);
    }

    [Fact]
    public void Should_Return_True_If_Has_Value_On_List()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        var result = structure.Has('B');

        Assert.True(result);
    }

    [Fact]
    public void Should_Return_False_If_Not_Has_Value_On_List()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        var result = structure.Has('D');

        Assert.False(result);
    }

    [Fact]
    public void Should_Reverse_Linked_List()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');
        structure.Add('D');

        var headBeforeReverse = structure.Head;
        var tailBeforeReverse = structure.Tail;

        structure.Reverse();

        var array = structure.ToArray().ToList();

        Assert.Equal('D', array[0]);
        Assert.Equal('C', array[1]);
        Assert.Equal('B', array[2]);
        Assert.Equal('A', array[3]);

        Assert.Null(structure.Tail?.Next);
        
        Assert.Same(headBeforeReverse, structure.Tail);
        Assert.Same(tailBeforeReverse, structure.Head);
        
        Assert.Equal("D -> C -> B -> A", structure.ToString());
    }
}