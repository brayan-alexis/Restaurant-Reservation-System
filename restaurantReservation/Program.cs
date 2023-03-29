/* 
 * ¡INSTRUCTIONS!
 * 1.- Validar si el Usuario existe o debe registrarse y generar un sistema de Login.
 * 2.- El programa debe dar la bienvenida a cada usuario existente 
 * 3.- El programa se repetirá hasta registrar 10 personas
*/ 

Console.WriteLine("Hello, welcome to Alx Restaurant!");

string[] userNames = new string[10] { "Alx", "", "", "", "", "", "", "", "", "" };
int arrayCurrentIndex = 1;
bool userType;

while (true)
{
    Console.WriteLine("Are you a registered user? Write true, or false to register.");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Hello again, you are a registered user, please enter your user name");
        string usertToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", usertToSearch);
    }
}