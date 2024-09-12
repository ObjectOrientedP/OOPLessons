### C# Integer Cheat Sheet

**1. Integer Types in C#**

| Type          | Size (bits) | Range                              |
|---------------|-------------|------------------------------------|
| `int`         | 32          | -2,147,483,648 to 2,147,483,647    |
| `long`        | 64          | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| `short`       | 16          | -32,768 to 32,767                 |
| `byte`        | 8           | 0 to 255                          |
| `sbyte`       | 8           | -128 to 127                       |
| `uint`        | 32          | 0 to 4,294,967,295                |
| `ulong`       | 64          | 0 to 18,446,744,073,709,551,615    |
| `ushort`      | 16          | 0 to 65,535                       |

**2. Declaring and Initializing Integers**

```csharp
int num1 = 10;
long num2 = 1000000000L; // Add 'L' for long literals
short num3 = 30000;
```

**3. Arithmetic Operations**

- **Addition (`+`)**: 
  ```csharp
  int result = num1 + num2;
  ```

- **Subtraction (`-`)**: 
  ```csharp
  int result = num1 - num2;
  ```

- **Multiplication (`*`)**: 
  ```csharp
  int result = num1 * num2;
  ```

- **Division (`/`)**: 
  ```csharp
  int result = num1 / num2;
  ```

- **Modulus (`%`)** (remainder):
  ```csharp
  int remainder = num1 % num2;
  ```

**4. Increment and Decrement**

- **Increment (`++`)**: Increases the value by 1.
  ```csharp
  num1++; // num1 = num1 + 1;
  ```

- **Decrement (`--`)**: Decreases the value by 1.
  ```csharp
  num1--; // num1 = num1 - 1;
  ```

**5. Type Conversion**

- **Implicit Conversion** (safe to convert, no data loss):
  ```csharp
  long bigNum = num1; // Implicit conversion from int to long
  ```

- **Explicit Conversion (Casting)**:
  ```csharp
  int smallNum = (int)num2; // Casting long to int (may lose data)
  ```

- **Converting to String**:
  ```csharp
  string str = num1.ToString(); // "10"
  ```

- **Parsing from String**:
  ```csharp
  int parsedInt = Int32.Parse("123"); // Converts "123" to int
  ```

  - Use `TryParse()` to safely handle invalid input:
  ```csharp
  bool success = Int32.TryParse("123", out int result); // Returns true if parsing succeeds
  ```

**6. Integer Division**

- **Integer division truncates the result**:
  ```csharp
  int result = 7 / 2; // result = 3 (fraction is discarded)
  ```

- **To get a precise result, cast to float or double**:
  ```csharp
  double preciseResult = (double)7 / 2; // result = 3.5
  ```

**7. Checking for Overflow**

- **Unchecked Context**: Default behavior where overflow does not raise an exception.
  ```csharp
  int largeValue = int.MaxValue + 1; // No error, value wraps around
  ```

- **Checked Context**: Raises an `OverflowException` if overflow occurs.
  ```csharp
  checked {
      int largeValue = int.MaxValue + 1; // Causes runtime exception
  }
  ```

**8. Min and Max Values**

- Use the static properties to get the minimum and maximum values of integer types.
  ```csharp
  int maxValue = int.MaxValue; // 2147483647
  int minValue = int.MinValue; // -2147483648
  ```

**9. Math Methods**

- **`Math.Abs()`**: Returns the absolute value of an integer.
  ```csharp
  int absValue = Math.Abs(-10); // 10
  ```

- **`Math.Pow()`**: Raise to a power (returns a double).
  ```csharp
  double power = Math.Pow(2, 3); // 8.0
  ```

- **`Math.Sqrt()`**: Returns the square root (returns a double).
  ```csharp
  double sqrt = Math.Sqrt(16); // 4.0
  ```

- **`Math.Max(a, b)` and `Math.Min(a, b)`**: Find the larger or smaller of two numbers.
  ```csharp
  int max = Math.Max(num1, num2);
  int min = Math.Min(num1, num2);
  ```

**10. Bitwise Operators**

- **AND (`&`)**: Bitwise AND.
  ```csharp
  int result = num1 & num2;
  ```

- **OR (`|`)**: Bitwise OR.
  ```csharp
  int result = num1 | num2;
  ```

- **XOR (`^`)**: Bitwise XOR.
  ```csharp
  int result = num1 ^ num2;
  ```

- **NOT (`~`)**: Bitwise NOT (inverts the bits).
  ```csharp
  int result = ~num1;
  ```

- **Left Shift (`<<`)**: Shifts bits to the left.
  ```csharp
  int result = num1 << 2; // Equivalent to num1 * 4
  ```

- **Right Shift (`>>`)**: Shifts bits to the right.
  ```csharp
  int result = num1 >> 2; // Equivalent to num1 / 4
  ```

---

This cheat sheet covers the essential operations and methods for working with integers in C#.