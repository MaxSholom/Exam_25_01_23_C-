using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForLessons_1
{


	class HomeWork_30_11_22
	{

        static void Main(string[] args)
        {

            string[] menuHomeWork = new string[] { "\t\t\tЗадание 1", "\t\t\tЗадание 2",
            "\t\t\tЗадание 3", "\t\t\tЗадание 4", "\t\t\tЗадание 5", "\t\t\tЗадание 6",
            "\t\t\tЗадание 7", "\t\t\tВыход" };

        menuExit:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tМЕНЮ ДОМАШНИХ ЗАДАНИЙ:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tВыберите стрелками задание\n");

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
            double[] oneDimensialArray = new double[5];
            for (int i = 0; i < oneDimensialArray.Length; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");

                Console.WriteLine("\tЗаполните одномерный массив пятью подряд дробными числами: \n");
                Console.WriteLine($"Введите значение числителя {i + 1}-й дроби: ");
                double numerator;
                if (!double.TryParse(Console.ReadLine(), out numerator))
                {
                    Console.WriteLine("Ошибка ввода! Укажите корректное число ");
                    Console.ReadKey();
                    goto tryAgain_1;
                }
                Console.WriteLine($"\nВведите значение знаменателя {i + 1}-й дроби: ");
                double denominator;
                if (!double.TryParse(Console.ReadLine(), out denominator))
                {
                    Console.WriteLine("Ошибка ввода! Укажите корректное число ");
                    Console.ReadKey();
                    goto tryAgain_1;
                }
                oneDimensialArray[i] = (double)(numerator / denominator);
                Console.WriteLine($"\nРезультирующее {i + 1}-e дробное число: {Math.Round(oneDimensialArray[i], 3)}");

            }

            Console.WriteLine("\nВы заполнили одномерный массив следующими числами: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            double multElem = 1f;
            double sumEven = 0f;
            for (int i = 0; i < oneDimensialArray.Length; i++)
            {
                Console.Write(Math.Round(oneDimensialArray[i], 3) + "  ");
                multElem *= oneDimensialArray[i];
                if (i % 2 == 0)
                {
                    sumEven += oneDimensialArray[i];
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"\nМаксимальное число в массиве: {Math.Round(oneDimensialArray.Max(), 3)}");
            Console.WriteLine($"\nМинимальное число в массиве: {Math.Round(oneDimensialArray.Min(), 3)}");
            Console.WriteLine($"\nСумма всех чисел в массиве: {Math.Round(oneDimensialArray.Sum(), 3)}");
            Console.WriteLine($"\nПроизведение всех чисел в массиве: {Math.Round(multElem, 7)}");
            Console.WriteLine($"\nСумма всех чётных элементов в массиве: {Math.Round(sumEven, 3)}");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nДвумерный массив случайных чисел: \n");
            double[,] twoDimensialArray = new double[3, 4];
            Random rnd = new Random();
            double sumDar = 0f;
            double multElemDar = 1f;
            double sumOddDar = 0f;
            double maxEl = 0f;
            decimal minEl = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    twoDimensialArray[i, j] = (double)rnd.Next(1, 10) / 10;
                    Console.Write(twoDimensialArray[i, j] + "  ");
                    sumDar += (double)twoDimensialArray[i, j];
                    multElemDar *= (double)twoDimensialArray[i, j];
                    if (twoDimensialArray[i, j] > maxEl) { maxEl = (double)twoDimensialArray[i, j]; }
                    if (j % 2 != 0) { sumOddDar += twoDimensialArray[i, j]; }
                }
                Console.WriteLine();
            }

            minEl = Math.Round((decimal)twoDimensialArray[0, 0], 7);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //if (minEl > Math.Round(((decimal)twoDimensialArray[i, j]), 7)) { minEl = Math.Round(((decimal)twoDimensialArray[i, j]), 7); }
                    if (minEl > (decimal)twoDimensialArray[i, j]) { minEl = (decimal)twoDimensialArray[i, j]; }
                }
            }

            Console.WriteLine($"\nМаксимальное число в 2D - массиве: {Math.Round(maxEl, 4)}");
            Console.WriteLine($"\nМиниимальное число в 2D - массиве: {minEl}");
            Console.WriteLine($"\nСумма всех чисел в 2D - массиве: {Math.Round(sumDar, 4)}");
            Console.WriteLine($"\nПроизведение всех чисел в 2D - массиве: {multElemDar}");
            Console.WriteLine($"\nСумма всех нечётных столбцов в 2D - массиве: {Math.Round(sumOddDar, 5)}");
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_2\n\n");
            Random rnd_1 = new Random();
            int[,] tArray = new int[5, 5];
            int maxElem = 0;
            int minElem = 0;
            int sumElem = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tArray[i, j] = rnd_1.Next(-100, 100);
                    Console.Write(tArray[i, j] + "   ");
                    if (tArray[i, j] > maxElem) { maxElem = tArray[i, j]; }

                }
                Console.WriteLine();
            }
            minElem = tArray[0, 0];
            int minIndexRow = 0;
            int minIndexCol = 0;
            int maxIndexRow = 0;
            int maxIndexCol = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (minElem > tArray[i, j]) { minElem = tArray[i, j]; }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nВ полученном двумерном массиве максимальный элемент это {maxElem} , минимальный элемент это  {minElem}");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //if (minElem > tArray[i, j]) { minElem = tArray[i, j]; }
                    if (i >= minIndexRow && j >= minIndexCol && maxIndexRow >= i && maxIndexCol >= j)
                    {
                        sumElem += tArray[i, j];
                    }
                }
            }
            Console.WriteLine($"\nСумма чисел в массиве между максимальным и минимальными элементами составляет {sumElem}");
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


        tryAgain_3:
            //Пользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря.
            //Кроме механизма шифровки, реализуйте механизм расшифрования.
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_3\n\n");
            Console.WriteLine("\tВведите строку любого текста: \n");
            string textString = Console.ReadLine();
            Console.WriteLine($"\nИсходная строка: {textString}\n");
            //char[] strArray = textString.ToCharArray();
            //массив алфавита
            string allHighLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            //полный алфавит состоит из прописных и заглавных букв вместе
            string fullLetters = allHighLetters + allHighLetters.ToLower();
            //для набора шифрованной строки
            string cryptStr = "";
            //для расшифрованной строки
            string decryptStr = "";
            //ключ для кодового сдвига
            const int KEY = 3;
            //шифруем текст
            for (int i = 0; i < textString.Length; i++)
            {
                char any = textString[i];//получаем символ из строки
                int indexLetter = fullLetters.IndexOf(any);//находим его индекс в полном алфавите
                if (indexLetter < 0)
                {
                    //если в алфавите его нет т.е. его нет в алфавите - добавляем его как есть
                    cryptStr += any.ToString();
                }
                else
                {
                    //если символ строки есть в алфавите - шифруем его по формуле шифра Цезаря:
                    int cryptIndex = (fullLetters.Length + indexLetter + KEY) % fullLetters.Length;
                    cryptStr += fullLetters[cryptIndex];//контанектируем символ в строку шифрованного текста

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nЗашифрованная строка: {cryptStr}\n");
            for (int i = 0; i < cryptStr.Length; i++)
            {

                char any = cryptStr[i];//получаем символ из строки
                int indexLetter = fullLetters.IndexOf(any);//находим его индекс в строке
                if (indexLetter < 0)
                {
                    //если в строке его нет т.е. его нет в алфавите - добавляем его как есть
                    decryptStr += any.ToString();
                }
                else
                {
                    //если символ строки есть в алфавите - дешифруем его по формуле шифра Цезаря:
                    int decryptIndex = (fullLetters.Length + indexLetter - KEY) % fullLetters.Length;
                    decryptStr += fullLetters[decryptIndex];//собираем строку в расшифрованном виде
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nРасшифрованная строка: {decryptStr}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


        tryAgain_4:
            //Создайте приложение, которое производит операции над матрицами:
            //Умножение матрицы на число;
            //Сложение матриц;
            //Произведение матриц.

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_4\n\n");
            Console.WriteLine("\tУмножение матриц друг на друга: \n");
            int[,] matrix_1 = new int[3, 3];
            int[,] matrix_2 = new int[3, 3];
            int[,] resMatrix = new int[3, 3];
            Random rndM = new Random();
            Console.WriteLine("\tМатрица 1:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix_1[i, j] = rndM.Next(0, 10);
                    Console.Write("\t" + matrix_1[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tМатрица 2:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix_2[i, j] = rndM.Next(0, 10);
                    Console.Write("\t" + matrix_2[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tРезультат умножения матриц: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resMatrix[i, j] = 0;
                    for (int z = 0; z < 3; z++)
                    {
                        resMatrix[i, j] += matrix_1[i, z] * matrix_2[z, j];
                    }
                    Console.Write("\t" + resMatrix[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tРезультат сложения матриц: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resMatrix[i, j] = matrix_1[i, j] + matrix_2[i, j];
                    Console.Write("\t" + resMatrix[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            int numb = rndM.Next(1, 10);
            Console.WriteLine($"\n\tРезультат умножения матрицы (выше) на число {numb}  : \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resMatrix[i, j] *= numb;
                    Console.Write("\t" + resMatrix[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


        tryAgain_5:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_5\n\n");
            Console.WriteLine($"Введите арифметическое выражение со знаком + и/или - (например, сложить два числа): \n\n");
            string expression = Console.ReadLine();
            string[] subExpression = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numbs = new double[subExpression.Length];
            for (int i = 0; i < subExpression.Length; i++)
            {
                if (!double.TryParse(subExpression[i], out numbs[i]))
                {
                    Console.WriteLine("Ошибка ввода! Укажите корректные числа и один знак + или - ");
                    Console.ReadKey();
                    goto tryAgain_5;
                }
                Console.WriteLine(numbs[i]);
            }
            double resNumb = 0.0f;
            for (int i = 0, z = 0; i < expression.Length; i++)
            {
                if (expression[i] == '+')
                {
                    resNumb = numbs[z] + numbs[z + 1];
                    break;
                }
                if (expression[i] == '-')
                {
                    resNumb = numbs[z] - numbs[z + 1];
                    break;
                }
            }
            Console.WriteLine($"\nРезультат вычисления арифметического выражения: {resNumb}");
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


        tryAgain_6:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_6\n\n");
            Console.WriteLine("Введите отрывок текста состоящий из двух или более предложений заканчивающимися точками:\n");
            string s = Console.ReadLine();
            s = s.Replace(" ", "");
            string textExpression = s;
            if (string.IsNullOrEmpty(textExpression))
            {
                Console.WriteLine("\nОшибка! Вы не ввели текст\n");
                Console.ReadKey();
                goto tryAgain_6;
            }
            textExpression.Trim();
            char[] strArr = new char[textExpression.Length];
            strArr = textExpression.ToCharArray(0, textExpression.Length);

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i == 0) { strArr[i] = char.ToUpper(strArr[i]); }
                if (strArr[i] == '.')
                {
                    strArr[i + 1] = char.ToUpper(strArr[i + 1]);
                    continue;
                }
            }
            Console.WriteLine("\nРезультат преобразования вашего текста в предложения начинающиеся с заглавных букв: \n");
            textExpression = new string(strArr);
            Console.WriteLine(textExpression + "\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_7:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_7\n\n");
            Console.WriteLine("Отрывок текста в котором необходимо заменить слово \"To\" или \"to\" на символ \"$\" :\n");
            string[] textShakespeare = {"To be, or not to be, that is the question.",
                                        "Whether 'tis nobler in the mind to suffer",
                                        "The slings and arrows of outrageous fortune,",
                                        "Or to take arms against a sea of troubles,",
                                        "And by opposing end them? To die: to sleep;",
                                        "No more; and by a sleep to say we end",
                                        "The heart-ache and the thousand natural shocks",
                                        "That flesh is heir to, 'tis a consummation",
                                        "Devoutly to be wish'd. To die, to sleep" };

            
            for (int i = 0; i < textShakespeare.Length; i++)
            {
                Console.WriteLine(textShakespeare[i]);
            }
            Console.WriteLine("\nРезультат преобразования: \n");
       
            string subSentence = "";
            char[] letSent;
            for (int i = 0; i < textShakespeare.Length; i++)
            {
                letSent = textShakespeare[i].ToCharArray();
                for (int z = 0; z < letSent.Length; z++)
                {
                    if ((letSent[z] == 't' || letSent[z] == 'T' && letSent[z + 1] == 'o') && (letSent[z + 2] == ' ' || letSent[z + 2] == ',' || letSent[z + 2] == '.'))
                    {
                        letSent[z] = '$';
                        letSent[z + 1] = '$';
                    } else
                    {
                        continue;
                    }

                }
                subSentence = new string(letSent);
                Console.WriteLine(subSentence); 
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        } 
    }
}
