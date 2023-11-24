using System;
namespace deeper_CSharp;

public enum Catagory
{
    Personal,
    Work,
    Errands,



}
class Task
{
    public static List<Task> TaskManager = new List<Task>();
    string Name { get; set; }
    Catagory Catagory { get; set; }
    string Description { get; set; }

    bool ISCompleted { get; set; }
    public static void AddTask(Task task)
    {
        TaskManager.Add(task);

    }
    public static void PrintTask()
    {
        foreach (var x in TaskManager)
        {
            Console.WriteLine($"Name:{x.Name} Discription:{x.Description} isompleted:{x.ISCompleted} Catagory:{x.Catagory}");
        }
    }
    public Task(string Name, Catagory Catagory, string Description, bool ISCompleted)
    {
        this.Name = Name;
        this.Catagory = Catagory;
        this.Description = Description;
        this.ISCompleted = ISCompleted;

    }

}
class Program
{
    public static void Main(string[] args)
    {
        Task task1 = new Task("Complete Homework Assignment", Catagory.Work, "Finish the homework assignment for mathematics and submit it by 5 PM.", false);
        Task.AddTask(task1);
        Task task2 = new Task("Grocery Shopping", Catagory.Personal, "Buy groceries for the week, including fruits, vegetables, and essential household items.", false);
        Task.AddTask(task2);
        Task task3 = new Task("Write Blog Post", Catagory.Work, " Create a new blog post on the latest technology trends and innovations. Include relevant examples and insights.", false);
        Task.AddTask(task3);
        Task task4 = new Task("Gym Workout", Catagory.Personal, "Hit the gym for a workout session. Focus on cardio exercises and strength training.", false);
        Task.AddTask(task4);
        Task.PrintTask();



    }
}
