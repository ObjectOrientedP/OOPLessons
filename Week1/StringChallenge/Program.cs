using System;

class Program {
    static void Main(string[] args) {

    }
}

//Question 1
string myString = "This is the string!!";
Console.WriteLine("Question 1");
Console.WriteLine(myString);

//Question 2
string firstName = "John";
string lastName = "Doe";
Console.WriteLine("Question 2");
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(String.Concat(firstName, " ", lastName));

//Question 3
string word = "Programming";
int wordlength = word.Length;
Console.WriteLine("Question 3");
Console.WriteLine("The length = " + wordlength);

//Question 4
string lowerCase = "hello";
Console.WriteLine("Question 4");
Console.WriteLine(lowerCase.ToUpper());

//Question 5
string sentence = "I love programming.";
bool exists = sentence.Contains("love");
Console.WriteLine(exists);

//Question 6
//["H", "e", "l", "l", "o"];
//[0, 1, 2, 3, 4]
string secondword = "Hello";
Console.WriteLine("Question 6");
Console.WriteLine(secondword[1]);
Console.WriteLine(secondword[4]);


string subStrSentence = "I love apples.";
Console.WriteLine("Question 7");
Console.WriteLine(subStrSentence.Substring(0, 3));

string numberString = "100";
int strToNum = int.Parse(numberString);
Console.WriteLine(strToNum);

string textWithSpaces = " Hello World!    ";
Console.WriteLine(textWithSpaces.Trim()); 