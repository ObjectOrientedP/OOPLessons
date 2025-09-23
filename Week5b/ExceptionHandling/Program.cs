
Person person = new Person("Jim", 17);

try {
    
    person.CheckAge(person.age);

} catch(CustomException ex) {
   
    Console.WriteLine($"Index out of range: {ex.Message}");

}
