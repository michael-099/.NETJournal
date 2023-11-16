using System;
namespace Student{
    class Student_Management_System{
   
   static void Main(string[] args) {
    string name;
    int subject ;
    Console.WriteLine("Hey , What is your name ");
    name=Console.ReadLine();
    Console.WriteLine("nice to meet you " +name);
    Console.WriteLine(" i am here to help you calculating your average How many subject did you take ");
    subject=int.Parse (Console.ReadLine());
    Console.WriteLine(subject);
    for(int i=0 ; i<subject; i++) {
        int sum =0;
        Console.WriteLine($"enter subject {i+1}");
        sum=sum+int parse( Console.ReadLine());
}  
    float average= sum/subject;
    ConsoleWriteLine($"your average is {average}");

}  
}
// Aug 1, 2023 Fundamentals of C# Tasks
// Task: Student Grade Calculator
// Create a C# console application that allows students to calculate their average grade based on different subjects.
//  The application should prompt the student to enter their name and the number of subjects they have taken. For each subject,
//  the student should enter the subject name and the grade obtained (numeric value). After entering all subjects and grades, the application should display the student's name, individual subject grades, and the calculated average grade.
// Requirements:
// Use variables and data types to store student data.
// Use conditional statements to validate input (e.g., ensure grade values are within a valid range).
// Implement loops to handle multiple subjects and grades.
// Utilize collections (e.g., List, Dictionary) to store subject names and corresponding grades.
// Define a method to calculate the average grade based on the entered grades.
// Use string interpolation to display the results in a user-friendly format.
// Write test for your code [Optional]
