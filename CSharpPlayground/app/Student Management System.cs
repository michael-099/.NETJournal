using System;
namespace Student;
    class Student_Management_System{
   
   static void Main(string[] args) {
    string name;
    int subject ;
    int sum =0;
    string subj="";
    int res =0;
    Dictionary<string,int> result = new Dictionary<string, int>();

    Console.WriteLine("Hey , What is your name ");
    name=Console.ReadLine();
    Console.WriteLine("nice to meet you " +name);
    Console.WriteLine(" i am here to help you calculating your average How many subject did you take ");
    subject=int.Parse (Console.ReadLine());
    for(int i=0 ; i<subject; i++) {
        
        Console.WriteLine("enter subject name ");
        subj=Console.ReadLine();
        Console.WriteLine($"enter subject {i+1} result");
        res=int.Parse( Console.ReadLine());
        sum=sum+res;
        result.Add(subj,res);
    }
         Console.WriteLine("------your results---------");
        foreach(var x in result) {
            Console.WriteLine($"   {x.Key}.................{x.Value}");
    }  
    float average= sum/subject;
    Console.WriteLine($"your average is {average}");
 
}}

//  Fundamentals of C# Tasks
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
