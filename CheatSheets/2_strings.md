### C# Strings Cheat Sheet

**1. String Declaration**

- Strings in C# are immutable, meaning their values cannot be changed after creation.
```csharp
string str = "Hello, World!";
```

**2. String Concatenation**

- Using `+` operator:
```csharp
string first = "Hello";
string second = "World";
string result = first + " " + second; // "Hello World"
```

- Using `String.Concat`:
```csharp
string result = String.Concat(first, " ", second); // "Hello World"
```

- Using `String.Join`:
```csharp
string result = String.Join(" ", first, second); // "Hello World"
```

**3. String Interpolation**

- Embedding expressions directly in strings:
```csharp
int age = 25;
string result = $"I am {age} years old."; // "I am 25 years old."
```

**4. Common String Methods**

- **`Length`**: Get the number of characters in a string.
```csharp
int length = str.Length;
```

- **`ToUpper` / `ToLower`**: Convert string to uppercase/lowercase.
```csharp
string upper = str.ToUpper();
string lower = str.ToLower();
```

- **`Trim`**: Remove leading/trailing white spaces.
```csharp
string trimmed = str.Trim();
```

- **`Substring(startIndex, length)`**: Extract a substring.
```csharp
string sub = str.Substring(0, 5); // "Hello"
```

- **`Contains(value)`**: Check if the string contains a specific substring.
```csharp
bool hasHello = str.Contains("Hello"); // true
```

- **`IndexOf(value)`**: Get the index of a substring. Returns `-1` if not found.
```csharp
int index = str.IndexOf("World"); // 7
```

- **`Replace(oldValue, newValue)`**: Replace a substring with another.
```csharp
string replaced = str.Replace("World", "C#"); // "Hello, C#!"
```

**5. String Comparison**

- **`Equals()`**: Compare two strings.
```csharp
bool isEqual = str1.Equals(str2); // Case-sensitive comparison
```

- **`String.Compare(str1, str2)`**: Compare two strings lexicographically.
```csharp
int comparison = String.Compare(str1, str2);
```

**6. String Splitting**

- Split a string into an array of substrings.
```csharp
string sentence = "Hello World";
string[] words = sentence.Split(' '); // ["Hello", "World"]
```

**7. String Joining**

- Join an array of strings into one string.
```csharp
string[] words = { "Hello", "World" };
string sentence = String.Join(" ", words); // "Hello World"
```

**8. String Formatting**

- Format strings using placeholders.
```csharp
string formatted = String.Format("My name is {0} and I am {1} years old.", "John", 30);
```

**9. Escape Sequences**

- Special characters in strings:
  - `\n` : New line
  - `\t` : Tab
  - `\\` : Backslash
  - `\"` : Double quote

```csharp
string escaped = "Hello\nWorld"; // "Hello" on first line, "World" on next
```

**10. Verbatim Strings**

- Ignore escape sequences by using `@`.
```csharp
string path = @"C:\Program Files\MyApp"; // No need to escape backslashes
```

**11. Checking for Null or Empty**

- **`String.IsNullOrEmpty()`**: Check if a string is null or empty.
```csharp
bool isEmpty = String.IsNullOrEmpty(str);
```

- **`String.IsNullOrWhiteSpace()`**: Check if a string is null, empty, or only white spaces.
```csharp
bool isWhitespace = String.IsNullOrWhiteSpace(str);
```

**12. Immutable Nature of Strings**

- Since strings are immutable, every modification creates a new string.
- Use **`StringBuilder`** for performance when performing many changes to a string.

```csharp
StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
string result = sb.ToString(); // "Hello World"
```

---

This cheat sheet covers the most common operations you'll encounter when working with strings in C#.