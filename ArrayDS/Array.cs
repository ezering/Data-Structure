namespace ArrayDS;

public class Array
{
    private int[] _intArray;
    private int _count;
    public Array(int length)
    {
        _intArray = new int[length];
    }
    
    // Insert => automatic growth
    public void Insert(int value)
    {
        if (_count == _intArray.Length)
        {
            var newArray = new int[_count * 2];
            for (var index = 0; index < _intArray.Length; index++)
            {
                newArray[index] = _intArray[index];
            }

            _intArray = newArray;
        }
        _intArray[_count] = value;
        _count++;
    }
    
    // Insert At => Index
    public void InsertAt(int index, int value)
    {
        if (_count == _intArray.Length)
        {
            var newArray = new int[_count * 2];
            for (var i = 0; i < _intArray.Length; i++)
            {
                newArray[i] = _intArray[index];
            }

            _intArray = newArray;
        }
        for (var i = _count - 1 ; i >= index; i--)
        {
            _intArray[i + 1] = _intArray[i];
            if (i == index)
            {
                _intArray[index] = value;
            }
        }
        _count++;
    }
    
    // RemoveAt => index
    public void RemoveAt(int index)
    {
        for (var i = index; i < _count - 1; i++)
        {
            _intArray[i] = _intArray[i + 1];
        }
        _intArray[_count - 1] = 0;
        _count--;
    }
    
    // indexOf => finding the index of an element
    public int IndexOf(int value)
    {
        for (var index = 0; index < _intArray.Length; index++)
        {
            if (_intArray[index] == value)
            {
                return index;
            }
        }
        return -1;
    }
    
    // count => number of elements
    public int Count()
    {
        return _count;
    }

    // Biggest number in array
    public int Maximum()
    {
        var maxValue = 0;
        for (var index = 0; index < _count; index++)
        {
            var currentValue = _intArray[index];
            if (maxValue < currentValue) maxValue = currentValue;
        }
        return maxValue;
    }
    
    // Reversing Array
    public void Reverse()
    {
        for (var index = 0; index < _intArray.Length; index++)
        {
            var lastIndex = _intArray.Length - index;
            if (index >= lastIndex) continue;
            // swapping via deconstruction
            (_intArray[index], _intArray[lastIndex - 1]) = (_intArray[lastIndex - 1], _intArray[index]);
        }
    }
    
    // Arrays Intersection
    public int[] Intersect(int[] inputArray)
    {
        var intersectArray = new List<int>();
        for (var i = 0; i < _intArray.Length; i++)
        {
            for (var j = 0; j < inputArray.Length; j++)
            {
                if (i == j)
                {
                    intersectArray.Add(_intArray[i]);
                }
            }
        }
        return intersectArray.ToArray();
    }
    
    // Print
    public void Print()
    {
        var result = string.Join(", ", _intArray);
        Console.WriteLine("Result Array: " + "[" +result +"]");
    }
    
    // Print
    public static void Print(int[] array)
    {
        var result = string.Join(", ", array);
        Console.WriteLine("Result Array: " + "[" +result +"]");
    }
}