// See https://aka.ms/new-console-template for more information
// Task 1!!
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}


//Task 2!!
//{
//    Console.WriteLine("Temperature Converter");
//    Console.WriteLine("1. Fahrenheit to Celsius");
//    Console.WriteLine("2. Celsius to Fahrenheit");
//    Console.Write("Enter your choice (1 or 2): ");
//    int choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            FahrenheitToCelsius();
//            break;
//        case 2:
//            CelsiusToFahrenheit();
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
//            break;
//    }
//}

//static void FahrenheitToCelsius()
//{
//    Console.Write("Enter temperature in Fahrenheit: ");
//    double fahrenheit = double.Parse(Console.ReadLine());
//    double celsius = (fahrenheit - 32) * 5 / 9;
//    Console.WriteLine($"Temperature in Celsius: {celsius:F2}°C");
//}

//static void CelsiusToFahrenheit()
//{
//    Console.Write("Enter temperature in Celsius: ");
//    double celsius = double.Parse(Console.ReadLine());
//    double fahrenheit = (celsius * 9 / 5) + 32;
//    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}°F");
//}

// tasks 3!!
//class Note
//{
//    public string Title { get; set; }
//    public string Content { get; set; }
//}
//class Program
//{
//    static string notesFilePath = "notes.txt";

//    static void Main(string[] args)
//    {
//        List<Note> notes = new List<Note>();

//        // Load existing notes from file
//        LoadNotes(notesFilePath, notes);

//        while (true)
//        {
//            Console.WriteLine("1. View Notes");
//            Console.WriteLine("2. Add Note");
//            Console.WriteLine("3. Edit Note");
//            Console.WriteLine("4. Delete Note");
//            Console.WriteLine("5. Exit");
//            Console.Write("Select an option: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    ViewNotes(notes);
//                    break;
//                case "2":
//                    AddNote(notes);
//                    break;
//                case "3":
//                    EditNote(notes);
//                    break;
//                case "4":
//                    DeleteNote(notes);
//                    break;
//                case "5":
//                    SaveNotes(notesFilePath, notes);
//                    Environment.Exit(0);
//                    break;
//                default:
//                    Console.WriteLine("Invalid option. Please try again.");
//                    break;
//            }
//        }
//    }

//    static void LoadNotes(string filePath, List<Note> notes)
//    {
//        if (File.Exists(filePath))
//        {
//            string[] lines = File.ReadAllLines(filePath);
//            foreach (string line in lines)
//            {
//                string[] parts = line.Split('|');
//                notes.Add(new Note { Title = parts[0], Content = parts[1] });
//            }
//        }
//    }

//    static void SaveNotes(string filePath, List<Note> notes)
//    {
//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            foreach (Note note in notes)
//            {
//                writer.WriteLine($"{note.Title}|{note.Content}");
//            }
//        }
//    }

//    static void ViewNotes(List<Note> notes)
//    {
//        Console.WriteLine("---- Notes ----");
//        foreach (Note note in notes)
//        {
//            Console.WriteLine($"Title: {note.Title}");
//            Console.WriteLine($"Content: {note.Content}");
//            Console.WriteLine();
//        }
//    }

//    static void AddNote(List<Note> notes)
//    {
//        Console.Write("Enter note title: ");
//        string title = Console.ReadLine();
//        Console.Write("Enter note content: ");
//        string content = Console.ReadLine();
//        notes.Add(new Note { Title = title, Content = content });
//        Console.WriteLine("Note added successfully.");
//    }

//    static void EditNote(List<Note> notes)
//    {
//        Console.Write("Enter the title of the note to edit: ");
//        string title = Console.ReadLine();
//        Note note = notes.Find(n => n.Title == title);
//        if (note != null)
//        {
//            Console.WriteLine($"Editing Note: {note.Title}");
//            Console.Write("Enter new content: ");
//            string newContent = Console.ReadLine();
//            note.Content = newContent;
//            Console.WriteLine("Note edited successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Note not found.");
//        }
//    }

//    static void DeleteNote(List<Note> notes)
//    {
//        Console.Write("Enter the title of the note to delete: ");
//        string title = Console.ReadLine();
//        Note note = notes.Find(n => n.Title == title);
//        if (note != null)
//        {
//            notes.Remove(note);
//            Console.WriteLine("Note deleted successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Note not found.");
//        }
//    }
//}

//Tasks 4!!

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("Simple Calculator");
//            Console.WriteLine("1. Addition");
//            Console.WriteLine("2. Subtraction");
//            Console.WriteLine("3. Multiplication");
//            Console.WriteLine("4. Division");
//            Console.WriteLine("5. Exit");
//            Console.Write("Select an option: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Addition();
//                    break;
//                case "2":
//                    Subtraction();
//                    break;
//                case "3":
//                    Multiplication();
//                    break;
//                case "4":
//                    Division();
//                    break;
//                case "5":
//                    Environment.Exit(0);
//                    break;
//                default:
//                    Console.WriteLine("Invalid option. Please try again.");
//                    break;
//            }
//        }
//    }

//    static void Addition()
//    {
//        Console.Write("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        double result = num1 + num2;
//        Console.WriteLine($"Result: {result}");
//    }

//    static void Subtraction()
//    {
//        Console.Write("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        double result = num1 - num2;
//        Console.WriteLine($"Result: {result}");
//    }

//    static void Multiplication()
//    {
//        Console.Write("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        double result = num1 * num2;
//        Console.WriteLine($"Result: {result}");
//    }

//    static void Division()
//    {
//        Console.Write("Enter dividend: ");
//        double dividend = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter divisor: ");
//        double divisor = Convert.ToDouble(Console.ReadLine());
//        if (divisor != 0)
//        {
//            double result = dividend / divisor;
//            Console.WriteLine($"Result: {result}");
//        }
//        else
//        {
//            Console.WriteLine("Cannot divide by zero.");
//        }
//    }
//}