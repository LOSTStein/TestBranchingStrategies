using System.ComponentModel.Design;

namespace MyApp
{

    internal class Program
    {
        /*
        static string username = "Alexander";
        */
        static void Main(string[] args)
        {
            /*string username = "Alexander";            

            username = "Peter";

            Console.WriteLine(username);
            


            int a = 100;
            int b = 200;

            int result = a + b;
            Console.WriteLine(result);



            float a = 100.5f;
            int b = 200;

            float result = a + b;
            Console.WriteLine(result);



            string name = "Alexander";
            string lastname = "Fels";

            string entireName = name + " " + lastname;
            Console.WriteLine(entireName);



            bool isAdult = true;



            char firstLetter = 'A';



            Console.WriteLine("Bitte trage deinen Namen ein:");

            string name = Console.ReadLine();

            Console.WriteLine("Dein Name ist: " + name);

            Console.WriteLine("Bitte trage dein Alter ein:");

            string age = Console.ReadLine();

            Console.WriteLine("Dein Alter ist: " + age);


            int birthYear = 2023 - int.Parse(age);

            Console.WriteLine("Du bist geboren im Jahr: " + birthYear);
            


            int[] numbers = new int[5];

            numbers[0] = 425;
            numbers[1] = 865854;
            numbers[2] = 45201;
            numbers[3] = 876254;
            numbers[4] = 34285;

            Array.Sort(numbers);
            


            string[] names = new string[3];

            names[0] = "Alexander";
            names[1] = "Peter";
            names[2] = "Jannick";



            // Schleifen -> Loops

            int[] numbers = new[] { 50, 200, 75 };

            // Foreach

            int result = 0;
            foreach (int n in numbers)
            {
                result += n;
                //Console.WriteLine(n);
            }

            Console.WriteLine(result);

            string[] names = new string[3] { "Jannick", "Maria", "Karl" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Schleifen -> Loops

            int[] numbers = new int[] { 50, 200, 75 };

            // For
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            Console.WriteLine(result);

            // 1 bis 10 zählt

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Alle grade Zahlen bis 20
            int maxNumber = 100;
            for (int i = 2;i <= maxNumber; i += 2)
            {
                Console.WriteLine(i);
            }

            // Rückwärts

            for (int i = 10; i >=1; i--)
            {
                Console.WriteLine(i);
            }

            // Schleifen -> Loops

            //while

            int[] numbers = new int[3] { 5, 10, -3 };

            int i = 0;

            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            Random random = new Random();
            int secretNumer = random.Next(1,11);
            int userGuess = 0;

            while (userGuess != secretNumer)
            {
                Console.Write("Geben Sie ihre Vermutung ein: ");
                userGuess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ihre Antwort ist richtig");

            //Aufgabe: Erstelle ein Programm, dass den Nutzer 5x nach einer Zahleneingabe fragt
            //Speichere die Werte in einem Array mit 5 Plätzen
            //Berechne zum Schluss die Summe aller Zahlen, die vom Nutzer eingegeben wurden

            double[] zahlen = new double[5];
            string zwischenablage;
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Bitte geben Sie eine beliebige zahl ein.");
                zwischenablage = Console.ReadLine();
                zahlen[i] = double.Parse(zwischenablage);
            }

            double value = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                value = zahlen[i] + value;
                
                if(i == 4)
                {
                    Console.WriteLine("\n\n\nIhre Zahlen zusammen addiert ergeben: " + value);
                }
            }


            string name = "Jannick";
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Ist größer als 0");
            }

            if (name == "Jannick")
            {
                Console.WriteLine("Es ist Jannick");
            }

            // > größer als
            // >= größer gleich
            // < kleiner als
            // <= kleiner gleich
            // == ist gleich
            // != ungleich
            // || oder
            // && und

            int age = 16;
            int height = 120;

            if(age >= 12 && height > 140) 
            {
                Console.WriteLine("Zutritt ist gewährt");
            } else
            {
                Console.WriteLine("Zutritt ist verweigert");
            }

            int number = 10;

            if (number > 10) 
            {
                Console.WriteLine("Die nummer ist größer als 20.");
            }
            else if (number > 10)
            {
                Console.WriteLine("Die Nummer ist größer als 10, aber kleiner oder gleich 20");
            }
            else
            {
                Console.WriteLine("Die Nummer ist kleiner als 10.");
            }


            // Aufgabe: Schreibe ein Program, das dich auffordert,
            // eine ganze Zahl eizugeben, und dann mit if, else if und else
            // prüft und ausgibt, ob diese Zahl positiv, negativ oder null ist.

            int number = 0;

            Console.WriteLine("Bitte geben sie eine beliebige ganze Zahl ein");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Die Zahl ist positiv (größer als null).");
            }
            else if (number == 0)
            {
                Console.WriteLine("Die Zahl ist null.");
            }
            else
            {
                Console.WriteLine("Die Zahl ist negativ (kleiner als null).");
            }

            // Aufgabe: Schreibe ein Programm, das dich auffordert,
            // einen Benutzernamen und ein Passwort einzugeben
            // und dann überprüft, ob sowohl der Benutzername
            // als auch das Passwort korrekt sind

            string passwort = "123ABC";
            string username = "Alexander";
            string passworteingabe;
            string usernameeingabe;

            Console.WriteLine("Bitte geben Sie den richtigen Benutzernamen und das richtige Passwort ein.");
            usernameeingabe = Console.ReadLine();
            passworteingabe = Console.ReadLine();
            
            if (passwort == passworteingabe && username == usernameeingabe)
            {
                Console.WriteLine("Sie haben sich erfolgreich eingeloggt!");
            }
            else if (passwort != passworteingabe && username == usernameeingabe)
            {
                Console.WriteLine("Das Passwort ist falsch!");
            }
            else
            {
                Console.WriteLine("Der Buntzername ist falsch!");
            }

            Console.WriteLine("Bitte gib dein Alter ein.");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Bist du Student? (Ja/Nein)");
            string studentInput = Console.ReadLine().ToLower();

            Console.WriteLine("Hast du einen Gutschein?(Ja/Nein)");
            string couponInput = Console.ReadLine();

            bool isStudent = false;
            bool hasCoupon = false;

            if (studentInput == "Ja" || studentInput == "ja")
            {
                isStudent = true;
            }

            if (couponInput == "Ja" || couponInput == "ja")
            {
                hasCoupon = true;
            }

            if ((age >= 18 && age <= 25 && isStudent == true) || hasCoupon == true)
            {
                Console.WriteLine("Du erhälst den Rabatt.");
            }
            else
            {
                Console.WriteLine("Du erhälst leider kein Rabatt.");
            }


            // Nested If-Statement (Verschachtelt)

            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("Die Zahl ist größer als null.");

                if (number > 5)
                {
                    Console.WriteLine("Die Zahl ist größer als 5.");
                }
                else
                {
                    Console.WriteLine("Die Zahl ist kleiner oder gleich 5.");
                }
            }
            else
            {
                Console.WriteLine("Die Zahl ist kleiner als null.");
            }


            //Anwendung: Todo-List
            //Add, View, Delete, Quit

            string[] todoList = new string[10];

            string command = "";
            int currentTaskCount = 0;

            while(command != "quit" || command == "Quit")
            {
                Console.WriteLine("Please enter a command (add, view, delete, quit):");
                command = Console.ReadLine().ToLower();

                if ( command == "add" || command == "Add")
                {
                    if (currentTaskCount < todoList.Length)
                    {
                        Console.WriteLine("Please enter a task to add.");
                        string task = Console.ReadLine();
                        todoList[currentTaskCount] = task;
                        currentTaskCount++;
                    }
                    else
                    {
                        Console.WriteLine("Todo-List is full.");
                    }
                }else if (command == "view" || command == "View")
                {
                    Console.WriteLine("Your current tasks are.");

                    for (int i = 0; i < currentTaskCount; i++)
                    {
                        Console.WriteLine((i+1) + ". " + todoList[i]);
                    }
                }else if (command == "delete" || command == "Delete")
                {
                    Console.WriteLine("Please enter the number of the task to delete");
                    int tasknumber = int.Parse(Console.ReadLine()) - 1;

                    if (tasknumber < 0 || tasknumber >= currentTaskCount)
                    {
                        Console.WriteLine("Invalid task number!");
                    }
                    else
                    {
                        for (int i = tasknumber;i < currentTaskCount - 1;i++)
                        {
                            todoList[i] = todoList[i + 1];
                        }

                        currentTaskCount--;
                        Console.WriteLine("Tasknumber " + (tasknumber + 1) + " removed!");
                    }
                }else if( command == "quit" || command == "Quit")
                {
                    Console.WriteLine("Goodbye!");
                }
            }*/


            Car myCar = new Car("Porsche", "992", 2021);
            myCar.Honk();

            string info = myCar.GetFullInfo();
            Console.WriteLine(info);

            float consumption = myCar.CalculateFuelConsumption(400, 12);
            Console.WriteLine("Das Auto verbraucht " + consumption + " auf 100km");

            /*Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);

            Car myCartwo = new Car("´McLaren", "ABC", 2004);
            myCar.Honk();
            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);*/
        }

        /*
        static void Two()
        {
            username = "Peter";
        }
        */
    }
}