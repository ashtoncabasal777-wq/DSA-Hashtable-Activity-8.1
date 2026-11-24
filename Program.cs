
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        Dictionary<string, string> records = new Dictionary<string, string>();

        int choice;

        do
        {
            Console.WriteLine("\n===== RECORD KEEPING PROGRAM =====");
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] End");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                   
                    Console.Write("Enter Key: ");
                    string key = Console.ReadLine();

                    Console.Write("Enter Value: ");
                    string value = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(key))
                    {
                        Console.WriteLine("Error! Key cannot be empty.");
                    }
                    else if (records.ContainsKey(key))
                    {
                        Console.WriteLine("Error! Duplicate key already exists.");
                    }
                    else
                    {
                        records.Add(key, value);
                        Console.WriteLine("Data successfully added!");
                    }
                    break;

                case 2:
                   
                    Console.Write("Enter Key to delete: ");
                    string deleteKey = Console.ReadLine();

                    if (records.Remove(deleteKey))
                    {
                        Console.WriteLine("Data successfully deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Error! Key does not exist.");
                    }
                    break;

                case 3:
                    
                    Console.WriteLine("\n===== RECORDS =====");

                    if (records.Count == 0)
                    {
                        Console.WriteLine("No records found.");
                    }
                    else
                    {
                        foreach (var item in records)
                        {
                            Console.WriteLine("Key: " + item.Key +
                                              " | Value: " + item.Value);
                        }
                    }
                    break;

                case 4:

                default:
                    Console.WriteLine("Invalid choice! Please choose 1 to 4.");
                    break;
            }

        } while (choice != 4);
    }
}
