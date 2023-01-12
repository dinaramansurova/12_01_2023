Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "динара")
{
    Console.WriteLine("Ура, это же Динара!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}