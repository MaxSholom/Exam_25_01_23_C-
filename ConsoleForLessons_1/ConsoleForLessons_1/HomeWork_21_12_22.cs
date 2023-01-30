//using Windows.UI.Xaml.Controls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_21_12_22
{
    class HomeWork_21_12_22
    {
        //кол-во заданий
        int taskNumb;


        public HomeWork_21_12_22(int _taskCount)
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

    //Задание 1. Реализовать программу “Строительство дома”

    //HOUSE
    interface IPart
    {
        void Build (int _part, string _partName);
    }
    //WORKER
    interface IWorker
    {
        string Name();
        bool CheckBuild(int _partOfHouse);
    }



    //HOUSE
    class House : IPart
    {
        int houseProject;
        int basement;
        int wall;
        int doors;
        int windows;
        int roof;
        string partName;

        public int HouseProject
        {
            get { return houseProject; }
            set { houseProject = value; }
        }

        public int BaseMent
        {
            get { return basement; }
            set { basement = value; }
        }

        public int Wall
        {
            get { return wall; }
            set { wall = value; }
        }

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        public int Windows
        {
            get { return windows; }
            set { windows = value; }
        }

        public int Roof
        {
            get { return roof; }
            set { roof = value; }
        }
        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

        void IPart.Build(int _part, string _partName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_part} {_partName} построен, и состоит из:\n");
            Console.WriteLine($"Фундамент: {BaseMent}");
            Console.WriteLine($"Стены: {Wall}");
            Console.WriteLine($"Двери: {Doors}");
            Console.WriteLine($"Окна: {Windows}");
            Console.WriteLine($"Крыша: {Roof}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }

    class BaseMent : House, IPart
    {
       
        string baseName;

        public BaseMent(string _baseName) : base ()
        {
            this.baseName = _baseName;
        }

        public string Basename
        {
            get { return baseName; }
            set { baseName = value; }
        }


        void IPart.Build(int _part, string _partName)
        {
            Console.WriteLine($"{_partName} установлен в количестве: {_part}\n");
        }
    }

    class Walls : House, IPart
    {
        string wallName;
        public Walls(string _wallName) : base()
        {
            this.wallName = _wallName;
        }
        public string Wallname
        {
            get { return wallName; }
            set { wallName = value; }
        }


        void IPart.Build(int _part, string _partName)
        {
            Console.WriteLine($"{_partName} установлены в количестве: {_part}\n");
        }
    }

    class Door : House, IPart
    {
        string doorsName;
        public Door (string _doorsName) : base()
        {
            this.doorsName = _doorsName;
        }
        public string DoorsName
        {
            get { return doorsName; }
            set { doorsName = value; }
        }
        void IPart.Build(int _part, string _partName)
        {
            Console.WriteLine($"{_partName} установлены в количестве: {_part}\n");
        }
    }

    class Window : House, IPart
    {
        string windowsName;
        public Window (string _windowsName) : base()
        {
            this.windowsName = _windowsName;
        }

        public string WindowsName
        {
            get { return windowsName; }
            set { windowsName = value; }
        }
        void IPart.Build(int _part, string _partName)
        {
            Console.WriteLine($"{_partName} установлены в количестве: {_part}\n");
        }
    }

    class Roof : House, IPart
    {
        string roofName;
        public Roof(string _roofName) : base()
        {
            this.roofName = _roofName;
        }
        public string RoofName
        {
            get { return roofName; }
            set { roofName = value; }
        }
        void IPart.Build(int _part, string _partName)
        {
            Console.WriteLine($"{_partName} установлена в количестве: {_part}\n");
        }
    }

    //WORKER

    class Team : IWorker
    {
        int teamCount;
        string teamName;
        public int TeamCount
        {
            get { return teamCount; }
            set { teamCount = value; }
        }
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        bool IWorker.CheckBuild(int _partOfHouse)
        {
            if (_partOfHouse > 0) { return true; }
            else { return false; }
        }

        string IWorker.Name()
        {
            return this.TeamName;
        }
    }

    class Workers : Team, IWorker
    {
        //int teamCount;
        string workerName;

        public Workers ( string _workerName) : base ()
        {
            
            this.workerName = _workerName;
        }
        

        public string WorkerName
        {
            get { return workerName; }
            set { workerName = value; }
        }

        bool IWorker.CheckBuild(int _partOfHouse)
        {
            if(_partOfHouse > 0) { return true; }
            else { return false; }
        }

        string IWorker.Name()
        {
            return this.WorkerName;
        }
        
    }

    class TeamLeader : Team, IWorker
    {
        string leaderName;
        public TeamLeader( string _leaderName) : base()
        {
            this.leaderName = _leaderName;
        }
        public string LeaderName
        {
            get { return leaderName; }
            set { leaderName = value; }
        }

        internal void CheckReport (Team _workTeam)
        {
            IWorker worker = _workTeam;//интерфейсная ссылка позволяет обратиться только к методам содержащимся в интерфейсе IWorker
            Console.WriteLine($"Отчёт {this.LeaderName}: {worker.Name()} в составе {_workTeam.TeamCount} работников, выполнили: ");
        }

        bool IWorker.CheckBuild(int _partOfHouse)
        {
            if (_partOfHouse > 0) { return true; }
            else { return false; }
        }
        string IWorker.Name()
        {
            return this.LeaderName;
        }
    }






    class MainMain
    {
        static void Main(string[] args)
        {
            HomeWork_21_12_22 hm = new HomeWork_21_12_22(1);
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
                            //case 1:
                            //    goto tryAgain_2;
                            //case 2:
                            //    goto tryAgain_3;
                            //case 3:
                            //    goto tryAgain_4;
                            case 1:
                                return;
                        }
                        break;
                }
            }

        tryAgain_1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tЗАДАНИЕ_1\n\n");
            Console.WriteLine("Особенностью строительства является наличие проверки предыдущего этапа строительства\n");
            House newHouse = new House();
            newHouse.HouseProject = 1;//у дома появляется проект
            newHouse.PartName = "Дом";
            IPart houseI = newHouse;
            Team newTeam = new Team();
            newTeam.TeamName = "Бригада строителей";
            TeamLeader newLeader = new TeamLeader("Бригадир");

            //СТРОИМ ФУНДАМЕНТ
            Workers baseWorkers = new Workers("Монолитчики");
            BaseMent newBase = new BaseMent("Фундамент");
            IPart baseI = newBase;//интерфейсная ссылка на обьект-фундамент
            IWorker baseworkI = baseWorkers;//интерфейсная ссылка на бригаду монолитчиков для проверки строительства
            //если дом имеет проект - начинаем строительство
            if (baseworkI.CheckBuild(newHouse.HouseProject))
            {
                baseWorkers.TeamCount = 4;
                newBase.BaseMent = 1;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Дом не имеет проекта - пока рано строить");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadKey();
                goto tryAgain_1;
            }
            newLeader.CheckReport(baseWorkers);//вызываем отчёт о проделанной работе от бригадира
            baseI.Build(newBase.BaseMent, newBase.Basename);//через интерф.ссылку вызываем метод отчёта
            newHouse.BaseMent = newBase.BaseMent;//сам дом получает фундамент 

            //СТРОИМ СТЕНЫ
            Workers wallWorkers = new Workers("Установщики стен");
            Walls newWalls = new Walls("Стены");
            IPart wallI = newWalls;//интерфейсная ссылка на обьект-стены
            IWorker wallworkI = wallWorkers;//интерфейсная ссылка на обьект монолитчиков для проверки строительства
            //если дом имеет фундамент
            if (wallworkI.CheckBuild(newHouse.BaseMent))
            {
                wallWorkers.TeamCount = 4;
                newWalls.Wall = 4;
            }
            else { Console.WriteLine("Дом не имеет фундамента - пока рано строить"); }
            newLeader.CheckReport(wallWorkers);//вызываем отчёт о проделанной работе от бригадира
            wallI.Build(newWalls.Wall, newWalls.Wallname);//через интерф.ссылку вызываем метод отчёта
            newHouse.Wall = newWalls.Wall;//сам дом получает стены 

            //СТРОИМ ДВЕРИ
            Workers doorWorkers = new Workers("Монтажники дверей");
            Door newDoor = new Door("Двери");
            IPart doorI = newDoor;//интерфейсная ссылка на обьект-двери
            IWorker doorworkI = doorWorkers;//интерфейсная ссылка на обьект монтажников дверей для проверки строительства
            //если дом имеет стены
            if (doorworkI.CheckBuild(newHouse.Wall))
            {
                doorWorkers.TeamCount = 2;
                newDoor.Doors = 1;
            }
            else { Console.WriteLine("Дом не имеет стен - пока рано строить"); }
            newLeader.CheckReport(doorWorkers);//вызываем отчёт о проделанной работе от бригадира
            doorI.Build(newDoor.Doors, newDoor.DoorsName);//через интерф.ссылку вызываем метод отчёта
            newHouse.Doors = newDoor.Doors;//сам дом получает двери

            //СТРОИМ ОКНА
            Workers windowsWorkers = new Workers("Монтажники окон");
            Window newWindow = new Window("Окна");
            IPart windI = newWindow;//интерфейсная ссылка на обьект-двери
            IWorker windworkI = windowsWorkers;//интерфейсная ссылка на обьект монтажников дверей для проверки строительства
            //если дом имеет двери
            if (windworkI.CheckBuild(newHouse.Doors))
            {
                windowsWorkers.TeamCount = 2;
                newWindow.Windows = 4;
            }
            else { Console.WriteLine("Дом не имеет дверей - пока рано строить"); }
            newLeader.CheckReport(windowsWorkers);//вызываем отчёт о проделанной работе от бригадира
            windI.Build(newWindow.Windows, newWindow.WindowsName);//через интерф.ссылку вызываем метод отчёта
            newHouse.Windows = newWindow.Windows;//сам дом получает двери

            //СТРОИМ КРЫШУ
            Workers roofWorkers = new Workers("Кровельщики");
            Roof newRoof = new Roof("Крыша");
            IPart roofI = newRoof;//интерфейсная ссылка на обьект-крыша
            IWorker roofworkI = roofWorkers;//интерфейсная ссылка на обьект кровельщиков для проверки строительства
            //если дом имеет окна
            if (roofworkI.CheckBuild(newHouse.Windows))
            {
                roofWorkers.TeamCount = 2;
                newRoof.Roof = 1;
            }
            else { Console.WriteLine("Дом не имеет окон - пока рано строить"); }
            newLeader.CheckReport(roofWorkers);//вызываем отчёт о проделанной работе от бригадира
            roofI.Build(newRoof.Roof, newRoof.RoofName);//через интерф.ссылку вызываем метод отчёта
            newHouse.Roof = newRoof.Roof;//сам дом получает крышу

            newTeam.TeamCount = baseWorkers.TeamCount + wallWorkers.TeamCount + doorWorkers.TeamCount + windowsWorkers.TeamCount + roofWorkers.TeamCount;
            IWorker teamI = newTeam;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            newLeader.CheckReport(newTeam);//вызываем отчёт о проделанной работе от бригадира
            houseI.Build(newHouse.HouseProject, newHouse.PartName);

            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        }

    }
}

