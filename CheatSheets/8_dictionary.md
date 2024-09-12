### C# Dictionary Cheat Sheet

#### 1. **Creating a Dictionary:**
```csharp
using System.Collections.Generic;

Dictionary<string, int> myDict = new Dictionary<string, int>();
```

#### 2. **Adding Key-Value Pairs:**
```csharp
myDict.Add("apple", 1);
myDict.Add("banana", 2);
myDict["cherry"] = 3;  // Another way to add key-value pairs
```

#### 3. **Accessing Values:**
```csharp
int appleCount = myDict["apple"];  // Access by key
```

#### 4. **Checking for Key Existence:**
```csharp
bool hasApple = myDict.ContainsKey("apple");  // True if key exists
```

#### 5. **Removing Key-Value Pairs:**
```csharp
myDict.Remove("banana");  // Removes the key-value pair
```

#### 6. **Updating Values:**
```csharp
myDict["apple"] = 10;  // Update the value for an existing key
```

#### 7. **Iterating Over Dictionary:**

##### **Keys and Values:**
```csharp
foreach (KeyValuePair<string, int> kvp in myDict) {
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
```

##### **Keys Only:**
```csharp
foreach (string key in myDict.Keys) {
    Console.WriteLine($"Key: {key}");
}
```

##### **Values Only:**
```csharp
foreach (int value in myDict.Values) {
    Console.WriteLine($"Value: {value}");
}
```

#### 8. **Clearing the Dictionary:**
```csharp
myDict.Clear();  // Removes all key-value pairs
```

#### 9. **Try Get Value:**
```csharp
if (myDict.TryGetValue("apple", out int value)) {
    Console.WriteLine($"Value: {value}");
} else {
    Console.WriteLine("Key not found.");
}
```

#### 10. **Initializing a Dictionary with Initial Values:**
```csharp
var predefinedDict = new Dictionary<string, int> {
    { "apple", 1 },
    { "banana", 2 },
    { "cherry", 3 }
};
```

#### 11. **Checking Dictionary Count:**
```csharp
int count = myDict.Count;  // Number of key-value pairs
```

#### 12. **Dictionary with Custom Types:**
```csharp
public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}

Dictionary<int, Person> people = new Dictionary<int, Person>();

people.Add(1, new Person { Name = "Alice", Age = 30 });
people.Add(2, new Person { Name = "Bob", Age = 25 });

foreach (var kvp in people) {
    Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value.Name}, Age: {kvp.Value.Age}");
}
```

#### 13. **Merging Dictionaries:**
```csharp
Dictionary<string, int> dict1 = new Dictionary<string, int> {
    { "apple", 1 },
    { "banana", 2 }
};

Dictionary<string, int> dict2 = new Dictionary<string, int> {
    { "cherry", 3 },
    { "date", 4 }
};

foreach (var kvp in dict2) {
    dict1[kvp.Key] = kvp.Value;  // Merge dict2 into dict1
}
```

This cheat sheet covers the essential operations for working with `Dictionary` in C#. If you need more details or have any questions, feel free to ask!