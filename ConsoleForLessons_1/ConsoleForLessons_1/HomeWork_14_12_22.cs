using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_14_02_22
{

    class HomeWork_14_12_22
    {
        //кол-во заданий
        int taskNumb = 3;
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
        public string SiteContent { get; set; } = "About animals";

        public string SiteText { get; set; }
        public string AdressIP { get; set; } = "127.0.0.1";

        public void InputContent(string _siteText)
        {

            _siteText = Console.ReadLine();
            SiteText = _siteText;
        }
        public void WriteContent()
        {

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
        int numberWorkers;
        public string JournalName { get; set; } = "Modern martial arts";
        public string FoundYear { get; set; } = "19.04.1982";
        public string JournalContent { get; set; } = "About martial arts";
        public string JournalPhone { get; set; }
        string JournalEmail { get; set; }

        public int NumbWorkers { get; set; } = new Random().Next(50, 100);

        public void InputContact(bool _isPnone, bool _isEmail)
        {
            string _text = "";
            if (_isPnone == true && _isEmail == false)
            {
                Console.Write("\n Введите номер телефона редакции журнала: ");
                _text = JournalPhone = Console.ReadLine();
            }
            if (_isEmail == true && _isPnone == false)
            {
                Console.Write($"\n Введите  Email адрес редакции журнала: ");
                _text = JournalEmail = Console.ReadLine();
            }
            if ((_isPnone == false && _isEmail == false) || (_isPnone == true && _isEmail == true)) { _text = " Error!!!"; Console.WriteLine(_text); }
        }

        public void ShowContact(bool _isPnone, bool _isEmail)
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

        public static int operator +(MyJournal _mj, int _z)
        {
            return _mj.NumbWorkers += _z;
        }

        public static int operator -(MyJournal _mj, int _z)
        {
            return _mj.NumbWorkers -= _z;
        }
        public static bool operator ==(MyJournal _mj, MyJournal _mj_1)
        {
            return _mj.NumbWorkers == _mj_1.NumbWorkers ? true : false;
        }
        public static bool operator !=(MyJournal _mj, MyJournal _mj_1)
        {
            return _mj.NumbWorkers != _mj_1.NumbWorkers ? true : false;
        }
        public static bool operator >(MyJournal _mj, MyJournal _mj_1)
        {
            return _mj.NumbWorkers > _mj_1.NumbWorkers ? true : false;
        }
        public static bool operator <(MyJournal _mj, MyJournal _mj_1)
        {
            return _mj.NumbWorkers < _mj_1.NumbWorkers ? true : false;
        }
        //// переопределение метода Equals
        //public override bool Equals(object obj)
        //{
        //    return this.ToString() == obj.ToString();
        //}
        //// необходимо также переопределить метод
        //// GetHashCode
        //public override int GetHashCode()
        //{
        //    return this.ToString().GetHashCode();
        //}
    }

    class MyShop
    {
        string shopName;
        string foundYear;
        string shopContent;
        string shopPhone;
        string shopEmail;
        int sqrNumb;
        public string ShopName { get; set; } = "Book Shop";
        public string FoundYear { get; set; } = "19.04.1982";
        public string ShopContent { get; set; } = "books";
        public string ShopPhone { get; set; }
        string ShopEmail { get; set; }

        public int SqrNumb { get; set; } = new Random().Next(50, 100);

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

        public static int operator +(MyShop _msh, int _z)
        {
            return _msh.SqrNumb += _z;
        }

        public static int operator -(MyShop _msh, int _z)
        {
            return _msh.SqrNumb -= _z;
        }
        public static bool operator ==(MyShop _msh, MyShop _msh_1)
        {
            return _msh.SqrNumb == _msh_1.SqrNumb ? true : false;
        }
        public static bool operator !=(MyShop _msh, MyShop _msh_1)
        {
            return _msh.SqrNumb != _msh_1.SqrNumb ? true : false;
        }
        public static bool operator >(MyShop _msh, MyShop _msh_1)
        {
            return _msh.SqrNumb > _msh_1.SqrNumb ? true : false;
        }
        public static bool operator <(MyShop _msh, MyShop _msh_1)
        {
            return _msh.SqrNumb < _msh_1.SqrNumb ? true : false;
        }


    }

    class BookApp
    {
        BookUnit[] bookArr;

        public BookUnit BookArr { get; set; }

        public int Length { get { return bookArr.Length; } }

        //
        public BookApp(int _sizeArr)
        {

            if (_sizeArr >= 0)
            {
                bookArr = new BookUnit[_sizeArr];

            }
            else { throw new IndexOutOfRangeException(); }
        }
        //
        public BookUnit this[int _index]
        {

            get
            {
                if (_index >= 0 && _index <
                bookArr.Length)
                {
                    return bookArr[_index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (_index >= 0 && _index <
                bookArr.Length)
                {
                    bookArr[_index] = value;
                }
            }
        }


        public static int operator +(BookApp _bk, int _addPrice)
        {
            return _bk.BookArr.Price += _addPrice;
        }
        public static int operator -(BookApp _bk, int _removePrice)
        {
            return _bk.BookArr.Price -= _removePrice;
        }

        public void AddBook (Random _rnd)
        {
            Array.Resize(ref bookArr, Length + 1);
            bookArr[Length - 1] = new BookUnit();

            Console.WriteLine("\nДобавление новой книги в каталог: \n");
            Console.Write("Введите имя и фамилию автора книги: ");
            bookArr[Length - 1].Author = Console.ReadLine();
            Console.Write("\nВведите название книги: ");
            bookArr[Length - 1].Title = Console.ReadLine();
            Console.WriteLine();
            bookArr[Length - 1].PublishYear = _rnd.Next(1950, 2022);
            bookArr[Length - 1].Price = _rnd.Next(150, 300);
        }

        
    }


    class ArrForRand
    {
        public string[] nameArr = { "Фрэнк", " Айзек", "Фрэнсис", "Станислав", "Фёдор", "Чарльз", "Александр" };
        public string[] surnameAr = { "Герберт", " Азимов", "Фукуяма", "Лем", "Достоевский", "Буковски", "Пушкин" };
        public string[] titleAr = { "Дюна", " Академия", "Солярис", "Дьяболо", "Цезарь", "Буковски", "Пространство" };

        public string NameArr { get; set; }  
        public string SurnameAr { get; set; }
        public string TitleAr { get; set; }
    }
    
    class BookUnit
    {
       string author;
       string title;
       int publishYear;
       int price;

        public string Author { get; set; } 
        public string Title { get; set; } 
        public int PublishYear { get; set; } 
        public int Price { get; set; } 

        public override string ToString()
        {
            return $" Автор: {Author},  Название: {Title}, год выхода: {PublishYear}, цена: {Price}";
        }
    }


    class MainMain
    {
        static void Main(string[] args)
        {
            HomeWork_14_12_22 hm = new HomeWork_14_12_22();
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
                                return;
                        }
                        break;
                }
            }


        tryAgain_1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");
            MyJournal mj = new MyJournal();
            MyJournal mj_1 = new MyJournal();
            Console.WriteLine("Пример перегрузки знака \" + \" : ");
            int x = rnd.Next(1, 50);
            Console.WriteLine($"\nЧисло сотрудников журнала {mj.JournalName} увеличилось с {mj.NumbWorkers} человек, случайно до {mj + x} человек \n");
            Console.WriteLine("Пример перегрузки знака \" - \" : ");
            int z = rnd.Next(1, 50);
            Console.WriteLine($"\nЧерез месяц число сотрудников журнала {mj.JournalName} совершенно случайно уменьшилось с {mj.NumbWorkers},  до {mj - z} человек \n");
            Console.WriteLine("\nПример перегрузки знака \" == \" : ");
            Console.WriteLine($"\nВ первом журнале работает  {mj.NumbWorkers} сотрудников, во втором {mj_1.NumbWorkers}, результат их сравнения на равенство: {mj == mj_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" != \" : ");
            Console.WriteLine($"\nВ первом журнале работает  {mj.NumbWorkers} сотрудников, во втором {mj_1.NumbWorkers}, результат их сравнения на неравенство: {mj != mj_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" > \" : ");
            Console.WriteLine($"\nВ первом журнале работает  {mj.NumbWorkers} сотрудников, во втором {mj_1.NumbWorkers}, результат их сравнения на знак > : {mj > mj_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" < \" : ");
            Console.WriteLine($"\nВ первом журнале работает  {mj.NumbWorkers} сотрудников, во втором {mj_1.NumbWorkers}, результат их сравнения на знак < : {mj < mj_1}\n");
            Console.WriteLine("\nПример использования метода \" Equals() \" : ");
            MyJournal mj_2 = mj_1;
            Console.WriteLine($" \nmj_2.Equals(mj_1) : {mj_2.Equals(mj_1)}\n");
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_2\n\n");
            MyShop msh = new MyShop();
            MyShop msh_1 = new MyShop();
            Console.WriteLine("Пример перегрузки знака \" + \" : ");
            int y = rnd.Next(1, 50);
            Console.WriteLine($"\n Площадь магазина  {msh.SqrNumb} метра до, и {msh + y} метра после увеличения на случайную величину \n");
            Console.WriteLine("Пример перегрузки знака \" - \" : ");
            int n = rnd.Next(1, 50);
            Console.WriteLine($"\n Площадь магазина  {msh.SqrNumb} метра до, и {msh - n} метра после уменьшения на случайную величину \n");
            Console.WriteLine("\nПример перегрузки знака \" == \" : ");
            Console.WriteLine($"\nВ первом магазине площадь {msh.SqrNumb} метров, во втором {msh_1.SqrNumb} метров, результат их сравнения на равенство: {msh == msh_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" != \" : ");
            Console.WriteLine($"\nВ первом магазине площадь {msh.SqrNumb} метров, во втором {msh_1.SqrNumb} метров, результат их сравнения на неравенство: {msh != msh_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" > \" : ");
            Console.WriteLine($"\nВ первом магазине площадь {msh.SqrNumb} метров, во втором {msh_1.SqrNumb} метров, результат их сравнения на > : {msh > msh_1}\n");
            Console.WriteLine("\nПример перегрузки знака \" < \" : ");
            Console.WriteLine($"\nВ первом магазине площадь {msh.SqrNumb} метров, во втором {msh_1.SqrNumb} метров, результат их сравнения на < : {msh < msh_1}\n");
            Console.WriteLine("\nПример использования метода \" Equals() \" : ");
            MyShop msh_2 = msh_1;
            Console.WriteLine($" \nmsh_2.Equals(msh_1) : {msh_2.Equals(msh_1)}\n");
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_3\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\tПриложение \"Книги\" для прочтения: \n");
           
            Console.WriteLine("Первоначальный список книг: \n");
            
            BookApp bar = new BookApp(5);
            ArrForRand ars = new ArrForRand();
            Random rand = new Random();
            for (int i = 0; i < bar.Length; i++)
            {
                bar[i] = new BookUnit();
                bar[i].Author = ars.nameArr[rand.Next(0, 6)] + " " + ars.surnameAr[rand.Next(0, 6)];
                bar[i].Title = ars.titleAr[rand.Next(1, 6)];
                bar[i].PublishYear = rand.Next(1960, 2022);
                bar[i].Price = rand.Next(50, 250);
                Console.WriteLine(bar[i]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПосле добавления цены на 10 руб на все книги\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < bar.Length; i++)
            {
                bar[i].Price += 10;
                Console.WriteLine(bar[i]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            bar.AddBook(rand);
            for (int i = 0; i < bar.Length; i++)
            {
                Console.WriteLine(bar[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        }
    }
}
