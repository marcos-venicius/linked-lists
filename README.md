# Linked Lists

this lib abstracts the linked lists behaviors to friendly classes

----- 

[![Lib Test](https://github.com/marcos-venicius/linked-lists/actions/workflows/test-lib.yml/badge.svg)](https://github.com/marcos-venicius/linked-lists/actions/workflows/test-lib.yml)


## Support

- [x] Singly
- [ ] Doubly
- [ ] Circular
- [ ] Circular doubly

![image](https://user-images.githubusercontent.com/94018427/218503850-806ef9b5-24f8-4112-93e0-73538116f1dc.png)


## Operations

- [Add](#add)
- [AddOnTop](#add-on-top)
- [FindFirstOrDefault](#find-first-or-default)
- [Has](#has)
- [FindByIndex](#find-by-index)
- [GetMiddle](#get-middle)
- [Reverse](#reverse)
- [ToString](#to-string)
- [ToArray](#to-array) extension method
- [ForEach](#foreach) extension method
- [Sum](#sum) extension method

### Add

with this operation you can add a new node to the linked list tail

```csharp
var structure = new SinglyLinkedList<int>();

// you can add

structure.Add(10);
structure.Add(20);
structure.Add(30);

Console.WriteLine(structure); // 10 -> 20 -> 30
```

### Add On Top

with this operation you can add new node to the linked list head

```csharp
var structure = new SinglyLinkedList<int>();

// you can add on top

structure.AddOnTop(10); // 10
structure.AddOnTop(20); // 20 -> 10
structure.AddOnTop(30); // 30 -> 20 -> 10

Console.WriteLine(structure); // 30 -> 20 -> 10
```

### Find First Or Default

with this operation you can get the first node that has the value you pass as argument or default value

```csharp
var structure = new SinglyLinkedList<int>();

// you can find first occurence

structure.Add(10);
structure.Add(20);
structure.Add(30);

var node = structure.FindFirstOrDefault(20);

Console.WriteLine(node); // 20
Console.WriteLine(node?.Next); // 30
```

### Has

with this operation you can check if a data exists on the linked list

```csharp
var structure = new SinglyLinkedList<int>();

// you can check if has some data

structure.Add(10);
structure.Add(20);
structure.Add(30);

var result1 = structure.Has(20);
var result2 = structure.Has(50);

Console.WriteLine(result1); // True
Console.WriteLine(result2); // False
```

### Find By Index

with this operation you can get a node by index `array-like`

```csharp
var structure = new SinglyLinkedList<int>();

// you can get by index

structure.Add(10);
structure.Add(20);
structure.Add(30);

var node = structure[1];
var notFoundNode = structure[10];

Console.WriteLine(node); // 20
Console.WriteLine(notFoundNode) // <empty> (because returns null instead of an exception)
```

### Get Middle

with this operation you will get the middle node on the linked list

```csharp
var structure1 = new SinglyLinkedList<int>();
var structure2 = new SinglyLinkedList<int>();

structure1.Add(10);
structure1.Add(20);
structure1.Add(30);

structure2.Add(10);
structure2.Add(20);
structure2.Add(30);
structure2.Add(40);

var node1 = structure1.GetMiddle();
var node2 = structure2.GetMiddle();

Console.WriteLine(node1); // 20
Console.WriteLine(node2); // 30
```

### Reverse

this operation will reverse the linked list nodes

```csharp
var structure = new SinglyLinkedList<char>();

structure.Add('A');
structure.Add('B');
structure.Add('C');
structure.Add('D');

var str = structure.ToString();

Console.WriteLine(str); // D -> C -> B -> A
```

### To String

with this operation you can convert a linked list to a string

```csharp
var structure = new SinglyLinkedList<char>();

structure.Add('A');
structure.Add('B');
structure.Add('C');

var str = structure.ToString();

Console.WriteLine(str); // A -> B -> C
```

### To Array

this operation allow you to convert the linked list to a `IEnumerable<T>`.

```csharp
var structure = new SinglyLinkedList<char>();

structure.Add('A');
structure.Add('B');
structure.Add('C');

var array = structure.ToArray().ToList();

Console.WriteLine(array[0]); // A
Console.WriteLine(array[1]); // B
Console.WriteLine(array[2]); // C
```

### ForEach

this operation allow you to iterate over the entire linked list, from head to tail and you have access to the value in
the iteration

```csharp
var structure = new SinglyLinkedList<char>();

structure.Add('A');
structure.Add('B');
structure.Add('C');

structure.ForEach(value => {
    // the value will be A, B, C .....
});
```

### Sum

this operations will only appear on specific types of list. for now, this types are allowed:

- int
- double
- float

this operation allow you to sum the linked list

```csharp
var structure = new SinglyLinkedList<int>();

structure.Add(10);
structure.Add(20);
structure.Add(30);

var sum = structure.Sum();

Console.WriteLine(sum); // 60
```
