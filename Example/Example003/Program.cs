//double numberA = 12;
//double numberB = 5;
//double result = numberA / numberB;
//Console.WriteLine(result);

//int numberA = 35;
//int numberB = 53;
//int result = numberA + numberB;
//Console.WriteLine(result);

//int numberA = new Random().Next(1,10);
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1,10);
//Console.WriteLine(numberB);
//int result = numberA + numberB;
//Console.WriteLine(result);


Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if(username.ToLower() == "маша")
{
 Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}