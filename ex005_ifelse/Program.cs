Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
 
if(username.ToLower() == "Давид")
{
    Console.WriteLine("Еу, да это же Давид!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}