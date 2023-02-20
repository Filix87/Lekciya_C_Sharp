//Варианты приветствий после введения имени//

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "наташа")
{
    Console.WriteLine("Наташа, ты где была? Мы все просрали!");
}
else
{
    Console.Write("Привет, !");
    Console.WriteLine(username);
}