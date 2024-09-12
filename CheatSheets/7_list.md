### C# `List<T>` Cheat Sheet

The `List<T>` class in C# is a generic collection that stores elements of a specified type. It is part of the `System.Collections.Generic` namespace and provides a dynamic array that can grow and shrink.

---

### **Basic Syntax:**

```csharp
List<T> listName = new List<T>();
```

- `T`: The type of elements in the list (e.g., `int`, `string`, `custom_class`).

---

### **Common Operations:**

#### **Creating a List:**
```csharp
List<int> numbers = new List<int>();
List<string> words = new List<string>();
```

#### **Adding Elements:**
- **Add a single element:**
  ```csharp
  listName.Add(element);
  ```
  Example:
  ```csharp
  numbers.Add(10);
  words.Add("hello");
  ```

- **Add multiple elements (using `AddRange`):**
  ```csharp
  listName.AddRange(collection);
  ```
  Example:
  ```csharp
  numbers.AddRange(new int[] { 1, 2, 3 });
  ```

#### **Accessing Elements:**
- **By index:**
  ```csharp
  T element = listName[index];
  ```
  Example:
  ```csharp
  int firstNumber = numbers[0];
  ```

- **Set value at a specific index:**
  ```csharp
  listName[index] = value;
  ```

#### **Inserting Elements:**
- **Insert an element at a specific index:**
  ```csharp
  listName.Insert(index, element);
  ```
  Example:
  ```csharp
  numbers.Insert(2, 99);
  ```

#### **Removing Elements:**
- **Remove by value:**
  ```csharp
  listName.Remove(element);
  ```
  Example:
  ```csharp
  numbers.Remove(10);
  ```

- **Remove at a specific index:**
  ```csharp
  listName.RemoveAt(index);
  ```
  Example:
  ```csharp
  numbers.RemoveAt(0);
  ```

- **Remove all elements that match a condition:**
  ```csharp
  listName.RemoveAll(predicate);
  ```
  Example:
  ```csharp
  numbers.RemoveAll(x => x > 5);
  ```

- **Clear the list (removes all elements):**
  ```csharp
  listName.Clear();
  ```

#### **Checking Elements:**
- **Check if the list contains a value:**
  ```csharp
  bool exists = listName.Contains(element);
  ```
  Example:
  ```csharp
  bool hasFive = numbers.Contains(5);
  ```

- **Find the index of an element:**
  ```csharp
  int index = listName.IndexOf(element);
  ```
  Example:
  ```csharp
  int index = numbers.IndexOf(99);
  ```

#### **Finding Elements:**
- **Find the first matching element:**
  ```csharp
  T found = listName.Find(predicate);
  ```
  Example:
  ```csharp
  int found = numbers.Find(x => x > 5);
  ```

- **Find all matching elements:**
  ```csharp
  List<T> found = listName.FindAll(predicate);
  ```
  Example:
  ```csharp
  List<int> greaterThanFive = numbers.FindAll(x => x > 5);
  ```

#### **Other Useful Methods:**
- **Count the elements:**
  ```csharp
  int count = listName.Count;
  ```

- **Sort the list:**
  ```csharp
  listName.Sort();
  ```

- **Reverse the list:**
  ```csharp
  listName.Reverse();
  ```

- **Convert to an array:**
  ```csharp
  T[] array = listName.ToArray();
  ```

#### **Capacity Management:**
- **Check capacity:**
  ```csharp
  int capacity = listName.Capacity;
  ```

- **Set capacity:**
  ```csharp
  listName.Capacity = newCapacity;
  ```

#### **Looping through the list:**
- **Using a `for` loop:**
  ```csharp
  for (int i = 0; i < listName.Count; i++)
  {
      Console.WriteLine(listName[i]);
  }
  ```

- **Using a `foreach` loop:**
  ```csharp
  foreach (T item in listName)
  {
      Console.WriteLine(item);
  }
  ```

---

### **Example Usage:**

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        // Add an element
        numbers.Add(6);

        // Insert an element at index 2
        numbers.Insert(2, 10);

        // Remove element by value
        numbers.Remove(4);

        // Remove element at index 0
        numbers.RemoveAt(0);

        // Sort the list
        numbers.Sort();

        // Find element > 3
        int result = numbers.Find(x => x > 3);

        // Print the list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
```

---

This cheat sheet should help you perform common operations with `List<T>` in C#.