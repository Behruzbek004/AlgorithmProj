Behruz:
//1 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else
//{
//    Console.WriteLine(number);
//}
//2 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else
//{
//    Console.WriteLine(number - 2);
//}
//3 - misol
//int number = int.Parse(Console.ReadLine());
//if (number > 0)
//{
//    Console.WriteLine(++number);
//}
//else if (number < 0)
//{
//    Console.WriteLine(number - 2);
//}
//else
//{
//    number = 10;
//    Console.WriteLine(number);
//}
//4 - misol
//int number = int.Parse(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());
//int number2 = int.Parse(Console.ReadLine());
//if ((number > 0 && number1 < 0 && number2 < 0) || (number < 0 && number1 > 0 && number2 < 0) || (number < 0 && number1 < 0 && number2 > 0))
//{
//    Console.WriteLine(" Musbat sonlar soni " + 1 + " ta");
//}
//else if ((number > 0 && number1 > 0 && number2 < 0) || (number > 0 && number1 < 0 && number2 > 0) || (number < 0 && number1 > 0 && number2 > 0))
//{
//    Console.WriteLine(" Musbat sonlar soni " + 2 + " ta");
//}
//lse if (number > 0 && number1 > 0 && number2 > 0)
//{
//    Console.WriteLine(" Musbat sonlar soni " + 3 + " ta ");
//}
//5 - misol
//int number = int.Parse(Console.ReadLine());
//int number1 = int.Parse(Console.ReadLine());
//int number2 = int.Parse(Console.ReadLine());
//if ((number > 0 && number1 < 0 && number2 < 0) || (number < 0 && number1 > 0 && number2 < 0) || (number < 0 && number1 < 0 && number2 > 0))
//{
//    Console.WriteLine(" Musbat sonla soni " + 1 + " ta");
//    Console.WriteLine(" Manfiy sonlar soni " + 2 + " ta");
//}
//else if ((number > 0 && number1 > 0 && number2 < 0) || (number < 0 && number1 > 0 && number2 > 0) || (number > 0 && number1 < 0 && number2 > 0))
//{
//    Console.WriteLine(" Musbat sonlar soni " + 2 + " ta");
//    Console.WriteLine(" Manfiy sonlar soni " + 1 + " ta");
//}
//else if ((number > 0 && number1 > 0 && number2 > 0))
//{
//    Console.WriteLine(" Musbat sonlar soni " + 3 + " ta");
//    Console.WriteLine(" Manfiy sonlar soni " + 0 + " ta");
//}
//else
//{
//    Console.WriteLine(" Manfiy sonlar soni " + 3 + " ta");
//}
//6 - misol
//int A = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());
//if (A > B)
//{
//    Console.WriteLine(A);
//}
//else
//{
//    Console.WriteLine(B);
//}
//7 - misol
//int A = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());
//if (A < B)
//{
//    Console.WriteLine(A);
//}
//else
//{
//    Console.WriteLine(B);
//}
//8 - misol
//int A = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());
//if (A > B)
//{
//    Console.WriteLine("Max " + A);
//    Console.WriteLine("Min " + B);
//}
//if (A < B)
//{
//    Console.WriteLine("Max " + B);
//    Console.WriteLine("Min " + A);
//}
//9 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    int c = b;
//    b = a;
//    a = c;
//    Console.WriteLine(" b = " + b + " \n a = " + a);
//}
//else if (a < b)
//{
//    Console.WriteLine(" b = " + b + " \n a = " + a);
//}
//10 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a != b)
//{
//    Console.WriteLine("Yig'indi " + (a + b));
//}
//else if (a == b)
//{
//    Console.WriteLine(0);
//}
//11 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if ((a != b) && (a > b))
//{
//    Console.WriteLine("Natija = " + a);
//}
//else if ((a != b) && (a < b))
//{
//    Console.WriteLine("Natija = " + b);
//}
//else
//{
//    Console.WriteLine(0);
//}
//12 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if (a > b && c > b)
//{
//    Console.WriteLine("Kichiki : " + b);
//}
//else if (a < b && a < c)
//{
//    Console.WriteLine("Kichiki : " + a);
//}
//else
//{
//    Console.WriteLine("Kichiki : " + c);
//}
//13 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//if ((a < b && b < c) || (c < b && b < a))
//{
//    Console.WriteLine("Natija : " + b);
//}
//else if ((b < a && a < c) || (c < a && a < b))
//{
//    Console.WriteLine("Natija : " + a);
//}
//else if ((a < c && c < b) || (b < c && c < a))
//{
//    Console.WriteLine("Natija : " + c);
//}
//14 - misol chiqmadi
//20 - misol
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
////int d = int.Parse(Console.ReadLine());
//if (Math.Abs(a - b) > Math.Abs(a - c))
//{
//    Console.WriteLine("YAQIN NUQTA: " + b + "\nmasofasi: " + Math.Abs(a - c));
//}
//else if (Math.Abs(a - b) < Math.Abs(a - c))
//{
//    Console.WriteLine("YAQIN NUQTA: " + b + "\nmasofasi: " + Math.Abs(a - b));
//}
//else if (Math.Abs(a - b) == Math.Abs(a - c))
//{
//    Console.WriteLine("yaqin nuqta: " + b + " " + c);
//}
//else if (a == b && b == c)
//{
//    Console.WriteLine("nuqtalar ustma ust tushadi");
//}
//if 24 - misol
//double x = double.Parse(Console.ReadLine());
//if (x > 0)
//{
//    Console.WriteLine("f(x) = " + (2 * (Math.Sin(x))));
//}
//else if (x <= 0)
//{
//    Console.WriteLine("f(x) = " + (x - 2));
//}
//if 25 - misol
//double x = double.Parse(Console.ReadLine());
//if ((x < -2)(x > 2))
//{
//    Console.WriteLine("f(x) = " + (2 * x));
//}
//else
//{
//    Console.WriteLine("f(x) = " + (-3 * x));
//}
//if 26 - misol
//double x = double.Parse(Console.ReadLine());
//if (x <= 0)
//{
//    Console.WriteLine("f(x) = " + (-x));
//}
//else if ((0 < x) && (x < 2))
//{
//    Console.WriteLine("f(x) = " + Math.Pow(2, x));
//}
//else if (x >= 2)
//{
//    Console.WriteLine("f(x) = " + 4);
//}
//if 26 - misol
//double x = double.Parse(Console.ReadLine());
//if (x < 0)
//{
//    Console.WriteLine("f(x) = " + 0);
//}
//27 - misol
//int x = int.Parse(Console.ReadLine());
//if (x < 0)
//{
//    Console.WriteLine(0);
//}
//else if ((x <= 0 && x < 1) || (x <= 2 && x < 3))
//{
//    Console.WriteLine(1);
//}
//else if ((x <= 1 && x < 2) || (x <= 3 && x < 4))
//{
//    Console.WriteLine(-1);
//}
//if 28 - misol
//int year = int.Parse(Console.ReadLine());
//if ((year % 4 == 0 && year % 100 != 0)(year % 400 == 0))
//{
//    Console.WriteLine("Kabisa yili, bu yilda 366 kun bor");
//}
//if 29 - misol
//int a = int.Parse(Console.ReadLine());
//if (a > 0)
//{
//    Console.WriteLine("musbat toq son = " + ((a / 2 == 1)));
//}
//else if (a < 0)
//{
//    Console.WriteLine("manfiy juft son = " + (a % 2 == 0));
//}
//else if (a == 0)
//{
//    Console.WriteLine(0);
//}
//switch Case 5 - misol
//Console.Write("a = "); double a = double.Parse(Console.ReadLine());
//char temp = char.Parse(Console.ReadLine());
//Console.Write("b = "); double b = double.Parse(Console.ReadLine());

//switch (temp)
//{
//    default:
//        Console.WriteLine("bunaqa amal yuq"); break;
//    case '+':
//        Console.WriteLine(a + " + " + b + " = " + (a + b));
//    break;
//    case '-':
//        Console.WriteLine("a - b = " + (a - b));
//    break;
//    case '*':
//        Console.WriteLine("a * b = " + (a * b));
//    break;
//    case '/':
//        Console.WriteLine("a / b = " + (a / b));
//    break;
//}
//Case - 7
//double massaBirligi = double.Parse(Console.ReadLine());
//double tartibRaqami = double.Parse(Console.ReadLine());
//double a = 0;
//string temp;
//switch (tartibRaqami)
//{
//    case 1:
//        a = massaBirligi * 1;
//        Console.WriteLine(massaBirligi + " kilogram " + a + " kg ");
//        break;
//    case 2:
//        a = massaBirligi / 1000000;
//        Console.WriteLine(massaBirligi + " milliklagram " + a + " kg ");
//        break;
//    case 3:
//        a = massaBirligi / 1000;
//        Console.WriteLine(massaBirligi + "gramm " + a + " kg ");
//        break;
//    case 4:
//        a = massaBirligi * 1000;
//        Console.WriteLine(massaBirligi + " tonna " + a + " kg ");
//        break;
//    case 5:
//        a = massaBirligi * 100;
//        Console.WriteLine(massaBirligi + " Setner " + a + " kg ");
//        break;
//    default:
//        Console.WriteLine(" Bunday ulchov yo'q ");
//        break;
//}
//case-8
//Console.Write("kun = "); int day = int.Parse(Console.ReadLine());
//Console.Write("oy = "); int month = int.Parse(Console.ReadLine());
//switch (month)
//{

//    case 1:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- yanvar");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 3:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- mart");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 5:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- may");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 7:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- iyul");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 8:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- avgust");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 10:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- oktyabr");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 12:
//        if (day <= 31)
//        {
//            Console.WriteLine(day + "- dekabr");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 4:
//        if (day < 30)
//        {
//            Console.WriteLine(day + "- aprel");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 6:
//        if (day <= 30)
//        {
//            Console.WriteLine(day + "- iyun");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 9:
//        if (day <= 30)
//        {
//            Console.WriteLine(day + "- sentabr");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;

//    case 11:
//        if (day <= 30)
//        {
//            Console.WriteLine(day + "- noyabr");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    case 2:
//        if (day <= 28)
//        {
//            Console.WriteLine(day + "- fevral");
//        }
//        else
//        {
//            Console.WriteLine("\akunni tug'ri kiriting ");
//        }
//        break;
//    default: Console.WriteLine("bunday oy mavjud emas"); break;
//}








































goto Behruz;

