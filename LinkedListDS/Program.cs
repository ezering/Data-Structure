using LinkedListDS;
Console.WriteLine(":: > Linked Lists Data Structure");


Console.WriteLine(":: > Linked Lists Data Structure");

LinkedList linkedList = new LinkedList();

linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddLast(40);
linkedList.AddLast(50);
linkedList.AddLast(60);

linkedList.AddFirst(0);
// linkedList.AddFirst(5);

linkedList.DeleteFirst();
linkedList.Reverse();
linkedList.ToArray();
linkedList.DeleteLast();
linkedList.AddLast(70);

Console.WriteLine("The Kth Value: {0}", linkedList.GetTheKthNodeFromEnd(2));
Console.WriteLine("Index Result: {0}", linkedList.IndexOf(30));
Console.WriteLine("Contains ?: {0}", linkedList.Contains(30));
Console.WriteLine("LinkedList Size: {0}", linkedList.Size());
