using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_19_12_22
{

    class HomeWork_19_12_22
    {
        //кол-во заданий
        int taskNumb;


        public HomeWork_19_12_22(int _taskCount)
        {
            this.taskNumb = _taskCount;
        }

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

    //////////////////////1
    class Money
    {
        string currentMoney;
        int integerNumb;
        double fractNumb;
        double resultNumb;
        string stringNumb;

        public int IntegerNumb { get; set; }
        public double FractNumb { get; set; }
        public string CurrentMoney
        { get {
                return currentMoney;
            }
            set
            {
                currentMoney = value;
                currentMoney = currentMoney.ToUpper();
                switch (currentMoney)
                {
                    case "USD":
                        currentMoney = "USD";
                        break;
                    case "RUB":
                        currentMoney = "RUB";
                        break;
                    case "EUR":
                        currentMoney = "EUR";
                        break;
                    default:
                        currentMoney = "RUB";
                        break;
                }
            }
        }
        public double ResultNumb { get; set; }
        public string StringNumb { get; set; }

        public int AddInt()
        {
            int intNumb;
        tryAgain:
            Console.WriteLine("Введите целое число цены: \n");
            if (!int.TryParse(Console.ReadLine(), out intNumb))
            {
                Console.WriteLine($"\nВы ввели некорректное число, попробуйте ещё раз!\n");
                Console.ReadKey();
                goto tryAgain;
            }
            Console.WriteLine();
            IntegerNumb = intNumb;
            return IntegerNumb;

        }
        public double AddFract()
        {
            double fractNumb;
        tryAgain:
            Console.WriteLine("Введите дробное число цены: \n");
            if (!double.TryParse(Console.ReadLine(), out fractNumb))
            {
                Console.WriteLine($"\nВы ввели некорректное число, попробуйте ещё раз!\n");
                Console.ReadKey();
                goto tryAgain;
            }
            Console.WriteLine();
            FractNumb = fractNumb;
            return FractNumb;
        }

        public double GetResultNumb()
        {
            StringNumb = IntegerNumb.ToString() + "," + FractNumb.ToString();
            double d = Convert.ToDouble(StringNumb);
            return d;
        }

    }

    class Product : Money
    {
        string productName;

        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"Продукт {ProductName}, цена: {ResultNumb} {CurrentMoney}";
        }
    }

    //////////////////////2
    public class Device
    {
        string deviceName;
        string model;


        public Device(string _deviceName, string _model)
        {
            deviceName = _deviceName;
            model = _model;
        }
        public string DeviceName {
            get
            {
                return deviceName;
            }
            set
            {
                deviceName = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string Sound()
        {
            return $"Проигрываю  ";
        }

        public string Show()
        {
            return $"Показываю  ";
        }

        public string Desc()
        {
            return $"Это: {DeviceName} устройство, модель: {Model} ";
        }

    }

    class Teapot : Device
    {

        int powerNumb;

        public Teapot(string _deviceName, string _model, int _powerNumb) : base(_deviceName, _model)
        {

            powerNumb = _powerNumb;
        }

        public int PowerNumb
        {
            get { return powerNumb; }

            set { powerNumb = value; }

        }

        public string Sound()
        {
            return $"Бульканье при кипении воды";
        }
        public string Show()
        {
            return $"Пар от кипящей воды";
        }

        public string Desc()
        {
            return $"{DeviceName} это устройство для кипячения воды, модель: №{Model}, потребляемая мощность: {PowerNumb} watt";
        }

    }

    class MicroWave : Device
    {
        //string deviceName;
        //string model;
        int powerNumb;

        public MicroWave(string _deviceName, string _model, int _powerNumb) : base(_deviceName, _model)
        {
            powerNumb = _powerNumb;
        }

        public int PowerNumb
        {
            get { return powerNumb; }

            set { powerNumb = value; }

        }

        public string Sound()
        {
            return $"Пищит во время работы";
        }
        public string Show()
        {
            return $"Светит табло во время работы";
        }

        public string Desc()
        {
            return $"{DeviceName} это устройство для разогрева еды, модель: №{Model}, потребляемая мощность: {PowerNumb} Watt";
        }
    }

    class Car : Device
    {
        int wheelNumb;
        int powerNumb;
        public Car(string _deviceName, string _model, int _powerNumb, int _wheelNumb) : base(_deviceName, _model)
        {
            wheelNumb = _wheelNumb;
            powerNumb = _powerNumb;
        }

        public int WheelNumb {
            get
            {
                return wheelNumb;
            }
            set
            {
                wheelNumb = value;
            }
        }

        public int PowerNumb
        {
            get { return powerNumb; }

            set { powerNumb = value; }

        }
        public string Sound()
        {
            return $"Шумит во время работы";
        }
        public string Show()
        {
            return $"Имеет стильный дизайн";
        }

        public string Desc()
        {
            return $"{DeviceName} это устройство для передвижения, модель: №{Model} , имееt {WheelNumb} колеса, и мощность: {PowerNumb} лошадиных сил";
        }
    }

    class Steamer : Device
    {
        int powerNumb;
        int tubeNumb;
        public Steamer(string _deviceName, string _model, int _powerNumb, int _tubeNumb) : base(_deviceName, _model)
        {
            tubeNumb = _tubeNumb;
            powerNumb = _powerNumb;
        }

        public int TubeNumb
        {
            get
            {
                return tubeNumb;
            }
            set
            {
                tubeNumb = value;
            }
        }
        public int PowerNumb
        {
            get { return powerNumb; }

            set { powerNumb = value; }

        }
        public string Sound()
        {
            return $"Гудит во время работы";
        }
        public string Show()
        {
            return $"Имеет морской дизайн";
        }

        public string Desc()
        {
            return $"{DeviceName} это устройство для передвижения по воде, модель: №{Model} , имееt {TubeNumb} трубы и мощность: {PowerNumb} Ватт";
        }
    }

    //////////////////////3
    class MusicInstrument
    {
        string instrumentName;
        string kindOfSound;

        public MusicInstrument(string _instrumentName, string _kindOfSound)
        {
            instrumentName = _instrumentName;
            kindOfSound = _kindOfSound;
        }
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }
        public string KindOfSound
        {
            get { return kindOfSound; }
            set { kindOfSound = value; }
        }

        public string Sound()
        {
            return $"{InstrumentName} издаёт звук: {KindOfSound} ";
        }

        public string Show(string _text)
        {
            string text_2 = $"{InstrumentName} выглядит как: {_text} ";
            return text_2;
        }

        public string Desc(string _text)
        {
            string text_2 = $"{InstrumentName} относится к: {_text} ";
            return text_2;
        }
        public string History(string _date)
        {
            string text_2 = $"{InstrumentName} был придуман: {_date} ";
            return text_2;
        }

    }

    class Violin : MusicInstrument
    {
        string descript;

        public Violin(string _instrumentName, string _kindOfSound, string _descript) : base(_instrumentName, _kindOfSound)
        {
            descript = _descript;
        }

        public string Descript
        {
            get { return descript; }
            set { descript = value; }
        }
    }

    class Trombone : MusicInstrument
    {
        string descript;
        string typeInstr;

        public Trombone(string _instrumentName, string _kindOfSound, string _descript, string _typeInstr) : base(_instrumentName, _kindOfSound)
        {
            descript = _descript;
            typeInstr = _typeInstr;
        }
        public string Descript
        {
            get { return descript; }
            set { descript = value; }
        }
        public string TypeInstr
        {
            get { return typeInstr; }
            set { typeInstr = value; }
        }
    }

    class Ukulele : MusicInstrument
    {
        string descript;
        string typeInstr;

        public Ukulele(string _instrumentName, string _kindOfSound, string _descript, string _typeInstr) : base(_instrumentName, _kindOfSound)
        {
            descript = _descript;
            typeInstr = _typeInstr;
        }
        public string Descript
        {
            get { return descript; }
            set { descript = value; }
        }
        public string TypeInstr
        {
            get { return typeInstr; }
            set { typeInstr = value; }
        }

    }

    class Cello : MusicInstrument
    {
        string descript;
        string typeInstr;

        public Cello(string _instrumentName, string _kindOfSound, string _descript, string _typeInstr) : base(_instrumentName, _kindOfSound)
        {
            descript = _descript;
            typeInstr = _typeInstr;
        }
        public string Descript
        {
            get { return descript; }
            set { descript = value; }
        }
        public string TypeInstr
        {
            get { return typeInstr; }
            set { typeInstr = value; }
        }

    }

    ///////////////////////4
    public abstract class Worker
    {
        string firstName;
        string lastName;
        DateTime dateBirth;
        public Worker(string _firstName, string _lastName, DateTime _dateBirth)
        {
            firstName = _firstName;
            lastName = _lastName;
            dateBirth = _dateBirth;
        }

       public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine($"\nИмя: {FirstName} \nФамилия: {LastName} \nДата рождения: {DateBirth} ");
        }

        public abstract void Activity();

    }

    class President : Worker
    {
        string companyName;
        string placeInCompany;

        public President(string _firstName, string _lastName, DateTime _dateBirth, string _companyName, string _placeInCompany) : base (_firstName, _lastName, _dateBirth)
        {
            companyName = _companyName;
            placeInCompany = _placeInCompany;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string PlaceInCompany
        {
            get { return placeInCompany; }
            set { placeInCompany = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\nНазвание компании: {CompanyName} \nДолжность в компании: {PlaceInCompany} ");
        }

        public override void Activity()
        {
            Console.WriteLine("Руководит компанией");
        }
    }

    class Security : Worker
    {
        string companyName;
        string categoryWork;
        string departmentName;

        public Security (string _firstName, string _lastName, DateTime _dateBirth, string _companyName, string _categoryWork, string _departmentName) : base(_firstName, _lastName, _dateBirth)
        {
            companyName = _companyName;
            categoryWork = _categoryWork;
            departmentName = _departmentName;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string CategoryWork
        {
            get { return categoryWork; }
            set { categoryWork = value; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\nНазвание компании: {CompanyName} \nДолжность в компании: {CategoryWork} \nотдел: {DepartmentName} ");
        }

        public override void Activity()
        {
            Console.WriteLine("Охраняет компанию");
        }
    }

    class  Manager : Worker
    {
        string departmentName;
        string categoryWork;
        string companyName;

        public Manager(string _firstName, string _lastName, DateTime _dateBirth, string _companyName, string _categoryWork, string _departmentName) : base(_firstName, _lastName, _dateBirth)
        {
            departmentName = _departmentName;
            categoryWork = _categoryWork;
            companyName = _companyName;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public string CategoryWork
        {
            get { return categoryWork; }
            set { categoryWork = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\nНазвание компании: {CompanyName} \nДолжность в компании: {CategoryWork} \nOтдел: {DepartmentName} ");
        }

        public override void Activity()
        {
            Console.WriteLine("Руководит отделом");
        }
    }

    class Engineer : Worker
    {
        string departmentName;
        string categoryWork;
        string companyName;

        public Engineer(string _firstName, string _lastName, DateTime _dateBirth, string _companyName, string _categoryWork, string _departmentName) : base(_firstName, _lastName, _dateBirth)
        {
            departmentName = _departmentName;
            categoryWork = _categoryWork;
            companyName = _companyName;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public string CategoryWork
        {
            get { return categoryWork; }
            set { categoryWork = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\nНазвание компании: {CompanyName} \nДолжность в компании: {CategoryWork} \nOтдел: {DepartmentName} ");
        }

        public override void Activity()
        {
            Console.WriteLine("Техническое обеспечение");
        }
    }



    class MainMain
    {
        static void Main(string[] args)
        {
            HomeWork_19_12_22 hm = new HomeWork_19_12_22(4);
            //Page p = new Page();
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
                                return;
                        }
                        break;
                }
            }


        tryAgain_1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");
            Console.WriteLine($" Введите сокращённую запись желаемой валюты: \"USD\", \"RUB\", \"EUR\" \n");
            string kindMoney = Console.ReadLine();
            Console.WriteLine();
            Money money = new Money();
            money.CurrentMoney = kindMoney;
            money.IntegerNumb = money.AddInt();
            money.FractNumb = money.AddFract();
            Console.WriteLine(money.GetResultNumb() + " " + money.CurrentMoney);

            Console.WriteLine("\nРеализация класса Product и его унаследованных свойств и методов:  \n");
            Console.WriteLine("Продукты до уменьшения цены: \n");
            string[] prodAr = { "Хлеб", "Водка", "Селёдка", "Папиросы", "Мыло", "Шоколад" };
            string[] kindOfMoney = {"USD", "RUB", "EUR"};
            Product[] p = new Product[5];
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Product();
                p[i].ProductName = prodAr[rnd.Next(0, 5)];
                p[i].CurrentMoney = kindOfMoney[rnd.Next(0, 2)];
                p[i].IntegerNumb = rnd.Next(50, 100);
                p[i].FractNumb = rnd.Next(50, 100);
                p[i].ResultNumb = p[i].GetResultNumb();
                Console.WriteLine(p[i]);
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПродукты после уменьшения цены: \n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < p.Length; i++)
            {
                p[i].ResultNumb -= 10;
                Console.WriteLine(p[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_2\n\n");
            Device dev = new Device(" Какое-то ", " Какая-то ");
            Console.WriteLine(dev.Sound());
            Console.WriteLine(dev.Show());
            Console.WriteLine(dev.Desc());
            Console.WriteLine("//////////////////////\n");
            Teapot tea = new Teapot("Чайник", "1111", 1000);
            Console.WriteLine(tea.Sound());
            Console.WriteLine(tea.Show());
            Console.WriteLine(tea.Desc());
            Console.WriteLine("//////////////////////\n");
            MicroWave mw = new MicroWave("Microwave", "2222", 2000);
            Console.WriteLine(mw.Sound());
            Console.WriteLine(mw.Show());
            Console.WriteLine(mw.Desc());
            Console.WriteLine("//////////////////////\n");
            Car car = new Car("SuperCar", "1212", 20000, 4);
            Console.WriteLine(car.Sound());
            Console.WriteLine(car.Show());
            Console.WriteLine(car.Desc());
            Console.WriteLine("//////////////////////\n");
            Steamer stm = new Steamer("Пароход", "3333", 20000000, 4);
            Console.WriteLine(stm.Sound());
            Console.WriteLine(stm.Show());
            Console.WriteLine(stm.Desc());

            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        tryAgain_3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_3\n\n");
            Random rnd_3 = new Random();
            MusicInstrument mus = new MusicInstrument("Какой-то", "Звук");
            Console.WriteLine(mus.Sound());
            Console.WriteLine(mus.Show("Звук"));
            Console.WriteLine(mus.Desc("Стильно"));
            Console.WriteLine(mus.History($"{rnd_3.Next(1950, 2022)}"));
            Console.WriteLine("//////////////////////\n");
            Violin vil = new Violin("Виолончель", " Протяжный писк", "Смычковый");
            Console.WriteLine(vil.Sound());
            Console.WriteLine(vil.Show("Деревянный"));
            Console.WriteLine(vil.Desc(vil.Descript));
            Console.WriteLine(vil.History($"{rnd_3.Next(1950, 2022)}"));
            Console.WriteLine("//////////////////////\n");
            Trombone tr = new Trombone("Тромбон", "Глухой стук", "Ударный", "Дерево-железо");
            Console.WriteLine(tr.Sound());
            Console.WriteLine(tr.Show(tr.TypeInstr));
            Console.WriteLine(tr.Desc(tr.Descript));
            Console.WriteLine(tr.History($"{rnd_3.Next(1950, 2022)}"));
            Console.WriteLine("//////////////////////\n");
            Ukulele uku = new Ukulele("Укулеле", "Мягкий гитарный", "Смычковый", "Дерево-струны");
            Console.WriteLine(uku.Sound());
            Console.WriteLine(uku.Show(uku.TypeInstr));
            Console.WriteLine(uku.Desc(uku.Descript));
            Console.WriteLine(uku.History($"{rnd_3.Next(1950, 2022)}"));
            Console.WriteLine("//////////////////////\n");
            Cello cel = new Cello("Скрипка", "Протяжный резкий", "Смычковый", "Дерево-струны");
            Console.WriteLine(cel.Sound());
            Console.WriteLine(cel.Show(cel.TypeInstr));
            Console.WriteLine(cel.Desc(cel.Descript));
            Console.WriteLine(cel.History($"{rnd_3.Next(1950, 2022)}"));

            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

            tryAgain_4:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_4\n\n");
            Worker president = new President("Иван", "Иванов", new DateTime(1990, 6, 12), "Газпром", "президент компании");
            president.Print();
            president.Activity();
            Console.WriteLine("//////////////////////////////////////");
            Worker security = new Security("Петр", "Петров", new DateTime(1980, 8, 18), "Газпром", "охранник", "Служба безопасности");
            security.Print();
            security.Activity();
            //Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("//////////////////////////////////////");
            Worker manager = new Manager("Семён", "Семёнов", new DateTime(1994, 5, 28), "Газпром", "менеджер", "Отдел маркетинга");
            manager.Print();
            manager.Activity();
            Console.WriteLine("//////////////////////////////////////");
            Engineer engineer = new Engineer("Максим", "Максимов", new DateTime(1982, 4, 19), "Газпром", "инженер", "Техническая служба");
            engineer.Print();
            engineer.Activity();

            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        }
    }
}

