Console.Write("Ввежите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Ура, это же СЕРГЕЙ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}