using System;
namespace Grading;
 class Task{
    string Title { get;set;}
    string Description { get;set;}
    string DueDate { get;set;}
    string Status { get;set;}


//     static void Main(string[] args){
//   }

 }
class TaskManager{
    void AddTask(List<Task> data,string title , string description,string dueDate, string status){
        Task task = new Task();
        task.Title = title;
        task.Description = description;
        task.DueDate = dueDate;
        task.Status = status;
        data.Add(task);
    }

}

void Main(){
    List<Task> myTasks = new List<Task>();
    myTasks.AddTask(myTasks,"aaa","aaa","aaa","aaa");
}
// Grading System
// Task Class Implementation (2 points):
// [1 point] Task class is implemented with the required properties (Title, Description, Due date, Status).
// [1 point] The properties have proper data types and access modifiers (e.g., private fields with getters and setters).

// Task Manager Class Implementation (4 points):
// [1 point] Task Manager class is implemented with the required methods (Add, View all, View completed, View pending, Edit, Delete).
// [2 points] Methods are correctly designed and functional (e.g., tasks can be added, viewed, edited, and deleted).
// [1 point] Methods handle edge cases and errors appropriately (e.g., when tasks are not found, incorrect input, etc.).
// OOP Principles (2 points):
// [1 point] Code demonstrates proper use of OOP principles (e.g., encapsulation, abstraction, inheritance, polymorphism).
// [1 point] Classes are well-structured and follow OOP best practices.
// Task Verification (1 point):
// [1 point] The student created a repository named '2023-project-phase-mobile-tasks' and a folder 'on-boarding' inside it.
// [0 points] If the repository or folder structure is incorrect or missing.
// Project Naming and Organization (1 point):
// [1 point] The project folder is named 'task-2' inside the 'on-boarding' folder.
// [0 points] If the project folder name is incorrect or placed outside the 'on-boarding' folder.
// Code Quality and Readability (1 point):
// [1 point] Code is well-formatted, easy to read, and follows Dart coding conventions.
// GitHub Submission (1 point):
// [1 point] The student provides a GitHub link to the project repository in the '2023-project-phase-mobile-tasks' repository