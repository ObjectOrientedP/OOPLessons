public class ExampleClass {
    private int number;

    public ExampleClass(int num) {
        this.number = num;
    }

    public void Display() {
        Console.WriteLine(number);            
    }

    private void DontDisplay() {
        Console.WriteLine(number);
    }
}