public class Program
{
    public static void Main()
    {

        string[] names = { "JD", "Turk", "Elliot", "Carla", "Dr. Cox", "Dr. Kelso", "Janitor" };
        string[] towns = { "Trotwood ", "Sacred Heart", "Greenwich", "Somewhere in the Dominican Republic", "Detroit", "Monroeville", "Unknown" };
        string[] foods = { " Appletini's", "Cheese", "Apples", "Pizza Rolls", " Beer", "Cupcakes", "Unknown" };
        int userChoice;

        Console.WriteLine(" Welcome to Sarcred Heart School Database! \n To learn about our students please type'database' \n To view the student directory please type 'directory'. ");
        string firstchoice = Console.ReadLine().ToLower();

        while (true)
        {
            while (true)
            {
                if (firstchoice.Contains("data"))
                {
                    Console.WriteLine("Which student are you inquiring about? Please enter their student ID (1-7).");
                    int scrubchoice = int.Parse(Console.ReadLine().ToLower());

                    if (scrubchoice <= 0 || scrubchoice > names.Length + 1)
                    {
                        Console.WriteLine(" Sorry I don't recognize that student, please re-enter the student you are inquiring about. ");
                        continue;
                    }
                    else
                    {
                        userChoice = scrubchoice - 1;
                        break;
                    }

                }
                else if (firstchoice.Contains("dir"))
                {
                    Console.WriteLine("Here is a directory of our current students.");
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"Student {i + 1}: {names[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Which student would you like to learn more about? Enter their student ID (1-7). ");
                    int scrubchoice = int.Parse(Console.ReadLine());

                    if (scrubchoice <= 0 || scrubchoice > names.Length + 1)
                    {
                        Console.WriteLine(" Sorry I don't recognize that student, please re-enter the student you are inquiring about. ");
                        continue;
                    }
                    else
                    {
                        userChoice = scrubchoice - 1;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry I didn't recognize that student. \nPlease re-enter whom you are inquiring about");
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine($"You have chosen to learn more about {names[userChoice]}. \nWould you like to know their hometown or their favorite food? \nPlease enter one of the options above.");
                string choice2 = Console.ReadLine().ToLower();

                if (choice2.Contains("home"))
                {
                    Console.WriteLine($"{names[userChoice]} was born in {towns[userChoice]}.");
                    break;
                }
                else if (choice2.Contains("food") || choice2.Contains("fav"))
                {
                    Console.WriteLine($"{names[userChoice]} favorite food is {foods[userChoice]}.");
                    break;
                }
                else if (choice2.Contains("both"))
                {
                    Console.WriteLine($"{names[userChoice]}, was born in {towns[userChoice]}, and their favorite food is {foods[userChoice]}.");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that. \nPlease re-enter your answer"); continue;
                }
            }
            Console.WriteLine("Would you like to learn about another student? Please enter yes or no");
            var keepgoin = Console.ReadLine().ToLower();

            if (keepgoin.Contains("y"))
            {
                continue;
            }
            else if (keepgoin.Contains("n"))
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't quite catch that. Please choose y or n");
            }
        }
    }
    }
