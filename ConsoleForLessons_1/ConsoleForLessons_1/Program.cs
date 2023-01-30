using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForLessons_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            string[] menuHomeWork = new string[] { "\t\t\tЗадание 1", "\t\t\tЗадание 2", "\t\t\tЗадание 3", "\t\t\tЗадание 4", "\t\t\tЗадание 5", "\t\t\tЗадание 6", "\t\t\tЗадание 7", "\t\t\tВыход" };

        menuExit:
            Console.Clear();
            Console.WriteLine("\t\t\tМЕНЮ ДОМАШНИХ ЗАДАНИЙ:\n");

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;

            while (true)
            {
                string[] tasks = menuHomeWork;
                Console.SetCursorPosition(col, row);
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.WriteLine(tasks[i]);
                    Console.ResetColor();
                }
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuHomeWork.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 0:
                                goto tryAgain_1;
                            case 1:
                                goto tryAgain_2;
                            case 2:
                                goto tryAgain_3;
                            case 3:
                                goto tryAgain_4;
                            case 4:
                                goto tryAgain_5;
                            case 5:
                                goto tryAgain_6;
                            case 6:
                                goto tryAgain_7;
                            case 7:
                                return;
                        }
                        break;
                }
            }
        
        tryAgain_1:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");
            Console.WriteLine("\tВведите число от 1 до 100: \n");
            int inputNumb = Convert.ToInt32(Console.ReadLine());
            if (inputNumb % 3 == 0 && inputNumb >= 1 && inputNumb <= 100 && inputNumb % 5 != 0)
            {
                Console.WriteLine("Fizz");
            } 
            if (inputNumb % 5 == 0 && inputNumb >= 1 && inputNumb <= 100 && inputNumb % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
           
            if (inputNumb % 3 == 0 && inputNumb % 5 == 0 && inputNumb >= 1 && inputNumb <= 100)
            {
                Console.WriteLine("Fizz Buzz");
            }
            if (inputNumb % 3 != 0 && inputNumb % 5 != 0 && inputNumb >= 1 && inputNumb <= 100)
            {
                Console.WriteLine($"inputNumb =  {inputNumb}");
            }
            if (inputNumb < 1 || inputNumb > 100)
            {
                Console.WriteLine($"\nВы ввели неправильное число, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_1;
            }
            Console.ReadKey();
            goto menuExit;

            tryAgain_2:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_2\n\n");
            Console.WriteLine("\tВведите число для которого посчитать проценты: \n");
            float inputNumbF = (float)(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\tВведите значение процентов: \n");
            float inputNumb_2 = Convert.ToInt32(Console.ReadLine());
            float resultNumb = (inputNumbF / 100) * inputNumb_2;
            Console.WriteLine($"\nДля числа {inputNumbF} значение {inputNumb_2} процентов составит :  {resultNumb} ");
            Console.ReadKey();
            goto menuExit;

        tryAgain_3:
            string numbForConvert = "";
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_3\n\n");
            Console.WriteLine("\tВведите подряд четыре любых цифры: \n");
            numbForConvert = Console.ReadLine();
            bool isDigit = true;
            while(isDigit)
            {
                foreach (char inp in numbForConvert)
                {
                    isDigit = char.IsDigit(inp);
                }
                break;
            }
            if (!isDigit)
            {
                Console.WriteLine($"\nВы ввели неправильное число, попробуйте ещё раз набрать только цифры!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_3;
            }
            int res = Convert.ToInt32(numbForConvert);
            Console.WriteLine($"Вы ввели число : {res}");
            Console.ReadKey();
            goto menuExit;


        tryAgain_4:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_4\n\n");
            Console.WriteLine("\tВведите число состоящее из шести любых цифр: \n");
            string numbForChange = Console.ReadLine();
            bool isDig = true;
            while (isDig && numbForChange.Length > 0)
            {
                foreach (char inp in numbForChange)
                {
                    isDig = char.IsDigit(inp);
                }
                break;
            }
            if (!isDig || numbForChange.Length < 5 || numbForChange.Length > 6)
            {
                Console.WriteLine($"\nВы ввели неправильное число, попробуйте ещё раз набрать только шесть цифр!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_4;
            }
            Console.WriteLine("\tВведите номер разряда от 1 до 6 - первой цифры которую надо поменять: \n");
            int numberFirst;
            if ((!int.TryParse(Console.ReadLine(), out numberFirst)) || numberFirst < 1 || numberFirst > 6)
            {
                Console.WriteLine("Ошибка ввода! укажите цифру от 1 до 6 ");
                Console.ReadKey();
                goto tryAgain_4;
            }
            Console.WriteLine("\tВведите номер разряда от 1 до 6 - второй цифры которую надо поменять: \n");
            int numberSecond;
            if ((!int.TryParse(Console.ReadLine(), out numberSecond)) || numberSecond < 1 || numberSecond > 6 || numberSecond == numberFirst)
            {
                Console.WriteLine("Ошибка ввода! укажите цифру от 1 до 6 и отличающуюся от первой введёной вами выше!");
                Console.ReadKey();
                goto tryAgain_4;
            }

            char[] digitArray = numbForChange.ToCharArray();
            char buffCha = digitArray[numberFirst - 1];
            digitArray[numberFirst - 1] = digitArray[numberSecond - 1];
            digitArray[numberSecond - 1] = buffCha;
 
             string numb = "";
            for(int i = 0; i <= numbForChange.Length - 1; i++)
            {
                numb += digitArray[i].ToString();
            }

            int changedNumber = Convert.ToInt32(numb);
            Console.WriteLine($"\nПосле рокировки цифр мы получаем число : {changedNumber}\n\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_5:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_5\n\n");
            Console.WriteLine("Введите день месяца: \n");
            int dayNumb;
            if((!int.TryParse(Console.ReadLine(), out dayNumb)) || dayNumb < 1 || dayNumb > 31) {
                Console.WriteLine($"\nВы ввели некорректное число дня месяца, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_5;
            }
            Console.WriteLine("\nВведите месяц числом от 1 до 12: \n");
            int monthNumb;
            if ((!int.TryParse(Console.ReadLine(), out monthNumb)) || monthNumb < 1 || monthNumb > 12)
            {
                Console.WriteLine($"\nВы ввели некорректное число для месяца, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_5;
            }
            Console.WriteLine("\nВведите год четырёхзначным числом: \n");
            int yearNumb;
            if ((!int.TryParse(Console.ReadLine(), out yearNumb)) || yearNumb < 1 || yearNumb > 9999)
            {
                Console.WriteLine($"\nВы ввели некорректное число для года, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_5;
            }

            string resDate = dayNumb.ToString() + "." + monthNumb.ToString() + "." + yearNumb.ToString();
            Console.WriteLine($"\nДля даты: {resDate} соответствует:\n\n ");

            DateTime dataInfo = new DateTime(yearNumb, monthNumb, dayNumb);
            string nameDay = dataInfo.ToString("dddd");

            string season = " ";

            if(monthNumb == 12 || monthNumb == 1 || monthNumb == 2)
            {
                season = "Winter";
            }
            if (monthNumb == 3 || monthNumb == 4 || monthNumb == 5)
            {
                season = "Spring";
            }
            if (monthNumb == 6 || monthNumb == 7 || monthNumb == 8)
            {
                season = "Summer";
            }
            if (monthNumb == 9 || monthNumb == 10 || monthNumb == 11)
            {
                season = "Autumn";
            }
            string resultString = season + " " + nameDay;
            Console.WriteLine($"\n{resultString}\n");
            Console.ReadKey();
            goto menuExit;


        tryAgain_6:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_6\n\n");
            Console.WriteLine("Введите значение температуры: \n");
            int tempNumb;
            if (!int.TryParse(Console.ReadLine(), out tempNumb)) 
            {
                Console.WriteLine($"\nВы ввели некорректное число для температуры, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_6;
            }
            Console.WriteLine("Выберите способ конвертирования значения: \n");
            Console.WriteLine("Нажмите 1. для перевода из градусов Цельсия в градусы по Фаренгейту \n");
            Console.WriteLine("Нажмите 2. для перевода из градусов Фаренгейта в градусы по Цельсию \n");
            double tempCF;
            double tempFC;
            if(Console.ReadKey().Key == ConsoleKey.D1) 
            {
                tempCF = (5 * tempNumb) / 9 + 32;
                Console.WriteLine($"\nЗначение {tempNumb} градуса по Цельсию соответствует значению {tempCF} градусов по Фаренгейту\n");
            }
            if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                tempFC = 5 / 9 * (tempNumb - 32);
                Console.WriteLine($"\nЗначение {tempNumb} градуса по Фаренгейту соответствует значению {tempFC} градусов по Цельсию\n");
            }
            Console.ReadKey();
            goto menuExit;

        tryAgain_7:
            Console.Clear();
            Console.WriteLine("\t\tЗАДАНИЕ_7\n\n");
            Console.WriteLine("Введите числовое значение нижней границы диапозона: \n");
            int firstNumber;
            if (!int.TryParse(Console.ReadLine(), out firstNumber)) 
            {
                Console.WriteLine($"\nВы ввели некорректное число, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_7;
            }
            Console.WriteLine("Введите числовое значение верхней границы диапозона: \n");

            int secondNumber;
            if (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine($"\nВы ввели некорректное число, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_7;
            }
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"\nВы ввели некорректный диапозон чисел, числа не должны быть равны, попробуйте ещё раз!\n");
                Console.WriteLine($"Для повторения попытки нажмите любую клавишу\n");
                Console.ReadKey();
                goto tryAgain_7;
            }
            int footer = 0;
            int header = 0;
            if (firstNumber < secondNumber) 
            { 
                footer = firstNumber;
                header = secondNumber;
            }
            if (firstNumber > secondNumber)
            {
                footer = secondNumber;
                header = firstNumber;
            }

            Console.WriteLine($"\nВ указанном вами диапозоне чисел {footer} - {header} чётными являются числа: ");
            for (int i = footer; i <= header;i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine($" {i}");
                
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;
        } 
    }
}
