# Week 1: Object Oriented Programming Introduction


## Hackerrank Challenge

```c#
public static int camelcase(string s) {
    if(String.IsNullOrEmpty(s)){
        return 0;
    }
    
    int count = 1;
    char[] charArr = s.ToCharArray();
    for(int i = 0; i < charArr.Length; i++) {
        if(Char.IsUpper(charArr[i])) {
            count++;
        }
    }
    return count;
}
```

