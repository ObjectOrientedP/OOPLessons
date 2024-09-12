### C# Data Types Cheat Sheet

C# has a wide variety of data types that fall into **two** main categories: **Value Types** and **Reference Types**.

---

### 1. **Value Types**

Value types hold the actual data directly and are stored on the **stack**. They include basic types such as numbers and structures.

| Type           | Description                  | Size (bits)     | Default Value        | Range                                      |
|----------------|------------------------------|-----------------|----------------------|--------------------------------------------|
| `int`          | Integer (signed 32-bit)       | 32              | 0                    | -2,147,483,648 to 2,147,483,647            |
| `long`         | Long integer (signed 64-bit)  | 64              | 0L                   | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| `short`        | Short integer (signed 16-bit) | 16              | 0                    | -32,768 to 32,767                         |
| `byte`         | Byte (unsigned 8-bit)         | 8               | 0                    | 0 to 255                                  |
| `sbyte`        | Signed byte (8-bit)           | 8               | 0                    | -128 to 127                               |
| `uint`         | Unsigned int (32-bit)         | 32              | 0                    | 0 to 4,294,967,295                        |
| `ulong`        | Unsigned long (64-bit)        | 64              | 0UL                  | 0 to 18,446,744,073,709,551,615           |
| `ushort`       | Unsigned short (16-bit)       | 16              | 0                    | 0 to 65,535                               |
| `char`         | Single Unicode character      | 16              | '\0'                 | Any valid Unicode character               |
| `float`        | Single-precision floating-point | 32            | 0.0F                 | ±1.5 x 10^−45 to ±3.4 x 10^38 (7 digits)  |
| `double`       | Double-precision floating-point | 64            | 0.0D                 | ±5.0 × 10^−324 to ±1.7 × 10^308 (15-16 digits) |
| `decimal`      | High-precision floating-point | 128             | 0.0M                 | ±1.0 x 10^−28 to ±7.9 x 10^28 (28-29 digits) |
| `bool`         | Boolean value                 | 1 (theoretically) | `false`             | `true` or `false`                         |

- **Example:**
  ```csharp
  int number = 100;
  float pi = 3.14f;
  bool isAlive = true;
  ```

### 2. **Reference Types**

Reference types store references to the actual data, and these references are stored on the **heap**. They include classes, arrays, and delegates.

| Type               | Description                                  | Default Value |
|--------------------|----------------------------------------------|---------------|
| `string`           | A sequence of Unicode characters              | `null`        |
| `object`           | Base type of all other types                  | `null`        |
| `class`            | Blueprint for creating objects (reference)    | `null`        |
| `array`            | Fixed-size collection of elements             | `null`        |
| `interface`        | Contract that classes can implement           | `null`        |
| `delegate`         | Represents method references                  | `null`        |
| `dynamic`          | Dynamically typed object (runtime evaluation) | `null`        |

- **Example:**
  ```csharp
  string name = "John";
  object obj = 123; // Can hold any type
  int[] numbers = { 1, 2, 3, 4, 5 };
  ```

### 3. **Nullable Types**

- Value types cannot be `null`, but **nullable types** can be used when null values are needed for value types.
- Declared using `?` after the type.

  ```csharp
  int? nullableInt = null;
  ```

### 4. **Type Aliases**

C# provides aliases for some types, which are easier to use than their full system counterparts.

| Alias    | .NET Equivalent       | Description                 |
|----------|-----------------------|-----------------------------|
| `int`    | `System.Int32`         | 32-bit signed integer       |
| `long`   | `System.Int64`         | 64-bit signed integer       |
| `short`  | `System.Int16`         | 16-bit signed integer       |
| `byte`   | `System.Byte`          | 8-bit unsigned integer      |
| `sbyte`  | `System.SByte`         | 8-bit signed integer        |
| `uint`   | `System.UInt32`        | 32-bit unsigned integer     |
| `ulong`  | `System.UInt64`        | 64-bit unsigned integer     |
| `ushort` | `System.UInt16`        | 16-bit unsigned integer     |
| `char`   | `System.Char`          | Unicode character           |
| `float`  | `System.Single`        | 32-bit floating point       |
| `double` | `System.Double`        | 64-bit floating point       |
| `decimal`| `System.Decimal`       | High precision floating point|
| `bool`   | `System.Boolean`       | Boolean value               |
| `string` | `System.String`        | Sequence of characters      |
| `object` | `System.Object`        | Base type for all types     |

### 5. **Boxing and Unboxing**

- **Boxing**: Converting a value type to an object/reference type (e.g., `object`).
  ```csharp
  int num = 10;
  object obj = num; // Boxing
  ```

- **Unboxing**: Converting an object back to a value type.
  ```csharp
  int unboxed = (int)obj; // Unboxing
  ```

### 6. **Dynamic Types**

- **`dynamic`** type allows you to skip compile-time type checking. The type is resolved at runtime.

  ```csharp
  dynamic variable = 1;   // variable holds an integer
  variable = "Hello";     // Now holds a string
  ```

---

### 7. **Type Conversion**

- **Implicit Conversion**: Safe conversions between types.
  ```csharp
  int num = 10;
  long bigNum = num; // Implicit conversion from int to long
  ```

- **Explicit Conversion (Casting)**: Requires a cast operator.
  ```csharp
  double pi = 3.14;
  int intPi = (int)pi; // Explicit conversion, fractional part is lost
  ```

- **Converting Strings**:
  ```csharp
  int parsedInt = int.Parse("123"); // Convert string to int
  bool success = int.TryParse("123", out int result); // Safely convert string to int
  ```

### 8. **Default Values**

Each type has a default value if not initialized:
- **Numeric types**: 0 (e.g., `int`, `float`, `double`)
- **Boolean**: `false`
- **Reference types**: `null`
- **Char**: `'\0'` (null character)
- **Nullable types**: `null`

```csharp
int defaultInt;         // 0
bool defaultBool;       // false
string defaultString;   // null
```

---

This cheat sheet covers the essential data types and operations you'll use in C#.