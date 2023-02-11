# Singly Linked List Abstraction

this lib abstracts the linked list behavior to a friendly `SinglyLinkedList<T>` class

## Operations

- [Add](#add)
- [AddOnTop](#add-on-top)
- [FindFirst](#find-first)
- [Has](#has)
- [FindByIndex](#find-by-index)
- [ToString](#to-string)

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

### Find First

with this operation you can get the first node that has the value you pass as argument

```csharp
var structure = new SinglyLinkedList<int>();

// you can find first occurence

structure.Add(10);
structure.Add(20);
structure.Add(30);

var node = structure.FindFirst(20);

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
