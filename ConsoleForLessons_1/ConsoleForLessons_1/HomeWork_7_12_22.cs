using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForLessons_1
{


    class HomeWork_7_12_22
    {
        //кол-во заданий
        int taskNumb = 6;
        //создание массива меню заданий
        public string[] CreateMenu(int _taskNumb)
        {
           
            string[] menuHomeWork = new string[_taskNumb];
            for (int i = 0; i < menuHomeWork.Length; i++)
            {
                menuHomeWork[i] = "\t\t\tЗадание " + (i + 1);
                if (i == menuHomeWork.Length - 1) { menuHomeWork[i] = "\t\t\tВыход"; }
            }
            return menuHomeWork;
        }
        //доступ к кол-ву заданий
        public int GetNumb() { return taskNumb + 1; }
    }

    class Page
    {
       
        public void ShowSquare (char _ch, int _sideLength)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < _sideLength; i++)
            {
                for (int j = 0; j < _sideLength; j++)
                {
                    Console.Write(_ch + "   ");
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public bool PalinDrom(string _numbWord)
        {
            char[] fNumb = _numbWord.ToCharArray();
            for (int i = 0, j = fNumb.Length - 1; i < fNumb.Length; i++, j--)
            {
              if(fNumb[i] != fNumb[j])
                { 
                    return false;
                }
            }
            return true;
        }
        public int[] CreateArray (int _length)
        {
            int[] oriArray = new int[_length];
            Random rnd = new Random();
            for (int i = 0; i < oriArray.Length; i++)
            {
                oriArray[i] = rnd.Next(-_length, _length);
            }
            return oriArray;
        }
        public int[] CreateFilterArray(int[] _origArray)
        {
            int[] fArray = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < fArray.Length; i++)
            {
                fArray[i] = _origArray[rnd.Next(0,_origArray.Length)];//числа по индексу в оригинальном массиве
            }
            
            return fArray;
        }

        public int[] ResultArray (int[] array_1, int[] array_2)
        {
            int helpNumb = array_1.Length + array_2.Length + 1;//число-метка для фильтрации
            int z = 0;
            for (int i = 0; i < array_1.Length; i++)
            {
                for(int j = 0; j < array_2.Length; j++)
                {
                    if(array_1[i] != array_2[j]) {  continue; }
                    if(array_1[i] == array_2[j]) { array_1[i] = helpNumb;}
                }
                if(array_1[i] != helpNumb) { z++; }//считаем сколько чисел не совпадает в массивах
            }
           // Console.WriteLine(z);
            int[] zArray = new int[z];//под кол-во не одинаковых чисел выделяем массив
            for (int i = 0, j = 0; i < array_1.Length; i++)
            {
                if (array_1[i] == helpNumb) { continue; }//снова фильтруем по числу-метке
                else
                {
                    zArray[j] = array_1[i];//числа что отличаются заносим в новый массив
                    j++;
                }
            }
            return zArray;
        }

        public void ShowArray(int[] _array)
        {
            
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + "  ");
            }
        }
    }

    class MyWebSite
    {
        string siteName = "MySite";
        string pathToSitePage;
        string siteContent;
        string siteText;
        string ipAdress; 

        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; }
        }
        public string PathToSitePage { get; set; } = @"file:///E:/STEP_STUDY/LESSONS/Javascript_Lessons/DOM/Index.html";
        public string SiteContent{ get; set; } = "About animals";

        public string SiteText { get; set; }
        public string AdressIP { get; set; } = "127.0.0.1";

        public void InputContent(string _siteText) {

            _siteText = Console.ReadLine();
             SiteText = _siteText;
        }
        public void WriteContent() {

            Console.WriteLine(SiteText);
        }

    }

    class MyJournal
    {
        string journalName;
        string foundYear;
        string journalContent;
        string jornalPhone;
        string journalEmail;
        public string JournalName { get; set; } = "Modern martial arts";
        public string FoundYear { get; set; } = "19.04.1982";
        public string JournalContent { get; set; } = "About martial arts";
        public string JournalPhone { get; set; }
        string JournalEmail { get; set; }

        public void InputContact ( bool _isPnone, bool _isEmail)
        {
            string _text = "";
            if(_isPnone == true && _isEmail == false)
            {
                Console.Write("\n Введите номер телефона редакции журнала: ");
                _text = JournalPhone = Console.ReadLine();
            }
            if (_isEmail == true && _isPnone == false)
            {
                Console.Write($"\n Введите  Email адрес редакции журнала: ");
               _text = JournalEmail = Console.ReadLine();
            }
            if((_isPnone == false && _isEmail == false) || (_isPnone == true && _isEmail == true)) { _text = " Error!!!"; Console.WriteLine(_text); }
        }

        public void ShowContact ( bool _isPnone, bool _isEmail)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string _text;
            if (_isPnone && !_isEmail)
            {
                Console.WriteLine($"\n Номер телефона редакции журнала: {_text = JournalPhone}\n");
            }
            if (_isEmail && !_isPnone)
            {
                Console.WriteLine($" Email адрес редакции журнала: {_text = JournalEmail}\n");
            }
            if ((!_isPnone && !_isEmail) || (_isPnone && _isEmail)) { Console.WriteLine(_text = " Error!!!"); }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }

    class MyShop
    {
        string shopName;
        string foundYear;
        string shopContent;
        string shopPhone;
        string shopEmail;
        public string ShopName { get; set; } = "Book Shop";
        public string FoundYear { get; set; } = "19.04.1982";
        public string ShopContent { get; set; } = "books";
        public string ShopPhone { get; set; }
        string ShopEmail { get; set; }

        public void InputContact(string _thatIsThis, bool _isPnone, bool _isEmail)
        {
            string _text = "";
            if (_isPnone == true && _isEmail == false)
            {
                Console.Write("\n Введите номер телефона " + (_thatIsThis) + "a: ");
                _text = ShopPhone = Console.ReadLine();
            }
            if (_isEmail == true && _isPnone == false)
            {
                Console.Write($"\n Введите  Email адрес {_thatIsThis}a: ");
                _text = ShopEmail = Console.ReadLine();
            }
            if ((_isPnone == false && _isEmail == false) || (_isPnone == true && _isEmail == true)) { _text = " Error!!!"; Console.WriteLine(_text); }
        }

        public void ShowContact(string _thatIsThis, bool _isPnone, bool _isEmail)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string _text;
            if (_isPnone && !_isEmail)
            {
                Console.WriteLine($"\n Номер телефона {_thatIsThis}a : {_text = ShopPhone}\n");
            }
            if (_isEmail && !_isPnone)
            {
                Console.WriteLine($" Email адрес {_thatIsThis}a: {_text = ShopEmail}\n");
            }
            if ((!_isPnone && !_isEmail) || (_isPnone && _isEmail)) { Console.WriteLine(_text = " Error!!!"); }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }

    class MainMain {
        static void Main(string[] args)
        {
        HomeWork_7_12_22 hm = new HomeWork_7_12_22();
        Page p = new Page();
        Random rnd = new Random();
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
                string[] tasks = hm.CreateMenu(hm.GetNumb());
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
                        if (index < tasks.Length - 1)
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
                                return;
                            case 7:
                                return;
                        }
                        break;
                }
            }


        tryAgain_1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");
            Console.WriteLine($"Введите численное значение длины стороны квадрата (не более 50-и): \n");
            int sqrLength;
            if ((!int.TryParse(Console.ReadLine(), out sqrLength)) || sqrLength > 50)
            {
                Console.WriteLine("Ошибка ввода! Укажите корректное число ");
                Console.ReadKey();
                goto tryAgain_1;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Введите символ из которого будет состоять квадрат: \n");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Console.WriteLine("\n");
            if(ch.Length > 1) 
            { 
                Console.WriteLine("Ошибка ввода! Введите только один символ!!! ");
                Console.ReadKey();
                goto tryAgain_1;
            }
            p.ShowSquare(ch[0], sqrLength);
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

           tryAgain_2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_2\n\n");
            Console.WriteLine($"Введите число для проверки на палиндромность: \n");
            int plnNumb;
            if (!int.TryParse(Console.ReadLine(), out plnNumb))
            {
                Console.WriteLine("Ошибка ввода! Укажите корректное число ");
                Console.ReadKey();
                goto tryAgain_2;
            }
            if(p.PalinDrom(plnNumb.ToString()) == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n Число {plnNumb} является палиндромом! \n");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Число {plnNumb} не является палиндромом! \n");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


            tryAgain_3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_3\n\n");
            int[] origArray = p.CreateArray(15);
            Console.WriteLine("Оригинальный массив: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            p.ShowArray(origArray);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Массив с числами для фильтрации: \n");
            int[] filterArray = p.CreateFilterArray(origArray);
            Console.ForegroundColor = ConsoleColor.Green;
            p.ShowArray(filterArray);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Массив с числами после фильтрации: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            p.ShowArray(p.ResultArray(origArray,filterArray));
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;




            tryAgain_4:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_4\n\n");
            MyWebSite mw = new MyWebSite();
            Console.WriteLine($"Введите строку текста для сайта \"{mw.SiteName}\": \n");
            mw.SiteText = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"На главной странице сайта \"{mw.SiteName}\" ваш текст: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            mw.WriteContent();
            Console.WriteLine();
            Console.WriteLine($"Содержание сайта: \"{mw.SiteContent}\" \n");
            Console.WriteLine();
            Console.WriteLine($"Адрес страницы сайта: \"{mw.PathToSitePage}\" \n");
            Console.WriteLine();
            Console.WriteLine($"IP-адрес сайта: \"{mw.AdressIP}\" \n");
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;


            tryAgain_5:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_5\n\n");
            MyJournal mj = new MyJournal();
            Console.WriteLine($" Ваш журнал {mj.JournalName}:\n");
            Console.WriteLine();
            Console.WriteLine($" Посвящён темам: {mj.JournalContent}\n");
            Console.WriteLine();
            Console.WriteLine($" Дата основания журнала: {mj.FoundYear} \n");
            mj.InputContact(true, false);
            mj.InputContact(false, true);
            mj.ShowContact(true, false);
            mj.ShowContact(false, true);
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

            tryAgain_6:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_6\n\n");
            MyShop ms = new MyShop();
            Console.WriteLine($" Ваш магазин {ms.ShopName}:\n");
            Console.WriteLine();
            Console.WriteLine($" Посвящён темам: {ms.ShopContent}\n");
            Console.WriteLine();
            Console.WriteLine($" Дата основания магазина: {ms.FoundYear} \n");
            ms.InputContact("магазин",true, false);
            ms.InputContact("магазин", false, true);
            ms.ShowContact("магазин", true, false);
            ms.ShowContact("магазин", false, true);
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;
        }

    }
}
