using Singly.Extensions;

namespace Singly.Tests;

public class SinglyLinkedListExtensionsTests
{
    [Fact]
    public void Should_Sum_Int_Linked_List_Nodes()
    {
        var structure = new SinglyLinkedList<int>();
        
        structure.Add(10);
        structure.Add(30);
        structure.Add(20);

        var sum = structure.Sum();
        
        Assert.Equal(60, sum);
    }
    
    [Fact]
    public void Should_Sum_Double_Linked_List_Nodes()
    {
        var structure = new SinglyLinkedList<double>();
        
        structure.Add(10);
        structure.Add(30);
        structure.Add(20);

        var sum = structure.Sum();
        
        Assert.Equal(60, sum);
    }
    
    [Fact]
    public void Should_Sum_Float_Linked_List_Nodes()
    {
        var structure = new SinglyLinkedList<float>();
        
        structure.Add(10);
        structure.Add(30);
        structure.Add(20);

        var sum = structure.Sum();
        
        Assert.Equal(60, sum);
    }
    
    [Fact]
    public void Should_Transform_Linked_List_To_An_Array()
    {
        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        var list = structure.ToArray().ToList();

        Assert.Equal('A', list[0]);
        Assert.Equal('B', list[1]);
        Assert.Equal('C', list[2]);

        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Should_Iterate_Over_The_Entire_List()
    {
        var list = new List<char>();

        var structure = new SinglyLinkedList<char>();

        structure.Add('A');
        structure.Add('B');
        structure.Add('C');

        structure.ForEach(data => { list.Add(data); });

        Assert.Equal(3, list.Count);

        Assert.Equal('A', list[0]);
        Assert.Equal('B', list[1]);
        Assert.Equal('C', list[2]);
    }
}