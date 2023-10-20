using FirstCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        string myName = "Alex";
        int age = 18;
        int multiplier = 3;
        int result = age * multiplier;
        float kommaZahl = 16.5f;
        char zeichen = 'A';
        bool schalter = true;

        Console.WriteLine(myName);
        Console.WriteLine(age);
        Console.WriteLine(result);

        Console.WriteLine("Geben Sie ein Alter an.");
        string age = Console.ReadLine();
        int userInput = int.Parse(age);

        Console.WriteLine("Nutzer hat eingegeben: " + userInput);

        AddNumbers(10,20);
        AddNumbers(50,-100);
        AddNumbers(300,2500);

        int result = AddNumbers2(10, 20);

        Console.WriteLine("Bitte geben sie zwei Integer an die Addiert werden sollen.");
        int userInputNumberA = int.Parse(Console.ReadLine());
        int userInputNumberB = int.Parse(Console.ReadLine());

        int result = AddNumbers2(userInputNumberA, userInputNumberB);

        Console.WriteLine("Ergebnis: " + result);
        
        */
        Console.ReadKey();
        
        bool isMale = false;
        
        if(isMale != true)
        {
            Console.WriteLine("Ist Männlich");
        }
        

        Console.WriteLine("Bitte geb dein Alter ein:");
        int age = int.Parse(Console.ReadLine());
        
        if(age >= 18)
        {
            Console.WriteLine("Ist volljährig");
        }
        else if(age > 0){
            Console.WriteLine("Bitte gib ein valides Alter ein!");
        }
        else
        {
            Console.WriteLine("Ist nicht volljährig");
        }

        if(age >=18 && isMale != true) { }

        Person alex = new Person();
        alex.brithDate = DateTime.Today;
        alex.height = 180;
        alex.name = "Alexander";

        Console.WriteLine("Körüergröße: " + alex.height);

        alex.Walk();
        
    }

    static void AddNumbers(int numberA, int numberB)
    {
        int a = numberA;
        int b = numberB;

        int result = a + b;

        Console.WriteLine("Das Ergebnis ist: " + result);
    }

    static int AddNumbers2(int numberA, int numberB)
    {
        return numberA + numberB;
    }
}