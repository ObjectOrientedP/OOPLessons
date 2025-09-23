using System;

public class PublicExample {

    private string name;

    public PublicExample(string name) {
        this.name = name;
    }

    public void ShowName() {
        this.DontShowName();
    }

    private void DontShowName() {
        Console.WriteLine("The name is: " + this.name);
    }
}