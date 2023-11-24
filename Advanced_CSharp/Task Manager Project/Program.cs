using System;
namespace deeper_CSharp;
public enum Tasks
{
    Personal,
    Work,
    Errands,

}
public enum Catagory
{
    Todo,
    Urgent,
    Important,


}
class Task
{
    List<Task> TaskManager = new List<Task>()
    string Name;
    Catagory Catagory;
    string Description;

    bool ISCompleted;
    void Manager(Task task)
    {
        TaskManager.Add(task)

    }
    void PrintTask(){
       for(each x in TaskManager){
        Consolog.WriteLine($"Name:{x.name} Discription:{x.description} isompleted:{x.isCompleted} Catagory:{x.Catagory}")
       }
    }
    Task(string Name,Catagory Catagory,string Description, bool ISCompleted){
        this.Name=Name;
        this.Catagory=Catagory;
        this.Description=Description;
        this.ISCompleted=ISCompleted;

    }

}
class Program{
    public static void Main(string[] args){
        
    }
}
