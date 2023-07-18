using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOAssignment
{
    public class TODOCLASS
    {
        private string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public string SetDay()
        {
            while (true)
            {
                Console.WriteLine("Choose a day:");
                for (byte i = 0; i < daysOfWeek.Length; i++)
                {
                    Console.WriteLine($"{i}. {daysOfWeek[i]}");
                }

                if (byte.TryParse(Console.ReadLine(), out byte value) && value >= 0 && value < daysOfWeek.Length)
                {
                    if (value == 2)
                    {
                        Console.WriteLine("Wednesday is assessment day. No task can be assigned to this day.");
                        Console.WriteLine("Do you want to set a task for another day? If yes, press 1; otherwise, press any key to exit");
                        if (byte.TryParse(Console.ReadLine(), out byte value2) && value2 == 1)
                        {
                            continue;
                        }
                        else
                        {
                            return "No task assigned.";
                        }
                    }
                    else if (value == 5 || value == 6)
                    {
                        Console.WriteLine("It is the weekend; no task can be assigned for today. Set Task for another day.");
                        continue;
                    }
                    else
                    {
                        return daysOfWeek[value];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            }
        }
        public string SetTask()
        {
            string task;
            do
            {
                Console.WriteLine("Allocate a task:");
                task = Console.ReadLine();
                if (string.IsNullOrEmpty(task))
                {
                    Console.WriteLine("Your task is empty. Input a task.");
                }
            } while (string.IsNullOrEmpty(task));

            return task;
        }
        public string SetTime()
        {
            while (true)
            {
                Console.Write("Enter a time using this format (HH:mm): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime result))
                {
                    return result.ToString("HH:mm");
                }
                else
                {
                    Console.WriteLine("Invalid time, input a valid time.");
                }
            }
        }
    }
}
