Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mari")
{
    Console.WriteLine("Ура, это же MARI!!!");
}
else     
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}
