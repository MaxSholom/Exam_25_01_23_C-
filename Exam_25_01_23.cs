using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exam_25_01_23
{
    //class Exam_25_01_23
    //{
    //    //кол-во заданий
    //    int taskNumb;


    //    public Exam_25_01_23(int _taskCount)
    //    {
    //        this.taskNumb = _taskCount;
    //    }

    //    public int TaskNumb
    //    { get { return taskNumb; }
    //        set { taskNumb = value; }
    //    }


    //    //создание массива меню заданий
    //    public string[] CreateMenu(int _taskNumb)
    //    {

    //        string[] menuHomeWork = new string[_taskNumb];
    //        for (int i = 0; i < menuHomeWork.Length; i++)
    //        {
    //            menuHomeWork[i] = "\t\t\tЗадание " + (i + 1);
    //            if (i == menuHomeWork.Length - 1) { menuHomeWork[i] = "\t\t\tВыход"; }
    //        }
    //        return menuHomeWork;
    //    }
    //    //доступ к кол-ву заданий
    //    public int GetNumb() { return taskNumb + 1; }
    //}

    class SubMenu
    {
        List<string> itemName;
        string itemText;
        int itemNumb;
        public SubMenu(List<string> _itemName)
        {
            this.itemName = _itemName;
        }
        public List<string> ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public string ItemText
        {
            get { return itemText; }
            set { itemText = value; }
        }
        public int ItemNumb
        {
            get { return itemNumb; }
            set { itemNumb = value; }
        }
        
        public void ShowSelectMenu(bool _isVertical)
        {
            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            bool isLoop = true;
            while (isLoop)
            {
                Console.SetCursorPosition(col, row);
                for (int i = 0; i < ItemName.Count; i++)
                {
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (_isVertical == true)
                    {
                        Console.WriteLine($"\t{ItemName[i]}\n");//для вертикального меню отображает пункты
                    }
                    else
                    {
                        Console.Write($"\t{ItemName[i].ToUpper()}");//для горизонтального отображения пунктов
                    }
                    Console.ResetColor();
                }
                if (_isVertical == true)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (index < ItemName.Count - 1)
                                index++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (index > 0)
                                index--;
                            break;
                        case ConsoleKey.Enter:
                            //Console.Clear();
                            //Console.ForegroundColor = ConsoleColor.DarkYellow;
                            //Console.WriteLine($"\t\t\t{ItemName[index].ToUpper()}\n");//отображает строку новой страницы - т.е. задание №....
                            //Console.ForegroundColor = ConsoleColor.White;
                            this.ItemNumb = index;
                            isLoop = false;
                            break;
                    }
                }
                else
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.RightArrow:
                            if (index < ItemName.Count - 1)
                                index++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (index > 0)
                                index--;
                            break;
                        case ConsoleKey.Enter:
                            this.ItemNumb = index;
                            isLoop = false;
                            break;
                    }
                }
            }
        }
    }

    class Page
    {
        public void ShowPageMenu (List<string> _textHeader)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{_textHeader[0]}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{_textHeader[1]}");
        }

        public void ShowPage(List<string> _textContent)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_textContent[0]);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public enum Langs {ENG_RUS = 0, RUS_ENG = 1}

    //
    public delegate void SubMenuMethods (int _item);

    

    class MyDiction
    {
        string descript;
        List<string> translateList = new List<string>();//опорный список перевода слова
        //сам словарь
        Dictionary<string, List<string>> diction = new Dictionary<string, List<string>>();
        
        
        public string Descript
        {
            get { return descript; }
            set { descript = value; }
        }

        public Dictionary<string, List<string>> Diction
        {
            get { return diction; }
            set { diction = value; }
        }

        public List<string> TranslateList
        {
            get { return translateList; }
            set { translateList = value; }
        }

        public void ShowDiction()
        {
            foreach (KeyValuePair<string, List<string>> elem in this.Diction)
            {
                Console.Write($"В англо-русском словаре английскому слову \"{elem.Key}\"  соответствуют русские слова: ");
                foreach (var li in elem.Value)
                {
                    Console.Write($"\"{li}\" ");
                }
                Console.WriteLine();
            }
        }

        //добавление слова в словарь
        public void AddWord(int _lang)
        {
            switch (_lang) {   //выбираем языковый тип словаря
                case (int)Langs.ENG_RUS:
                    bool isFullAdd = false;
                    bool isPartAdd = false;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nЕсли хотите добавить английское слово и его перевод на русском  нажмите: \"1\"");
                    Console.WriteLine("\nЕсли просто добавить русский перевод слова нажмите: \"0\" \n");
                    var keyType = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                    switch (keyType)
                    {
                        case ConsoleKey.D1:
                            isFullAdd = true;
                            break;
                        case ConsoleKey.D0:
                            isPartAdd = true;
                            break;
                        default:
                            isFullAdd = true;
                            break;
                    }
                    //если добавляем слово и его перевод
                    if (isFullAdd)
                    {
                        string wordBasic;//опорная переменная
                        List<string> wordTranslateList = new List<string>();//опорный список перевода слова
                    tryAgain:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nВведите слово на английском языке: \n");
                        wordBasic = Console.ReadLine();
                        //Проверка на наличие слова в словаре
                        foreach (var word in this.Diction)
                        {
                            if (word.Key == wordBasic)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Слово: {word.Key} уже есть в словаре, попробуйте добавить другое слово");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                goto tryAgain;
                            }
                        }
                        //с помощью регулярных выражений создаём проверку: "^[a-zA-Z0-9]*$" соответсвует 
                        //тому что в исходной строке может быть любой символ английского алфавита кроме цифр 
                        //Метод Matches класса Regex принимает строку,
                        //к которой надо применить регулярные выражения, и возвращает коллекцию найденных совпадений.
                        if (!(Regex.IsMatch(wordBasic, "^[a-zA-Z^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на английском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryAgain;
                        }

                    tryTranslate:
                        Console.WriteLine("\nВведите перевод слова на русском языке: \n");
                        string wordOffTrans = Console.ReadLine();
                        //проверка на кириллицу
                        if (Regex.IsMatch(wordOffTrans, "^[а-яА-Я^0-9]*$"))
                        {
                            TranslateList.Add(wordOffTrans);//добавляем в локальный список новый перевод
                            Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                            var keyInfo = Console.ReadKey().Key;
                            switch (keyInfo)
                            {
                                case ConsoleKey.D1:
                                    goto tryTranslate;
                                case ConsoleKey.D0:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nВы добавили перевод не на русском языке, попробуйте ещё раз!\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryTranslate;
                        }
                        //и наконец-то добавляем в словарь слово на английском и список с его переводами на русском
                        this.Diction.Add(wordBasic, TranslateList);
                    }
                    if (isPartAdd)
                    {
                    tryFindWord:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\t\tВведите английское слово для которого хотите добавить перевод:\n\n");
                        string wordPartBasic;
                        wordPartBasic = Console.ReadLine();

                        //Проверка на англоязычность
                        if (!(Regex.IsMatch(wordPartBasic, "^[a-zA-Z^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на английском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryFindWord;
                        }

                        //если слово найдено и ранее проверено на англоязычность
                        if (this.Diction.ContainsKey(wordPartBasic))
                        {

                        tryTranslatePart:
                            Console.WriteLine("\nВведите перевод слова на русском языке: \n");
                            string wordTrans = Console.ReadLine();
                            //проверка на кириллицу
                            if (Regex.IsMatch(wordTrans, "^[а-яА-Я^0-9]*$"))
                            {
                                //ищем по ключу в словаре нужное
                                foreach (var word in this.Diction)
                                {
                                    if (word.Key == wordPartBasic)
                                    {
                                        word.Value.Add(wordTrans);//добавляем в список переведённых слов
                                        break;
                                    }
                                }
                                Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                                var keyInfo = Console.ReadKey().Key;
                                switch (keyInfo)
                                {
                                    case ConsoleKey.D1:
                                        goto tryTranslatePart;
                                    case ConsoleKey.D0:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nВы добавили перевод не на русском языке, попробуйте ещё раз!\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                goto tryTranslatePart;
                            }
                        }
                    }
                    break;
                case (int)Langs.RUS_ENG:
                    isFullAdd = false;
                    isPartAdd = false;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nЕсли хотите добавить русское слово и его перевод на английском  нажмите: \"1\"");
                    Console.WriteLine("\nЕсли просто добавить английский перевод слова нажмите: \"0\" \n");
                    keyType = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                    switch (keyType)
                    {
                        case ConsoleKey.D1:
                            isFullAdd = true;
                            break;
                        case ConsoleKey.D0:
                            isPartAdd = true;
                            break;
                        default:
                            isFullAdd = true;
                            break;
                    }
                    //если добавляем слово и его перевод
                    if (isFullAdd)
                    {
                        string wordBasic;//опорная переменная
                        List<string> wordTranslateList = new List<string>();//опорный список перевода слова
                    tryAgain:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nВведите слово на русском языке: \n");
                        wordBasic = Console.ReadLine();
                        //Проверка на наличие слова в словаре
                        foreach (var word in this.Diction)
                        {
                            if (word.Key == wordBasic)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Слово: {word.Key} уже есть в словаре, попробуйте добавить другое слово");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                goto tryAgain;
                            }
                        }
                        
                        if (!(Regex.IsMatch(wordBasic, "^[а-яА-Я^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на русском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryAgain;
                        }

                    tryTranslate:
                        Console.WriteLine("\nВведите перевод слова на английском языке: \n");
                        string wordOffTrans = Console.ReadLine();
                        //проверка на латиницу
                        if (Regex.IsMatch(wordOffTrans, "^[a-zA-Z^0-9]*$"))
                        {
                            TranslateList.Add(wordOffTrans);//добавляем в локальный список новый перевод
                            Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                            var keyInfo = Console.ReadKey().Key;
                            switch (keyInfo)
                            {
                                case ConsoleKey.D1:
                                    goto tryTranslate;
                                case ConsoleKey.D0:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nВы добавили перевод не на английском языке, попробуйте ещё раз!\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryTranslate;
                        }
                        //и наконец-то добавляем в словарь слово на английском и список с его переводами на русском
                        this.Diction.Add(wordBasic, TranslateList);
                    }
                    if (isPartAdd)
                    {
                    tryFindWord:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\t\tВведите русское слово для которого хотите добавить перевод:\n\n");
                        string wordPartBasic;
                        wordPartBasic = Console.ReadLine();

                        //Проверка на русскоязычность
                        if (!(Regex.IsMatch(wordPartBasic, "^[а-яА-Я^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на русском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryFindWord;
                        }

                        //если слово-ключ найдено и ранее проверено на русскоязычность
                        if (this.Diction.ContainsKey(wordPartBasic))
                        {

                        tryTranslatePart:
                            Console.WriteLine("\nВведите перевод слова на английском языке: \n");
                            string wordTrans = Console.ReadLine();
                            //проверка на латиницу
                            if (Regex.IsMatch(wordTrans, "^[a-zA-Z^0-9]*$"))
                            {
                                //ищем по ключу в словаре нужное
                                foreach (var word in this.Diction)
                                {
                                    if (word.Key == wordPartBasic)
                                    {
                                        word.Value.Add(wordTrans);//добавляем в список переведённых слов
                                        break;
                                    }
                                }
                                Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                                var keyInfo = Console.ReadKey().Key;
                                switch (keyInfo)
                                {
                                    case ConsoleKey.D1:
                                        goto tryTranslatePart;
                                    case ConsoleKey.D0:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nВы добавили перевод не на английском языке, попробуйте ещё раз!\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                goto tryTranslatePart;
                            }
                        }
                    }
                    break;
            }  
        }

        public void ChangeWord (int _lang)
        {
            switch (_lang)
            {   //выбираем языковый тип словаря
                case (int)Langs.ENG_RUS:
                    bool isFullAdd = false;
                    bool isPartAdd = false;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nЕсли хотите заменить английское слово и его перевод  нажмите: \"1\"");
                    Console.WriteLine("\nЕсли просто заменить русский перевод слова нажмите: \"0\" \n");
                    var keyType = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                    switch (keyType)
                    {
                        case ConsoleKey.D1:
                            isFullAdd = true;
                            break;
                        case ConsoleKey.D0:
                            isPartAdd = true;
                            break;
                        default:
                            isFullAdd = true;
                            break;
                    }
                    //если добавляем слово и его перевод
                    if (isFullAdd)
                    {
                        string wordBasic;//опорная переменная
                        List<string> wordTranslateList = new List<string>();//опорный список перевода слова
                    tryAgain:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nВведите слово на английском языке КОТОРОЕ хотите заменить: \n");
                        wordBasic = Console.ReadLine();
                        if (!(Regex.IsMatch(wordBasic, "^[a-zA-Z^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на английском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryAgain;
                        }

                        Console.WriteLine("\nВведите слово на английском языке НА КОТОРОЕ хотите заменить: \n");
                        string wordOnChange = Console.ReadLine();
                        if (!(Regex.IsMatch(wordOnChange, "^[a-zA-Z^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на английском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryAgain;
                        }


                        //Проверка на наличие слова в словаре
                        foreach (var word in this.Diction)
                        {
                            if (word.Key == wordBasic && this.Diction.ContainsKey(wordBasic))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Слово: {word.Key} есть в словаре. Можно заменить: \n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            }
                            if (!(word.Key == wordBasic && this.Diction.ContainsKey(wordBasic) == false))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Слова: {word.Key} нет в словаре.\n");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Введите другое английское слово КОТОРОЕ вы хотите заменить: ");
                                goto tryAgain;
                            }
                            break;
                        }
                        //
                        

                    tryTranslate:
                        Console.WriteLine("\nВведите перевод слова на русском языке: \n");
                        string putWordTrans = Console.ReadLine();
                        //проверка на кириллицу
                        if (!(Regex.IsMatch(putWordTrans, "^[а-яА-Я^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nВы добавили перевод не на русском языке, попробуйте ещё раз!\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryTranslate;
                        }
                        //
                        wordTranslateList.Add(putWordTrans);//добавляем перевод в опорный список
                        Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                        var keyInfo = Console.ReadKey().Key;
                        switch (keyInfo)
                        {
                            case ConsoleKey.D1:
                                goto tryTranslate;
                            case ConsoleKey.D0:
                                break;
                            default:
                                break;
                        }

                        ////и наконец-то полностью заменяем слово в словаре на английском и список с его переводами на русском
                        //this.Diction.Add(wordBasic, wordTranslateList);

                        foreach (var word in this.Diction)
                        {
                            if (word.Key == wordBasic)
                            {
                                this.Diction.Remove(wordBasic);//удаляем старое англ слово
                                this.Diction.Add(wordOnChange, wordTranslateList);//добавляем новое англ слово и его новый перевод
                                break;
                            }
                        }
                    }
                    if (isPartAdd)
                    {
                    tryFindWord:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\t\tВведите английское слово ДЛЯ КОТОРОГО хотите заменить русский перевод:\n\n");
                        string wordPartBasic;
                        wordPartBasic = Console.ReadLine();
                        //Проверка на англоязычность
                        if (!(Regex.IsMatch(wordPartBasic, "^[a-zA-Z^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на английском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryFindWord;
                        }

                        //если слово найдено и ранее проверено на англоязычность
                        if (this.Diction.ContainsKey(wordPartBasic))
                        {

                        tryTranslatePart:
                            Console.WriteLine("\nВведите перевод слова на русском языке КОТОРЫЙ хотите заменить: \n");
                            string wordForChange = Console.ReadLine();
                            Console.WriteLine("\nВведите перевод слова на русском языке НА КОТОРЫЙ хотите заменить: \n");
                            string onWordChange = Console.ReadLine();
                            //проверка на кириллицу
                            if (Regex.IsMatch(wordForChange, "^[а-яА-Я^0-9]*$") && Regex.IsMatch(onWordChange, "^[а-яА-Я^0-9]*$"))
                            {
                                //ищем по ключу в словаре нужное
                                foreach (var word in this.Diction)//
                                {
                                    //если англ слово ДЛЯ которого меняем перевод есть, и если в списке есть такое русское слово
                                    if (word.Key == wordPartBasic && word.Value.Contains(wordForChange))
                                    {
                                        
                                        //находим индекс слова в списке перевода и
                                        for (int i = 0; i < word.Value.Count; i++)
                                        {
                                            //меняем на новый перевод в списке по индексу
                                            if(word.Value[i] == wordForChange) { word.Value[i].Insert(i, onWordChange); }
                                        }
                                       
                                    }
                                }
                                Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                                var keyInfo = Console.ReadKey().Key;
                                switch (keyInfo)
                                {
                                    case ConsoleKey.D1:
                                        goto tryTranslatePart;
                                    case ConsoleKey.D0:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nВы добавили перевод не на русском языке, попробуйте ещё раз!\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                goto tryTranslatePart;
                            }
                        }
                    }
                    break;
                case (int)Langs.RUS_ENG:
                    isFullAdd = false;
                    isPartAdd = false;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nЕсли хотите добавить русское слово и его перевод на английском  нажмите: \"1\"");
                    Console.WriteLine("\nЕсли просто добавить английский перевод слова нажмите: \"0\" \n");
                    keyType = Console.ReadKey().Key;
                    Console.WriteLine("\n");
                    switch (keyType)
                    {
                        case ConsoleKey.D1:
                            isFullAdd = true;
                            break;
                        case ConsoleKey.D0:
                            isPartAdd = true;
                            break;
                        default:
                            isFullAdd = true;
                            break;
                    }
                    //если добавляем слово и его перевод
                    if (isFullAdd)
                    {
                        string wordBasic;//опорная переменная
                        List<string> wordTranslateList = new List<string>();//опорный список перевода слова
                    tryAgain:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nВведите слово на русском языке: \n");
                        wordBasic = Console.ReadLine();
                        //Проверка на наличие слова в словаре
                        foreach (var word in this.Diction )
                        {
                            if (word.Key == wordBasic && this.Diction.ContainsKey(wordBasic))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Слово: {word.Key} уже есть в словаре, попробуйте добавить другое слово");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                goto tryAgain;
                            }
                        }

                        if (!(Regex.IsMatch(wordBasic, "^[а-яА-Я^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на русском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryAgain;
                        }

                    tryTranslate:
                        Console.WriteLine("\nВведите перевод слова на английском языке: \n");
                        string wordOffTrans = Console.ReadLine();
                        //проверка на латиницу
                        if (Regex.IsMatch(wordOffTrans, "^[a-zA-Z^0-9]*$"))
                        {
                            TranslateList.Add(wordOffTrans);//добавляем в локальный список новый перевод
                            Console.WriteLine("\nЕсли хотите добавить ещё один перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                            var keyInfo = Console.ReadKey().Key;
                            switch (keyInfo)
                            {
                                case ConsoleKey.D1:
                                    goto tryTranslate;
                                case ConsoleKey.D0:
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nВы добавили перевод не на английском языке, попробуйте ещё раз!\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryTranslate;
                        }
                        //и наконец-то добавляем в словарь слово на английском и список с его переводами на русском
                        this.Diction.Add(wordBasic, TranslateList);
                    }
                    if (isPartAdd)
                    {
                    tryFindWord:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\t\tВведите русское слово для которого хотите добавить перевод:\n\n");
                        string wordPartBasic;
                        wordPartBasic = Console.ReadLine();

                        //Проверка на русскоязычность
                        if (!(Regex.IsMatch(wordPartBasic, "^[а-яА-Я^0-9]*$")))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели слово не на русском языке, попробуйте ещё раз!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            goto tryFindWord;
                        }

                        //если слово-ключ найдено и ранее проверено на русскоязычность
                        if (this.Diction.ContainsKey(wordPartBasic))
                        {

                        tryTranslatePart:
                            Console.WriteLine("\nВведите перевод слова на английском языке: \n");
                            string wordTrans = Console.ReadLine();
                            //проверка на латиницу
                            if (Regex.IsMatch(wordTrans, "^[a-zA-Z^0-9]*$"))
                            {
                                //ищем по ключу в словаре нужное
                                foreach (var word in this.Diction)
                                {
                                    if (word.Key == wordPartBasic)
                                    {
                                        word.Value.Add(wordTrans);//добавляем в список переведённых слов
                                    }
                                }
                                Console.WriteLine("\nЕсли хотите ещё раз заменить перевод слова нажмите: \"1\", если нет нажмите: \"0\" \n");
                                var keyInfo = Console.ReadKey().Key;
                                switch (keyInfo)
                                {
                                    case ConsoleKey.D1:
                                        goto tryTranslatePart;
                                    case ConsoleKey.D0:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nВы добавили перевод не на английском языке, попробуйте ещё раз!\n");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                goto tryTranslatePart;
                            }
                        }
                    }
                    break;
            }
        }
    }


    class MainMain
    {
        static void Main(string[] args)
        {
           // Exam_25_01_23 hm = new Exam_25_01_23(2);
            Random rnd = new Random();
            Page pageMenu = new Page();
            List<string> mainMenuList = new List<string> { "\t\t\tСПИСОК ЭКЗАМЕНАЦИОННЫХ ЗАДАНИЙ\n", "\t\t\tВыберите стрелками нужное\n\n" };
            List<string> selectList = new List<string> { "Задание 1", "Выход" };
            List<string> selectLang = new List<string> { " ENG-RUS ", " RUS-ENG ", " Выход " };
            List<string> selectMenuDiction = new List<string> { "ДОБАВИТЬ СЛОВО ИЛИ ЕГО ПЕРЕВОД", 
                                                                "ЗАМЕНИТЬ СЛОВО ИЛИ ЕГО ПЕРЕВОД", 
                                                                "УДАЛИТЬ СЛОВО ИЛИ ЕГО ПЕРЕВОД",
                                                                "ИСКАТЬ ПЕРЕВОД СЛОВА","ВЫХОД"};
            List<string> langDiction = new List<string> { "\n\tВЫ ВЫБРАЛИ АНГЛО-РУССКИЙ СЛОВАРЬ:", "\n\tВЫ ВЫБРАЛИ  РУССКО-АНГЛИЙСКИЙ СЛОВАРЬ:" };

            MyDiction dictER = new MyDiction();
            SubMenu submenu = new SubMenu(selectLang);
            


        menuExit:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            pageMenu.ShowPageMenu(mainMenuList);//обьект для отображения главной страницы


            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                Console.SetCursorPosition(col, row);
                for (int i = 0; i < selectList.Count; i++)
                {
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine($"\t\t\t{selectList[i]}\n");//для вертикального меню отображает пункты
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < selectList.Count - 1)
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
                                return;
                        }
                      break;
                }
            }
        

        tryAgain_1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t\t{selectList[0].ToUpper()}\n\n");

            Console.WriteLine("\tВыберите стрелками влево-вправо тип словаря: \n\n");
            submenu.ShowSelectMenu(false);
            if (submenu.ItemNumb == selectLang.Count - 1) { goto menuExit; }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n");
                Console.WriteLine(langDiction[submenu.ItemNumb]);//отображает сообщение о выборе типа словаря
                Console.WriteLine("\n");
            }
            SubMenu submenu_v1 = new SubMenu(selectMenuDiction);//создаём обьект подменю выбора опций
            submenu_v1.ShowSelectMenu(true); //создаём вертикальное представление подменю опций
           // submenu_v1.ItemNumb = submenu.ItemNumb;//это необходимо из-за недоработки обьекта-подменю - надо доделать!!!
            //если был выбран последний пунк подменю
            //(подтверждён клавишей Enter в submenu_v1.ShowSelectMenu(true)
            //это нажатие перезаписывает переменную свойства submenu_v1.ItemNumb)
            //- т.к выбран последний пункт значит выходим в меню                               
            if (submenu_v1.ItemNumb  == selectMenuDiction.Count - 1 ) { goto menuExit; }
            else 
            {
                // Console.WriteLine(submenu_v1.ItemNumb);
                //!!!!!!ЗДЕСЬ НУЖЕН ДЕЛЕГАТ И ВЫБОР СООТВЕТСТВУЮЩЕГО МЕТОДА ИЗ ЕГО МАССИВА МЕТОДОВ!!!!!
                

                Console.Clear();
                Console.WriteLine($"\t\t{selectMenuDiction[submenu_v1.ItemNumb]}");//отображаем выбранную опцию подменю
                //Console.WriteLine($"submenu_v1.ItemNumb = { submenu_v1.ItemNumb}");                                                                

                switch (submenu_v1.ItemNumb)
                {
                    case 0:
                        dictER.AddWord(submenu.ItemNumb);//добавляем в словарь соответсвующий переданному в параметре его языковый вид
                        break;
                    case 1:
                        dictER.ChangeWord(submenu.ItemNumb);
                        break;
                        //
                        //
                        
                }

                
            }
            Console.WriteLine("\n\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\n");
            Console.ReadKey();
            dictER.ShowDiction();


            Console.WriteLine("\n");
            Console.ReadKey();
            goto menuExit;

        

        }
    }




























}
