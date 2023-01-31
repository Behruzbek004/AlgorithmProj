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
//case1 - misol
//Console.Write("Enter your week day: "); int weekDay = int.Parse(Console.ReadLine());
//switch (weekDay)
//{
//    case 1:
//        Console.WriteLine("Dushanba");
//        break;
//    case 2:
//        Console.WriteLine("Seshanba");
//        break;
//    case 3:
//        Console.WriteLine("Chorshanba");
//        break;
//    case 4:
//        Console.WriteLine("Payshanba");
//        break;
//    case 5:
//        Console.WriteLine("Juma");
//        break;
//    case 6:
//        Console.WriteLine("Shanba");
//        break;
//    case 7:
//        Console.WriteLine("Yakshanba");
//        break;
//    default:
//        Console.WriteLine("\aThis is week day not found");
//        break;
//}
//case3 - misol
//Console.Write("monthNumber = "); int monthNum = int.Parse(Console.ReadLine());
//switch (monthNum)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("Winter");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Spring");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Summer");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Autumn");
//        break;
//    default: Console.WriteLine("\aMonth not found");
//        break;
//}
//case4 - misol
//Console.Write("monthNumber = "); int monthNum = int.Parse(Console.ReadLine());
//int a = 0;
//switch (monthNum)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        a = 31;
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        a = 30; break;
//    case 2:
//        a = 28;
//        break;
//    default:  Console.WriteLine("bunday oy mavjud emas ");break;
//}
//if (monthNum < 12)
//{
//    Console.WriteLine($"{monthNum}- oy, {a} kundan iborat");
//}
//Case5 - misol
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
//case6 - misol
//double kesmaUzunligi = double.Parse(Console.ReadLine());
//double tartibRaqami = double.Parse(Console.ReadLine());
//double a = 0;
//string temp;
//switch (tartibRaqami)
//{
//    case 1:
//        a = kesmaUzunligi / 10;
//        Console.WriteLine(kesmaUzunligi + " desimetr " + a + " metr");
//        break;
//    case 2:
//        a = kesmaUzunligi * 1000;
//        Console.WriteLine(kesmaUzunligi + " kilometr " + a + " metr");
//        break;
//    case 3:
//        a = kesmaUzunligi * 1;
//        Console.WriteLine(kesmaUzunligi + " metr " + a + " metr");
//        break;
//    case 4:
//        a = kesmaUzunligi / 1000;
//        Console.WriteLine(kesmaUzunligi + " millimetr " + a + " metr");
//        break;
//    case 5:
//        a = kesmaUzunligi / 100;
//        Console.WriteLine(kesmaUzunligi + " santimetr " + a + " metr");
//        break;
//    default:
//        Console.WriteLine("sjhdfjjuhgdfjgh");
//        break;
//}
//Case7 - misol
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
//case9 - misol
//case16 - misol
//Random temp = new Random();
//Console.Write("Enter your age = "); int age = temp.Next(20, 69); Console.WriteLine(age);
//string birliklarXonasi, unliklarXonasi;
//int birlar_xonasi, unlar_xonasi;
//birlar_xonasi = age % 10;
//unlar_xonasi = (age / 10) % 10;
//switch (birlar_xonasi)
//{
//    case 1:
//        birliklarXonasi = " bir "; break;
//    case 2:
//        birliklarXonasi = " ikki "; break;
//    case 3:
//        birliklarXonasi = " uch "; break;
//    case 4:
//        birliklarXonasi = " to'rt "; break;
//    case 5:
//        birliklarXonasi = " besh "; break;
//    case 6:
//        birliklarXonasi = " olti "; break;
//    case 7:
//        birliklarXonasi = " yetti "; break;
//    case 8:
//        birliklarXonasi = " sakiz "; break;
//    case 9:
//        birliklarXonasi = " to'qiz "; break;
//    default: birliklarXonasi = string.Empty; break;
//}
//switch (unlar_xonasi)
//{
//    case 1:
//        unliklarXonasi = " o'n "; break;
//    case 2:
//        unliklarXonasi = " yigirma "; break;
//    case 3:
//        unliklarXonasi = " o'tiz "; break;
//    case 4:
//        unliklarXonasi = " qirq "; break;
//    case 5:
//        unliklarXonasi = " ellik "; break;
//    case 6:
//        unliklarXonasi = " oltmish "; break;
//    default: unliklarXonasi = string.Empty; break;
//}
//Console.WriteLine($"{unliklarXonasi}{birliklarXonasi}");
//case18 - misol
//Random temp = new Random();
//Console.Write("Enter your number = "); int number = temp.Next(100, 999); Console.WriteLine(number);
//string birliklarXonasi, unliklarXonasi,yuziklarXonasi;
//int birlar_xonasi, unlar_xonasi,yuzlar_xonasi;
//birlar_xonasi = number % 10;
//unlar_xonasi = (number / 10) % 10;
//yuzlar_xonasi = (number / 100);
//switch (birlar_xonasi)
//{
//    case 1:
//        birliklarXonasi = " bir "; break;
//    case 2:
//        birliklarXonasi = " ikki "; break;
//    case 3:
//        birliklarXonasi = " uch "; break;
//    case 4:
//        birliklarXonasi = " to'rt "; break;
//    case 5:
//        birliklarXonasi = " besh "; break;
//    case 6:
//        birliklarXonasi = " olti "; break;
//    case 7:
//        birliklarXonasi = " yetti "; break;
//    case 8:
//        birliklarXonasi = " sakiz "; break;
//    case 9:
//        birliklarXonasi = " to'qiz "; break;
//    default: birliklarXonasi = string.Empty; break;
//}
//switch (unlar_xonasi)
//{
//    case 1:
//        unliklarXonasi = " o'n "; break;
//    case 2:
//        unliklarXonasi = " yigirma "; break;
//    case 3:
//        unliklarXonasi = " o'tiz "; break;
//    case 4:
//        unliklarXonasi = " qirq "; break;
//    case 5:
//        unliklarXonasi = " ellik "; break;
//    case 6:
//        unliklarXonasi = " oltmish "; break;
//    case 7:
//        unliklarXonasi = " yetmish "; break;
//    case 8:
//        unliklarXonasi = " sakson "; break;
//    case 9:
//        unliklarXonasi = " to'qson "; break;
//    default:
//        unliklarXonasi = string.Empty; break;
//}
//switch (yuzlar_xonasi)
//{
//    case 1:
//        yuziklarXonasi = " bir yuz "; break;
//    case 2:
//        yuziklarXonasi = " ikku yuz "; break;
//    case 3:
//        yuziklarXonasi = " uch yuz "; break;
//    case 4:
//        yuziklarXonasi = " to'rt yuz "; break;
//    case 5:
//        yuziklarXonasi = " besh yuz "; break;
//    case 6:
//        yuziklarXonasi = " olti yuz "; break;
//    case 7:
//        yuziklarXonasi = " yetti yuz "; break;
//    case 8:
//        yuziklarXonasi = " sakiz yuz "; break;
//    case 9:
//        yuziklarXonasi = " to'qiz yuz "; break;
//    default:
//        yuziklarXonasi = string.Empty; break;
//}
//Console.WriteLine($"{yuziklarXonasi} {unliklarXonasi} {birliklarXonasi}");
//case12 - misol
//Console.Write("komanda= "); double komanda = double.Parse(Console.ReadLine());
//Console.Write("qiymat= "); double qiymat = double.Parse(Console.ReadLine());
//double r = 0, d = 0, l = 0, s = 0;
//switch (komanda)
//{
//    case 1:
//        r = qiymat;
//        d = 2 * r;
//        l = 2 * Math.PI * r;
//        s = Math.PI * Math.Pow(r, 2);
//        break;
//    case 2:
//        d = qiymat;
//        r = d / 2;
//        l = d * Math.PI;
//        s = (Math.PI * Math.Pow(d, 2)) / 4;
//        break;
//    case 3:
//        l = qiymat;
//        d = l / Math.PI;
//        r = l / (2 * Math.PI);
//        s = Math.PI * Math.Pow((l / (2 * Math.PI)), 2);
//        break;
//    case 4:
//        s = qiymat;
//        d = 2 * Math.Sqrt(s / Math.PI);
//        r = Math.Sqrt(s / Math.PI);
//        l = 2 * Math.Sqrt(s * Math.PI);
//        break;
//    default:
//        Console.WriteLine("comanda neto");
//        break;
//}
//Console.WriteLine($"radius = {r}\ndiametr = {d}\nuzunlik = {l}\nyuza = {s}");
//case13 - misol
//Console.Write("komanda= "); double komanda = double.Parse(Console.ReadLine());
//Console.Write("qiymat= "); double qiymat = double.Parse(Console.ReadLine());
//double c = 0,a = 0,h = 0,S = 0;
//switch (komanda)
//{
//      case 1:
//        a = qiymat;
//        c = a * Math.Sqrt(2);
//        h =(a * Math.Sqrt(2));
//        S = Math.Pow(a, 2);
//           break;
//      case 2:
//        c = qiymat;
//        a = c / Math.Sqrt(2);
//        h = c / 2;
//        S = (Math.Pow(c, 2)) / 4;
//           break;
//      case 3:
//        h = qiymat;
//        a = (2 * h) / Math.Sqrt(2);
//        c = 2 * h;
//        S = Math.Pow(h, 2);
//           break;
//      case 4:
//        S = qiymat;
//        a = Math.Sqrt(2 * S);
//        c = 2 * Math.Sqrt(S);
//        h = Math.Sqrt(S);
//           break;
//           default:Console.WriteLine("Xatoooooooooooooooooo");
//        break;
//}
//Console.WriteLine($"gipatinuza=  {c}\nkatet= {a}\nbalandlik= {h} \nyuza= {S}");
//Console.WriteLine("=========================================================");

 




































goto Behruz;

