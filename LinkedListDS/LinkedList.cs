namespace LinkedListDS;

public class LinkedList
{
    private class Node
    {
        public readonly int Value;
        internal Node? Next;
        public Node(int value)
        {
            Value = value;
        }
    }

    private Node? _first;
    private Node? _last;
    private int _size;

    // Add Lass ::> Add To The end of linkedList
    public void AddLast(int value)
    {
        var node = new Node(value);
        if (_first == null)
        {
            _first = _last = node;
        }
        else
        {
            _last!.Next = node;
            _last = node;
        }

        _size++;
    }
    
    // IndexOf ::> return index of item in the linkedList
    public int IndexOf(int value)
    {
        var index = 0;
        var current = _first;
        while (current != null)
        {
            if (current.Value == value) return index;
            current = current.Next;
            index++;
        }

        return -1;
    }
    
    // Contains ::> Find if a element is the linkedList
    public bool Contains(int value)
    {
        if (IndexOf(value) != -1) return true;
        return false;
        // return IndexOf(value) != -1; (Smarter way)
    }
    
    // Add First ::> Add to the beginning of the linkedList
    public void AddFirst(int value)
    {
        var node = new Node(value);
        if (_first == null)
        {
            AddLast(value);
            _size++;
        }
        var temp = _first;
        _first = node;
        _first.Next = temp;
        _size++;
    }
    
    // Delete First ::> Delete the first element of a linkedList
    public void DeleteFirst()
    {
        var secondElement = _first?.Next;
        _first = null;
        _first = secondElement;
        _size--;
    }
    
    // Delete Last ::> Delete the last element of a linkedList
    public void DeleteLast()
    {
        if (_first == _last)
        {
            _first = _last = null;
            _size--;
            return;
        }
        
        var previousNode = GetPreviousNode(_last!);
        _last =  previousNode;
        if (_last != null) _last.Next = null;
        _size--;
    }
    
    // GetPreviousNode ::> We get the previous node of a given node
    private Node? GetPreviousNode(Node node)
    {
        var current = _first;
        while (current != null)
        {
            if (current.Next == node) return current;
            current = current.Next;
        }

        return null;
    }
    
    // IsEmpty ::> Checks if the linkedList is empty
    private bool IsEmpty()
    {
        return _first  == null && _last == null;
    }
    
    // Size :: > Gets the size of the linkedList
    public int Size()
    {
        return _size;
    }
    
    // ToArray ::> Convert the linkedList into Array
    public int[] ToArray()
    {
        var array = new int[_size];
        var current = _first;
        var index = 0;

        while (current != null)
        {
            array[index] = current.Value;
            index++;
            current = current.Next;
        }

        return array;
    }
    
    // Reverse ::> Reverse a linkedList in place
    public void Reverse()
    {
        if(IsEmpty()) return;

        var previous = _first;
        var current = _first?.Next;

        while (current != null)
        {
            // gets next value
            // [10 -> 20 -> 30 -> 40]
            //   p     c     n
            var next = current.Next;
            // sets / invert the pointer[link] in another direction
            current.Next = previous;
            // Updates previous
            previous = current;
            // updates current
            current = next;
        }
        // assign last as first element
        _last = _first;
        _last!.Next = null;
        // gets the last element in inverted which become the first
        _first = previous;
    }
    
    // Get the kth node from the end of the linked list in one pass
    public int GetTheKthNodeFromEnd(int k)
    {
        if (k > _size) throw new ArgumentException();
        // all pointers are initialized from the _first.
        var firstPtr = _first;
        var secondPtr = _first;
        // fast forward the second pointer
        for (var index = 0; index < k - 1; index++)
        {
            secondPtr = secondPtr?.Next;
        }
        
        // make the second pointer reach the end while the first pointer is following
        while (secondPtr != _last)
        {
            firstPtr = firstPtr?.Next;
            secondPtr = secondPtr?.Next;
        }

        return firstPtr!.Value;
    }
    
    // PrintMiddle
    public void PrintMiddle()
    {
        var a = _first;
        var b = _first;
        while (b != _last && b.Next != _last)
        {
            b = b.Next!.Next;
            a = a!.Next;
        }

        if (b == _last)
        {
            Console.WriteLine(a!.Value);
        }
        else
        {
            Console.WriteLine(a!.Value + ", " + a.Next!.Value);
        }
    }

}