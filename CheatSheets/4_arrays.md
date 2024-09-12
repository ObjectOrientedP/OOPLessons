Here's a C# array cheat sheet that covers basic operations, syntax, and common methods:

---

## **C# Array Cheat Sheet**

### **1. Declaring and Initializing Arrays**

- **Single-dimensional array:**
  ```csharp
  // Declaration
  int[] numbers;
  
  // Initialization with size
  numbers = new int[5]; 
  
  // Declaration and initialization
  int[] numbers = new int[] { 1, 2, 3, 4, 5 };
  
  // Simplified syntax
  int[] numbers = { 1, 2, 3, 4, 5 };
  ```

- **Multidimensional array:**
  ```csharp
  // 2D array (matrix)
  int[,] matrix = new int[2, 3]; // 2 rows, 3 columns
  
  // 2D array with initialization
  int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
  ```

- **Jagged array (array of arrays):**
  ```csharp
  int[][] jaggedArray = new int[3][];
  
  // Initialize sub-arrays
  jaggedArray[0] = new int[] { 1, 2 };
  jaggedArray[1] = new int[] { 3, 4, 5 };
  jaggedArray[2] = new int[] { 6 };
  ```

### **2. Accessing Array Elements**
- **Access single element:**
  ```csharp
  int firstElement = numbers[0]; // Access first element
  
  // Modify an element
  numbers[2] = 10; // Changes the third element to 10
  ```

- **Access elements in a multidimensional array:**
  ```csharp
  int element = matrix[0, 1]; // Access element at first row, second column
  ```

### **3. Array Properties**

- **Length:**
  ```csharp
  int length = numbers.Length; // Total number of elements in array
  ```

- **Rank:**
  ```csharp
  int rank = matrix.Rank; // Number of dimensions in array
  ```

### **4. Iterating through Arrays**

- **Using a `for` loop:**
  ```csharp
  for (int i = 0; i < numbers.Length; i++)
  {
      Console.WriteLine(numbers[i]);
  }
  ```

- **Using a `foreach` loop:**
  ```csharp
  foreach (int number in numbers)
  {
      Console.WriteLine(number);
  }
  ```

- **Multidimensional array:**
  ```csharp
  for (int i = 0; i < matrix.GetLength(0); i++) // Iterate rows
  {
      for (int j = 0; j < matrix.GetLength(1); j++) // Iterate columns
      {
          Console.WriteLine(matrix[i, j]);
      }
  }
  ```

### **5. Common Array Methods**

- **Array.Sort():**
  ```csharp
  Array.Sort(numbers); // Sort array in ascending order
  ```

- **Array.Reverse():**
  ```csharp
  Array.Reverse(numbers); // Reverse the array elements
  ```

- **Array.IndexOf():**
  ```csharp
  int index = Array.IndexOf(numbers, 3); // Find index of element '3'
  ```

- **Array.Clear():**
  ```csharp
  Array.Clear(numbers, 0, numbers.Length); // Set all elements to 0
  ```

- **Array.Copy():**
  ```csharp
  int[] newArray = new int[numbers.Length];
  Array.Copy(numbers, newArray, numbers.Length); // Copy to new array
  ```

### **6. Common Array Scenarios**

- **Checking if an array contains an element:**
  ```csharp
  bool contains = numbers.Contains(3); // Requires 'using System.Linq;'
  ```

- **Find maximum or minimum value:**
  ```csharp
  int max = numbers.Max(); // Requires 'using System.Linq;'
  int min = numbers.Min(); // Requires 'using System.Linq;'
  ```

- **Finding a specific element:**
  ```csharp
  int found = Array.Find(numbers, element => element > 3); // First element greater than 3
  ```

### **7. Resizing Arrays**

- **Array.Resize():**
  ```csharp
  Array.Resize(ref numbers, 10); // Resize array to have 10 elements
  ```

---

This cheat sheet provides a quick reference for working with arrays in C#. It covers array declaration, accessing elements, common methods, and basic operations like sorting and searching.