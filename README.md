1. Создали папку Example001_HelloConsole.
2. Использовали команду dotnet new console для создания нового проекта
3. Работаем в файле Program.cs
4. dotnet run - вводим в консоле для запуска написанной программы (проекта).
5. Console.WriteLine("2 Hello, World!"); - Console - обращение к терминалу, WriteLine - В конце перейти на новую строку, ("2 Hello, World!") - текчт того, что выводим.
6. Создали папку Example002_HelloUser.
7. string username = Console.ReadLine(); - string - тип данных (в данном случае строки). username - название(индентификатор) данных(контейнера), ReadLine() - Считать строку из терминала (запрос к терминалу на запись введенных пользователем в терминал данных).
    - Console.WriteLine("Привет, "); - выводим сообщение 
    - Console.WriteLine(username); - выводим записанное пользователем имя
8. Улучшили программу изменив WriteLine на Write - таким образом информация будет выводиться в одну строку, что визуально более удобно.
9. Создали файл .gitignore - и внесли в него информацию с репозитория лектора для игнорирования отслеживания не нужных файлов в репозитории.
10. int numberA = 31;
    int numberB = 5;
    int result = numberA + numberB;
    Console.WriteLine(result);
Данная программа выводит сумму двух заданных чисел. int - переменная(целое число). Диапазон(2 147 483 648 до 2 147 483 647). Размер (32-разрядное целое число со знаком)
11. Заметка, файл .gitignore нужно добавлять до пуша. 
12. double numberA = 12;
    double numberB = 5;
    double result = numberA / numberB;
    Console.WriteLine(result);
    Данная программа выводит результат деления двух заданных чисел. double - переменная(для не целых чисел). Диапазон (огромный). Размер (64-разрядное целое число со знаком).
13. string - Диапазон(от 0 до много символов). Размер(от 4 байт до 2гб).
14. bool - Диапазон(true и false). Размер(1 байт).
15. % - нахождение остатка от деления.
16. new Random().Next(min,max) - комвнда генератор случайных чисел. Данная команда даст случайное число от min до max-1 [min,max-1] или [min.max]
17. int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
    Console.WriteLine(numberA);
    int numberB = new Random().Next(1, 10);
    onsole.WriteLine(numberB);
    int result = numberA + numberB;
    Console.WriteLine(result);
Программа выводит сумму двух случайных числе в заданном диапазоне.
18. if(УСЛОВИЕ) 
{
    Набор действий 1
} 
else
{
    Набор действий 2
}
19. Console.Write("Ввежите имя пользователя: ");
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
Программа выводит особое обращение только при вводе опредеоенного имени. ToLower() - переводит все в нижний регистр(таким образом мы устранили проблему при написании имени пользователя в нижнем или верхнем регистре).
20. int a = 1;
    int b = 2;
    int c = 6;
    int d = 8;
    int e = 4;

    int max = a;
 
    if (a > max ) max = a;
    if (b > max ) max = b;
    if (c > max ) max = c;
    if (d > max ) max = d;
    if (e > max ) max = e;

    Console.Write("max = ");
    Console.WriteLine(max);
Программа по нахождению максимального значения. 
21. Цикл
while(УСЛОВИЕ ПРОДОЛЖЕНИЯ)
{
    Набор действий
}

int count = 0;

while(count<100)
{
   Набор действий
   count = count+1 
}
count это счетчик.
22. Console.Clear(); - очистить консоль
    Console.SetCursorPosition(10, 4); 
    Console.WriteLine("+");
Поставить курсор на позиции по заданным координатам и отобразить его заданным знаком.
23. Console.Clear();
//Console.SetCursorPosition(10, 4); 
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb); 
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc); 
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // Можно count++

}
Программа для построения треугольника эллера
24. Решил задачу с собакой:
int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine(count);
Ответ = 12
