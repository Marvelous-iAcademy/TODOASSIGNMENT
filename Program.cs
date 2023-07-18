// See https://aka.ms/new-console-template for more information
using TODOAssignment;
    List<string> todoList = new List<string>();
TODOCLASS todo = new();
while (true)
{
    var day = todo.SetDay();
    var task = todo.SetTask();
    var time = todo.SetTime();
    todoList.Add($"Task for {day} is {task} by {time}");
    Console.WriteLine("Do you want to continue? N to stop or any key to continue");
    string n = Console.ReadLine().ToLower();
    if (n == "n")
    {
        foreach (var item in todoList)
        {
            Console.WriteLine(item);
        }
        return;
    }
}