Console.WriteLine("Hello");
Console.WriteLine();
bool exit = false;
string[] todos = new string[256];
Array.Fill(todos, "");
int todoDyIndex = 0;
while (exit == false)
{
    Console.WriteLine();
    Console.WriteLine("What is is that you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    ConsoleKeyInfo userChoice = Console.ReadKey();
    Console.WriteLine();
    switch (userChoice.Key)
    {
        case ConsoleKey.S:
            Console.WriteLine("You chose to see all TODOs");
            Console.WriteLine();
            if (todoDyIndex == 0)
            {
                Console.WriteLine("You have no TODOs");
                continue;
            }
            for (int i = 0; i < todoDyIndex; i++)
            {
                Console.WriteLine(todos[i]);
            }
            break;
        case ConsoleKey.A:
            Console.WriteLine("You chose to add a TODO");
            Console.WriteLine("What is the TODO?");
            string? todo = Console.ReadLine();
            if (todo == null || todos.Length == 0)
            {
                Console.WriteLine("Invalid TODO");
                continue;
            }
            else
            {
                todos[todoDyIndex] = todo;
            }

            break;
        case ConsoleKey.R:
            Console.WriteLine("You chose to remove a TODO");
            Console.WriteLine();
            if (todoDyIndex == 0)
            {
                Console.WriteLine("You have no TODOs");
                continue;
            }

            for (int i = 1; i < todoDyIndex + 1; i++)
            {
                Console.WriteLine(i + ". " + todos[i - 1]);
            }

            Console.WriteLine("Select TODO to delete");
            string? todoToDelete = Console.ReadLine();
            if (todoToDelete != null &&
                int.TryParse(todoToDelete, out int todoIndex) &&
                todoIndex > 0 && todoIndex < todoDyIndex + 2)
            {
                todos[todoIndex - 1] = "";
            }
            else
            {
                Console.WriteLine("Invalid TODO");
            }

            break;
        case ConsoleKey.E:
            Console.WriteLine("You chose to exit");
            exit = true;
            continue;
        default:
            Console.WriteLine("Invalid choice");
            continue;
    }

    string[] tempTodos = new string[256];
    int tempIndex = 0;
    foreach (string? todo in todos)
    {
        if (todo != null && todo != "")
        {
            tempTodos[tempIndex] = todo;
            tempIndex++;
        }
    }

    todos = tempTodos;
    todoDyIndex = tempIndex;
}
