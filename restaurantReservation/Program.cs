/* 
 * ¡INSTRUCTIONS!
 * 1.- Validar si el Usuario existe o debe registrarse y generar un sistema de Login.
 * 2.- El programa debe dar la bienvenida a cada usuario existente 
 * 3.- El programa se repetirá hasta registrar 10 personas
*/ 

Console.WriteLine("Hello, welcome to Alx Restaurant!");

string[] userNames = new string[10] { "Brayan", "Alexis", "Alx", "Juan", "Luis", "Mario", "Laura", "Joel", "Cass", "" };
int arrayCurrentIndex = 9;
bool userType;

// Verifica si hay espacio en el resturante
while (arrayCurrentIndex < userNames.Length)
{
    /*
    // Verifica si hay espacio en el resturante
    if(arrayCurrentIndex == userNames.Length)
    {
        Console.WriteLine("    The restaurant is full, try again later...");
        Environment.Exit(0);
    }
    */

    Console.WriteLine("\n   Are you a registered user? Write true, or false to register.");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Hello again, you are a registered User, please enter your User Name");
        string usertToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", usertToSearch);
        int index = Array.IndexOf(userNames, usertToSearch);
        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else
        {
            Console.WriteLine("Welcome {0}, it's a preasure to give you food ", userNames[index]);
        }
    }
    else if (userType == false) {
        Console.WriteLine("Please write and remember your User Name");
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("Your User has been save successfully \n" +
            "Your User Name is: {0}", userNames[arrayCurrentIndex]);
        arrayCurrentIndex++;
    }
}

// Resultados una vez que el restaurante tenga 10 Users registrados
Console.WriteLine("    The restaurant is full, try again later...\n These are the guest for the dinner");
int auxIndex = 0;
foreach (string name in userNames)
{
    Console.WriteLine($"User Number: {auxIndex+1} and User Name: {name}");
    //Console.WriteLine("User Number: {0} and User Name: {1}", auxIndex+1, name);                  Alternativa 1
    //Console.WriteLine("User Number: {0} and User Name: {1}", auxIndex+1, userNames[auxIndex]);   Alternativa 2
    auxIndex++;
}
Environment.Exit(0);