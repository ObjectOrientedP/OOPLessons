Classroom science = new Classroom();

Student student1 = new Student("Harry Styles", 77);
student1.PrintDetails();

Student student2 = new Student("Jim Jones", 91);
student2.PrintDetails();

Student student3 = new Student("Sarah Kelly", 88);
student3.PrintDetails();

science.AddStudent(student1);
science.AddStudent(student2);
science.AddStudent(student3);

science.ListStudents();

science.RemoveStudent("Billy Kelly");
