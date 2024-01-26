
// Console.WriteLine("Hello, world!"); // вывод информации в консоль
// Console.Write("Hello world!"); // вывод информации в консоль

// int a;   //  int - это переменная в которой будет храниться целое число  
// int b;


// a = 4;   //  = -это не равно, это записывание значения во внутрь переменной,в a записываем 4, в b записываем 7
// b = 7;



// Console.WriteLine("Sum ="+ a + b);  //  так лучше не записывать 
// Console.WriteLine($"{a} + {b}= \n {a+b}");  // лучше так записывать со знаком интерпаляции " $ " 
// //все, что в не фигурных скобках - это текст, чтобы перейти на новую строку надо прописать \n.

// int sum = a = b; // еще можно так 
// Console.WriteLine($"{a} + {b}= \n {sum}"); // записать сумму

// int a = 4; // вместо значения 4 и 7 мы впишем
// int b = 7;
// int a = int.Parse(Console.ReadLine()!); // это значит, что Console.ReadLine считывает данные из консоли и
// // надо после dotnet run вбивать самим значения 4 и 7, любые, но перед алгоритмом надо написать приглашение,
// // Consol.WriteLine("Ведите первое число: "); а int.Parse переводит число в текст
// // в итоге получаем, было:
// int a = 4:
// int b =7:
// int sum = a+b;
// Console.WriteLine($"{a} + {b} = {sum}");
// // а стало
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!); // int - целое число
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {a/b}");


// Console.WriteLine("Введите первое число: ");
// double a = int.Parse(Console.ReadLine()!);  // double - дробное число
// Console.WriteLine("Введите второе число: ");
// double b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {a/b}");


// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {(double)a/b}"); // но можно одну переменную любую либо a либо b превратить в double
// // и будет всем счастье

// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine()!); // вместо int.Parse можно использовать Convert.ToInt32
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {a/b}");

// int a; int b;
// Console.WriteLine("Введите первое число: ");
// int.TryParse(Console.ReadLine(),out a);  // лучше брать вместо int.Parse - int.TryParse
// Console.WriteLine("Введите второе число: ");
// int.TryParse(Console.ReadLine(),out b);
// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {a/b}");

// когда есть ветвления if выполнение условия for, лучше брать int.TryParse
// int a; int b;
// Console.WriteLine("Введите первое число: ");
// int.TryParse(Console.ReadLine(),out a);  // лучше брать вместо int.Parse - int.TryParse
// Console.WriteLine("Введите второе число: ");
// int.TryParse(Console.ReadLine(),out b);

// if (2 < 5)   // если какоето условие выполняется, тогда мы выполняем тот код который находится внутри { }- скобок
// {
// Console.WriteLine($"Done"); // то выводится "Done"
// }




// Console.WriteLine($"{a} + {b} = {a+b}");
// Console.WriteLine($"{a} - {b} = {a-b}");
// Console.WriteLine($"{a} * {b} = {a*b}");
// Console.WriteLine($"{a} / {b} = {a/b}");

// когда есть ветвления if выполнение условия for, лучше брать int.TryParse
// int a; int b;
// Console.WriteLine("Введите первое число: ");
// int.TryParse(Console.ReadLine(),out a);  // лучше брать вместо int.Parse - int.TryParse
// Console.WriteLine("Введите второе число: ");
// int.TryParse(Console.ReadLine(),out b);

// if (a < b)   // если какоето условие выполняется, тогда мы выполняем тот код который находится внутри { }- скобок
// {
// Console.WriteLine($"Done"); // то выводится "Done"
// }

// if (a < b)   // если какоето условие выполняется, тогда мы выполняем тот код который находится внутри { }- скобок
// {
// Console.WriteLine($"a < b"); // то выводится "Done"
// }
// else
// {
//      Console.WriteLine($"a >= b");
// }


// 


// принимает на вход три числа и выдаёт максимальное из этих



 
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);

 int max = a;
       
 if (max <b)
 {
        max = b;
 }
 if (max < c)
 {
 max = c;       
 }
Console.WriteLine(max);





//на вход  принимает число (number), а на выходе выводит 
// все чётные числа от 1 до number (включительно), 
//после каждого числа должен быть знак пробела.


// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);


 
 

 

 

 
    
 