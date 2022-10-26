// using my custom Array Class.
using Array = ArrayDS.Array;

Console.WriteLine(":: > Array Data Structure");

Array numbers = new Array(3);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.Insert(50);
numbers.Insert(60);

var randomArray = new int[] { 20, 30, 40 };


numbers.RemoveAt(1);
numbers.InsertAt(1, 20);
Console.WriteLine("Index: {0}",numbers.IndexOf(0));
Console.WriteLine("The Maximum: {0}", numbers.Maximum());
Console.WriteLine("Array Count: {0}", numbers.Count());
numbers.Print();
Array.Print(numbers.Intersect(randomArray));
numbers.Reverse();
numbers.Print();


// 2D ARRAYS - MULTI DIMENSIONAL ARRAYS
// a 2D array
int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } };

// access first element from first row
Console.WriteLine(x[0, 0]); // returns 1

// access third element from second row
Console.WriteLine(x[1, 2]);  // returns 5

// access third element from first row
Console.WriteLine(x[0, 2]);  // returns 3

 
// access first element from the first row
Console.WriteLine("Element at index [0, 0] : "+x[0, 0]);
  	 
// access first element from second row
Console.WriteLine("Element at index [1, 0] : "+x[1, 0]);

// Change Array Elements
// old element
Console.WriteLine("Old element at index [0, 0] : "+x[0, 0]);
 	 
// assigning new value
x[0, 0] = 222;
  	 
// new element
Console.WriteLine("New element at index [0, 0] : "+x[0, 0]);

// Iterating C# Array using Loop
int[ , ] numbers2D = { {2, 3, 9}, {4, 5, 9} };
   	 
for(var i = 0; i < numbers2D.GetLength(0); i++)  { 
	Console.Write("Row "+ i+": ");

	for(var j = 0; j < numbers2D.GetLength(1); j++)  { 
		Console.Write(numbers2D[i, j]+" ");
 
	}
	Console.WriteLine();
} 

/* Output:
 Row 0: 2 3 9 
 Row 1: 4 5 9 
*/



// JAGGED ARRAYS
// declare a jagged array
int[][] jaggedArray = new int[2][];

// set size of Jagged Array Elements
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[2];

// initialize the first array
jaggedArray[0][0] = 1;
jaggedArray[0][1] = 3;
jaggedArray[0][2] = 5;

// initialize the second array
jaggedArray[1][0] = 2;
jaggedArray[1][1] = 2;
      	 
// outer for loop
Console.WriteLine("#####################");
for (var i = 0; i < jaggedArray.Length; i++) {

	Console.Write("Element "+ i +": ");
	// inner for loop
	for (int j = 0; j < jaggedArray[i].Length; j++) {
		Console.Write(jaggedArray[i][j] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("#####################");
// declare and initialize jagged array with 2D array
int[][,] jaggedArrayNew = new int[3][ , ]  {
	new int[ , ] { {1, 8}, {6, 7} },
	new int[ , ] { {0, 3}, {5, 6}, {9, 10} },
	new int[ , ] { {11, 23}, {100, 88}, {0, 10} }
};

Console.WriteLine(jaggedArrayNew[0][0, 1]);
Console.WriteLine(jaggedArrayNew[1][2, 1]);
Console.WriteLine(jaggedArrayNew[2][1, 0]);

Console.WriteLine();