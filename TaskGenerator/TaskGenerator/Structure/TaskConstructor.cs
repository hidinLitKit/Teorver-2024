using System;
using System.Collections.Generic;
using System.Linq;
namespace TaskGenerator
{
   
    public static class TaskConstructor
    {
        //subtype 1 - задача из 2-го варианта, subtype 2 - эта же задача из 3-го варианта.
        public static Task CreateTask(ref Random random, int type, int subtype = 0)
        {
            /*-normal random?...
              -йез.
              ⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
              ⣿⣿⣿⣿⣿⣿⢿⢯⣛⣺⣯⣿⣿⣿⣿⣿⣿⣿⢱⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
              ⣿⣿⣿⡿⣿⣿⢡⣿⣉⣿⡿⠿⠿⠿⡿⠿⠻⣿⡇⠸⣻⠾⣿⣿⣿⣿⣿⣿⣿⣿
              ⣿⣿⡿⠛⠉⠁⠹⡰⣹⣟⣧⣤⡤⠄⠄⠠⣡⣼⣷⠄⢉⢻⣿⣿⣿⣿⣿⣿⣿⣿
              ⣿⠟⠄⠄⠄⡀⢸⣾⣿⣯⣯⡃⠄⠄⠄⠄⠐⠙⣿⣧⡀⠩⣧⠙⣿⣿⣿⣿⣿⣿
              ⣿⠄⠄⠄⠈⠈⣾⣿⣿⣿⣿⣆⡀⠄⠄⠄⠄⠄⣸⣿⣿⣿⣧⠄⣼⣿⣿⣿⣿⣿
              ⣿⠇⠄⠄⠄⠄⠙⠛⠛⠿⠿⢿⣿⣶⣀⣶⣾⣿⣿⣿⣿⢾⣷⣇⣤⣿⣿⣿⣿⣿
              ⣿⣻⠄⠄⠄⠄⠄⠄⠄⠄⠠⠤⣤⣤⣌⠉⠉⠉⠁⢈⠁⠤⠛⣼⣿⣿⣿⣿⠿⠿
              ⠈⠈⠄⠄⠄⠄⣀⣴⡦⠴⠠⢠⣴⣶⣶⣶⣿⣿⡶⠛⠠⠄⠄⣿⣿⡿⠟⠁⠺⠿
              ⣀⣤⣤⣦⣤⣼⣿⡿⣣⣿⡷⣿⣿⣿⣿⣿⣿⡿⣿⡄⠄⠄⠄⢟⡁⠚⠦⠴⠤⣤
              ⠿⠉⠛⠟⣻⣿⠋⢁⣿⢿⣵⣭⣞⢿⣯⣽⣿⣿⣿⣿⡆⠄⠄⠄⠉⠄⠄⠄⠄⠄
              ⠄⠄⠄⠄⠈⠁⠄⢯⣷⣿⣿⣯⡿⣽⣾⣿⣿⠿⢿⣿⣧⡄⠄⠄⠄⠄⠄⠄⠄⠄
              ⠄⠄⠄⠄⠄⠄⡴⢇⠉⢹⣀⣿⣿⣿⢿⡟⣿⣧⣼⡀⡩⠻⣦⠄⠄⠄⠄⠄⠄⠄
              ⠄⠄⠄⠄⠰⠄⠣⣸⣶⠛⠛⠻⣿⡿⠿⢱⡟⠉⠉⠻⣿⡲⠃⠄⠄⠄⠄⠄⠄⠄
              ⠄⠄⠄⠄⠄⠒⠄⠈⠿⠄⠄⠄⡿⠃⠄⠘⠄⠄⢀⡠⠏⠄⠄⠄⠄⠄⠄⠄⠄⠄*/

            int randomSubtype = random.Next(1, 3);

            switch (type)
            {
                case 1:
                    return CreateTaskType1(ref random, subtype == 0 ? randomSubtype : subtype);
                case 2:
                    return CreateTaskType2(ref random, subtype == 0 ? randomSubtype : subtype);
                case 3:
                    return CreateTaskType3(ref random, subtype == 0 ? randomSubtype : subtype);
                case 4:
                    return CreateTaskType4(ref random, subtype == 0 ? randomSubtype : subtype);
                case 5:
                    return CreateTaskType5(ref random, subtype == 0 ? randomSubtype : subtype);
                case 6:
                    return CreateTaskType6(ref random, subtype == 0 ? randomSubtype : subtype);
                case 7:
                    return CreateTaskType7(ref random, subtype == 0 ? randomSubtype : subtype);
                case 8:
                    return CreateTaskType8(ref random, subtype == 0 ? randomSubtype : subtype);
                case 9:
                    return CreateTaskType9(ref random, subtype == 0 ? randomSubtype : subtype);
                case 10:
                    return CreateTaskType10(ref random, subtype == 0 ? randomSubtype : subtype);
                case 11:
                    return CreateTaskType11(ref random, subtype == 0 ? randomSubtype : subtype);
                case 12:
                    return CreateTaskType12(ref random, subtype == 0 ? randomSubtype : subtype);
                case 13:
                    return CreateTaskType13(ref random, subtype == 0 ? randomSubtype : subtype);
                case 14:
                    return CreateTaskType14(ref random, subtype == 0 ? randomSubtype : subtype);
                case 15:
                    return CreateTaskType15(ref random, subtype == 0 ? randomSubtype : subtype);
                case 16:
                    return CreateTaskType16(ref random, subtype == 0 ? randomSubtype : subtype);
                case 17:
                    return CreateTaskType17(ref random, subtype == 0 ? randomSubtype : subtype);
                case 18:
                    return CreateTaskType18(ref random, subtype == 0 ? randomSubtype : subtype);
               /* case 19:
                    return CreateTaskType19(ref random, subtype == 0 ? randomSubtype : subtype);
                case 20:
                    return CreateTaskType20(ref random, subtype == 0 ? randomSubtype : subtype);
                case 21:
                    return CreateTaskType21(ref random, subtype == 0 ? randomSubtype : subtype); */
            }
            throw new NotImplementedException();
        }

        private static Task CreateTaskType1(ref Random random, int subtype)
		{
            switch (subtype)
            {
                case 1:
                    

                    Task task1 = new Task(1, 1);
                    var numCount = 4 + Convert.ToInt32(Math.Floor(random.NextDouble() * 3));
                    var sndNum = 1;
                    for (int i = 0; i < numCount; i++)
                    {
                        sndNum *= (10 - i);
                    }
                    var numString = (numCount == 4) ? "четырехзначным" : (numCount == 5) ? "пятизначным" : "шестизначным";
                    task1.condition = "Наугад выбирается автомобиль с " + numString + " номером. Найти вероятность того, что: ";
                    task1.questions.Add("Это автомобиль Ф. Киркорова");
                    task1.questions.Add("Номер не содержит одинаковых цифр.");
                    task1.answers.Add(String.Format("1/{0:0} ≈ {1:0.000000}", Math.Pow(10, numCount), 1 / Math.Pow(10, numCount)));
                    task1.answers.Add(String.Format("{0:0}/{1:0} ≈ {2:0.000000}", sndNum, Math.Pow(10, numCount), sndNum / Math.Pow(10, numCount)));
                    return task1;
                case 2:
                    Task task2 = new Task(1, 2);
                    
                    int numCount2 = 3 + random.Next(0, 4);

                    string numString2 = (numCount2 == 3) ? "трёхзначный" : (numCount2 == 4) ? "четырёхзначный" : numCount2 == 5 ? "пятизначный" : "шестизначный";
                    task2.condition = "Компьютер тайно от оператора формирует " + numString2 + "кодовый номер кредитной карточки для клиента банка, используя датчик случайных чисел." +
                                    " Какова вероятность, что оператор угадает код карточки, если он знает, что: ";
                    task2.questions.Add("цифры в коде не повторяются;");
                    task2.questions.Add(" код не содержит цифры 0 и 1?;");
                    double ans1 =  Factorial(10) / Factorial(10 - numCount2);

                    task2.answers.Add(String.Format("1/{0:0} ≈ {1:0.000000}", ans1, 1 / (double)ans1));
                    double ans2 = Factorial(10-2) / Factorial(10 - 2 - numCount2);
                    task2.answers.Add(String.Format("1/{0:0} ≈ {1:0.000000}", ans2, (1 / (double)ans2)));
                    return task2;
            }
            throw new ArgumentException();
		}

        private static Task CreateTaskType2(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    

                    var loteryCount = 6 + Convert.ToInt32(Math.Floor(random.NextDouble() * 5));
                    var loteryWinCount = 2 + Convert.ToInt32(Math.Floor(random.NextDouble() * 4));
                    var loteryPickedCount = 2 + Convert.ToInt32(Math.Floor(random.NextDouble() * (loteryCount - loteryWinCount - 1)));

                    var loteryWinPickedCount = 1 + Convert.ToInt32(Math.Floor(random.NextDouble() * loteryWinCount));

                    var task1 = new Task(2, 1);
                    task1.condition = "Имеется " + loteryCount + " лотерейных билетов, среди которых " + loteryWinCount + " выигрышных. Найдите вероятность того, что среди " + loteryPickedCount + " наудачу купленных билетов:";
                    task1.questions.Add("Количество выигрышных билетов равно " + loteryWinPickedCount + ".");
                    task1.questions.Add("Нет выигрышных билетов.");

                    var result1 = (C(loteryWinCount, loteryWinPickedCount) * C(loteryCount - loteryWinCount, loteryPickedCount - loteryWinPickedCount)) / (C(loteryCount, loteryPickedCount));
                    var result2 = (C(loteryWinCount, 0) * C(loteryCount - loteryWinCount, loteryPickedCount)) / C(loteryCount, loteryPickedCount);

                    task1.answers.Add(string.Format("{0:0.0000}", result1));
                    task1.answers.Add(string.Format("{0:0.0000}", result2));
                    return task1;

                case 2:
                    Task task2 = new Task(2, 2);

                    int belGrib = random.Next(7, 13);
                    int gruGrib = random.Next(12, 18);
                    int muhGrib = random.Next(4, 8);
                    int gribs = belGrib + gruGrib + muhGrib;
                    int razdal = random.Next(5, 8);

                    int muhRazdal = muhGrib - 2;
                    int gruzdRazdal = random.Next(1, 3);
                    int belRazdal = razdal - gruzdRazdal - 1;

                    task2.condition = $"Дети собрали в лесу {belGrib} белых грибов, " +
						$"{gruGrib} груздей и {muhGrib} мухоморов. Бабушка наудачу извлекает из корзины" +
						$" {razdal} грибов. Какова вероятность того, что среди них: "; 
                    task2.questions.Add($"{muhRazdal} мухомор{EndingNoun(muhRazdal)}.");
                    task2.questions.Add($"{gruzdRazdal} грузд{EndingNoun(gruzdRazdal)} и {belRazdal} гриб{EndingNoun(belRazdal)} бел{EndingAdj(belRazdal)}");

                    var res1 = (C(muhGrib,muhRazdal) * C(gribs - muhGrib, muhGrib - muhRazdal)) / (C(gribs, razdal));
                    var res2 = (C(gruGrib, gruzdRazdal) * C(belGrib, belRazdal)) * C(gribs-gruGrib-belRazdal, razdal - gruzdRazdal - belRazdal) / (C(gribs, razdal));
                    //task2.answers.Add("C(" + whiteCount + "," + whiteTake + ")*C(" + blueCount + ", " + blueTake + ")/C(" + (whiteCount + blueCount) + ", " + manCount + " ) = " + (C(whiteCount, whiteTake) * C(blueCount, blueTake)) / C((whiteCount + blueCount), manCount));
                    task2.answers.Add(String.Format("C({0:0},{1:0})*C({2:0},{3:0})/C({4:0},{5:0}) ≈ {6:0.0000}", muhGrib, muhRazdal, gribs - muhGrib, muhGrib - muhRazdal, gribs , razdal, res1));
                    //task2.answers.Add("1 - C(" + whiteCount + "," + manCount + ")/C(" + (whiteCount + blueCount) + "," + manCount + ") = " + (1 - C(whiteCount, manCount) / C((whiteCount + blueCount), manCount)));
                    task2.answers.Add(String.Format("C({0:0},{1:0})*C({2:0},{3:0})*C({4:0},{5:0}) / C({6:0},{7:0})≈ {8:0.0000}", gruGrib, gruzdRazdal , belGrib, belRazdal, gribs - gruGrib - belRazdal, razdal - gruzdRazdal - belRazdal, gribs, razdal, res2));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType3(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(3, 1);

                    task1.condition = "Эксперимент состоит в бросании игральной кости. Пусть событие А – появление больше 4 очков, событие В – появление больше 3 и меньше 6 очков, " +
                        "событие С – появление больше 3 очков. Выразите событие С через события А и В. " +
                        "Постройте множество элементарных исходов и выявите состав подмножеств, соответствующих событиям:";
                    task1.questions.Add("A ∪ B");
                    task1.questions.Add("A ∩ ¬B");

                    task1.answers.Add("C = A ∪ B");
                    task1.answers.Add("Ω = {1,2,3,4,5,6}, A ∪ B = {4,5,6}, A ∩ ¬B = {6}");

                    return task1;
                case 2:
                    Task task2 = new Task(3, 2);
                    task2.condition = " Пусть A, B, C — случайные события, выраженные" +
                        " подмножествами одного и того же множества элементарных событий." +
                        " В алгебре событий запишите следующее:";
                    task2.questions.Add(" D — произошло два и только два из данных событий;");
                    task2.questions.Add("E — произошли все три события; ");
                    task2.questions.Add("E — произошли все три события; ");
                    task2.answers.Add("A∩B∩¬C ∪ A∩¬B∩C ∪ ¬A∩B∩C");
                    task2.answers.Add("A∩B∩C");
                    task2.answers.Add("1 - A∩B∩C");
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType4(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    

                    var prob1 = (random.Next(1,10)) / 10.0;
                    var prob2 = (random.Next(1,10)) / 10.0;

                    Task task1 = new Task(4, 1);
                    task1.condition = "Два поэта-песенника предложили по одной песне исполнителю. Известно, " +
                        "что песни первого поэта эстрадный певец включает в свой репертуар с вероятностью " + prob1 + ", " +
                        "второго – с вероятностью " + prob2 + ". Какова вероятность того, что певец возьмет:";
                    task1.questions.Add("Обе песни.");
                    task1.questions.Add("Хотя бы одну.");
                    task1.questions.Add("Только песню второго поэта.");
                    task1.answers.Add(string.Format("{0:0.00}", prob1 * prob2));
                    task1.answers.Add(string.Format("{0:0.00}", 1 - (1 - prob1) * (1 - prob2)));
                    task1.answers.Add(string.Format("{0:0.00}", (1 - prob1) * prob2));

                    return task1;
                case 2:
                    
                    var ver1 = (random.Next(1, 10)) / 10.0;
                    var ver2 = (random.Next(1, 10)) / 10.0;
                    Task task2 = new Task(4, 2);
                    task2.condition = $"Студент выполняет самостоятельную работу по математике, состоящую из двух задач на разные темы.Задачу на тему «Классическая вероятность» он решает правильно с вероятностью {ver1}, а на тему «Гипергеометрическое распределение» — с вероятностью {ver2}.Какова вероятность того, что из двух задач:";
                    task2.questions.Add("он правильно решит обе;");
                    task2.questions.Add("правильно решит хотя бы одну;");
                    task2.questions.Add("не решит задачу на первую тему?");
                    task2.answers.Add(string.Format("{0:0.00}",ver1 * ver2));
                    task2.answers.Add(string.Format("{0:0.00}",1 - (1 - ver1) * (1 - ver2)));
                    task2.answers.Add(string.Format("{0:0.00}",ver2 * (1 - ver1)));

                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType5(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    
                    var prob1 = Convert.ToDouble(random.Next(1, 8));
                    var prob2 = Convert.ToDouble(random.Next(1, 10 - Convert.ToInt32(prob1) - 1));
                    var prob3 = Convert.ToDouble(10 - prob1 - prob2);

                    prob1 /= 10; prob2 /= 10; prob3 /= 10;

                    Task task1 = new Task(5, 1);
                    task1.condition = "Два гроссмейстера играют две партии в шахматы. Вероятность выигрыша в одной партии для первого шахматиста " +
                        "равна " + prob1 + ", для второго – " + prob2 + "; вероятность ничьей – " + prob3 + ". " +
                        "Какова вероятность того, что первый гроссмейстер выиграет матч?";
                    task1.answers.Add(string.Format("{0:0.0000}", (prob1 * prob1 + prob1 * prob3 + prob3 * prob1)));
                    return task1;
                case 2:
                    
                    var ver1 = random.Next(1, 10) / 10.0;
                    var ver2 = random.Next(1, 10) / 10.0;

                    Task task2 = new Task(5, 2);
                    task2.condition = $"Детеныш хомячка в неволе погибает в течение первых двух недель жизни от генетических дефектов с вероятностью {ver1}, а от инфекции — с вероятностью {ver2}.За первые две недели погибли 3 детеныша.Какова вероятность, что большинство из них погибло от инфекции?";
                    task2.answers.Add(string.Format("{0:0.000}",(ver2*ver2*ver2)+3*(ver1*ver2*ver2)));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType6(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    
                    var brockenCount = random.Next(1, 5) * 5;

                    Task task1 = new Task(6, 1);

                    task1.condition = "В ящике 100 деталей, из которых " + brockenCount + " бракованных. Из него поочередно извлекается " +
                        "по одной детали (с возвратом и без возврата). Найти вероятность того, что во второй раз " +
                        "будет вынута стандартная деталь при условии, что в первый раз извлечена деталь:";
                    task1.questions.Add("Стандартная.");
                    task1.questions.Add("Бракованная.");
                    task1.answers.Add(string.Format("{0:0.000000}", ((99.0 - brockenCount) / 99.0)));
                    task1.answers.Add(string.Format("{0:0.000000}", (99.0 - brockenCount + 1) / 99.0));

                    return task1;
                case 2:
                    int days = 31; 
                    var dayGood = random.Next(10, 20);
                    var restDays = days - dayGood; 

                    Task task2 = new Task(6, 2);

                    task2.condition = $"В Омской области среднее число ясных дней в марте равно {dayGood}.Определить вероятность того, что первого и второго марта будет пасмурная погода.";
                    var ans = (restDays / (float)days);
                    ans *= ( (restDays - 1) / (float)(days - 1));
                    task2.answers.Add(string.Format("{0:0}/{1:0} * {2:0}/{3:0} ≈ {4:0.000000}", restDays, days, restDays - 1, days - 1,ans));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType7(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    
                    var prob1 = Convert.ToDouble(random.Next(1, 10));
                    var prob2 = Convert.ToDouble(random.Next(1, 10));
                    var prob3 = Convert.ToDouble(random.Next(1, 10));

                    prob1 /= 10; prob2 /= 10; prob3 /= 10;

                    Task task1 = new Task(7, 1);

                    task1.condition = "В скачках участвуют три лошади. Первая лошадь выигрывает скачки с вероятностью " + prob1 + ", " +
                        "вторая – " + prob2 + ", третья – " + prob3 + ". Какова вероятность того, что лошадь, на которую поставил игрок, " +
                        "придет на скачках первой, если он выбирает ее на удачу?";
                    task1.answers.Add(string.Format("{0:0.000000}", (prob1 + prob2 + prob3) / 3.0));

                    return task1;

                case 2:

                    int H1 = random.Next(60, 90);
                    int H2 = 100 - H1;
                    float p1 = random.Next(1, 4) / 10f;
                    float p2 = random.Next(4, 7) / 10f;
                    List<int> H = new List<int>() { H1, H2 };
                    List<float> P = new List<float>() { p1, p2 };
                    float ans = 0;
                    for(int i = 0;i < H.Count; i++) ans += ( H[i] / 100f) * P[i];
                    Task task2 = new Task(7, 2);
                    task2.condition = "Прибор, установленный на борту самолета, может " +
                        "работать в двух режимах: в условиях нормального крейсерского полета и в условиях перегрузки при взлете и посадке." +
                        $"Крейсерский режим осуществляется в {H1}% всего времени полета, режим перегрузки — в {H2} %.Вероятность выхода прибора из строя за время полета в нормальном режиме равна {p1}, в условиях перегрузки — {p2}." +
                        "Вычислить вероятность отказа прибора за время полета";
                    task2.answers.Add((string.Format("{0:0.00}", ans)));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType8(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    var prob1 = Convert.ToDouble(random.Next(1, 20));
                    var prob2 = Convert.ToDouble(random.Next(1, 20));
                    var prob3 = Convert.ToDouble(random.Next(1, 20));

                    prob1 /= 20; prob2 /= 20; prob3 /= 20;

                    Task task1 = new Task(8, 1);

                    task1.condition = "Электростанция оборудована генератором электрического тока, приводимым во вращение дизельным двигателем. " +
                        "Состояние оборудования и воспламенительные свойства дизельного топлива (цетановое число) таковы, " +
                        "что при использовании в качестве топлива соляровых фракций прямой перегонки нефти генератор приходит в аварийное состояние с вероятностью " +
                        prob1 + ", при использовании керосиновых фракций – с вероятностью " + prob2 + ", а при использовании газойлевых фракций – с вероятностью " + prob3 +
                        ". 26 апреля 1986 г. года электростанция исправно давала ток. Какова вероятность того, что в этот день дизельный двигатель работал на солярке, " +
                        "если тот или иной вид топлива используется с равной вероятностью?";

                    task1.answers.Add(string.Format("{0:0.000000}", (1 - prob1) / ((1 - prob1) + (1 - prob2) + (1 - prob3))));
                    return task1;
                case 2:
                    var A1 = random.Next(1, 5) / 10.0;
                    var A2 = random.Next(1, 3) / 10.0;
                    var A3 = 1 - A2 - A1;
                    List<double> A = new List<double>() { A1, A2, A3 };
                    var H = 1 / 3.0;

                    var p = A.Sum() * H;
                    var ans = (H * A2) / p;


                    Task task2 = new Task(8, 2);

                    task2.condition = $"Красная Шапочка, заблудившись в лесу, вышла на полянку, от которой в разные стороны ведут три дороги. Вероятность встретить Серого Волка на первой дороге " +
                        $"равна {A1}, на второй — {A2}, на третьей — {A3}.Какова вероятность того, что Красная Шапочка пошла по второй дороге, если известно, что через час она уже была у бабушки?";

                    task2.answers.Add(string.Format("{0:0.000000}", ans));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType9(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    
                    var prob1 = random.Next(1, 4);
                    var prob2 = random.Next(1, 8);

                    Task task1 = new Task(9, 1);
                    task1.condition = "В скольких партиях с равным по силе противником выигрыш более вероятен: в " + prob1 + " партиях из 4 или в " + prob2 + " из 8?";
                    task1.answers.Add(C(4,prob1) * Math.Pow(0.5, 4) > C(8, prob2) * Math.Pow(0.5, 8) ? "1" : "2");

                    return task1;
                case 2:

                    var ver1 = random.Next(1, 4);
                    var ver2 = random.Next(1, 8);

                    Task task2 = new Task(9, 2);
                    task2.condition = $"Что вероятнее: выиграть в шахматы у равного по силе противника в не менее {ver1}  партиях из 4 или в не менее {ver2} из 8?";
                    double ans1 = 0;
                    for(int i = ver1; i <= 4; i++)
                    {
                        ans1 += C(4, i) * Math.Pow(0.5, 4);
                    }
                    double ans2 = 0;
                    for (int i = ver2; i <= 8; i++)
                    {
                        ans2 += C(8, i) * Math.Pow(0.5, 8);
                    }
                    task2.answers.Add( ans1 > ans2 ? "1" : "2");
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType10(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(10, 1);
                    

                    var testCount = random.Next(7,10) * 100;
                    var prob = random.Next(5, 15) / 20.0;
                    var equalCount = random.Next(5,10) * 50;

                    var startCount = random.Next(2, 6) * 50;
                    var endCount = random.Next(6, 11) * 50;

                    task1.condition = "В каждом из " + testCount + " независимых испытаний событие А происходит с постоянной вероятностью " + prob + ". " +
                        "Найти вероятность того, что событие А происходит:";
                    task1.questions.Add("Меньше чем " + endCount + " и больше чем " + startCount + " раз.");
                    task1.questions.Add("Точно " + equalCount + " раз.");

                    var x = (equalCount - testCount * prob) / Math.Sqrt(testCount * prob * (1 - prob));

                    var x11 = (startCount - testCount * prob) / Math.Sqrt(testCount * prob * (1 - prob));
                    var x22 = (endCount - testCount * prob) / Math.Sqrt(testCount * prob * (1 - prob));

                    task1.answers.Add("Ф(" + String.Format("{0:0.0000}", x22) + ") - Ф(" + String.Format("{0:0.0000}", x11) + ")");
                    //task1.answers.Add("Φ(" + String.Format("{0:0.0000}",x) + ")");
                    double k11 = 1.0 / Math.Sqrt(100 * prob * (1 - prob));
                    task1.answers.Add(string.Format("{0:0.00} * φ({1:0.00})", k11, x));
                    return task1;
                case 2:
                    Task task2 = new Task(10, 2);


                    double n = random.Next(175, 200);
                    double k1 = random.Next(80, 100);
                    double k2 = random.Next(105, 120);
                    double k = random.Next(50, 70);
                    double p = 1 / 2.0;

                    var x1 = (k1 - n*p) / Math.Sqrt(n*p*p);
                    var x2 = (k2 - n * p) / Math.Sqrt(n * p * p);
                    var x3 = (k - n * p) / Math.Sqrt(n * p * p);


                    task2.condition = $"Монета подбрасывается {n} раз.Найти вероятность того, что герб появится";
                    task2.questions.Add($" не менее {k1} и не более {k2}раз");
                    task2.questions.Add($" ровно {k} раз.");

                    task2.answers.Add(string.Format("Φ({0:0.00}) - Φ({1:0.00})", x2,x1));


                    task2.answers.Add(string.Format("1/{0:0.00} * φ({1:0.00})", Math.Sqrt(n * p *p),x3));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType11(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(11, 1);
                    
                    var count = random.Next(1, 4);
                    count = count == 1 ? 120 : count == 2 ? 180 : 240;

                    task1.condition = "Среднее число вызовов, поступающих на АТС в минуту, равно " + count + ". Найти вероятность того, что за две секунды на АТС поступит менее двух вызовов.";

                    var lambda = count / 60.0 * 2.0;
                    var p0 = Math.Pow(lambda, 0) * Math.Exp(-lambda) / Factorial(0);
                    var p1 = Math.Pow(lambda, 1) * Math.Exp(-lambda) / Factorial(1);

                    var result = p1 + p0;
                    task1.answers.Add(String.Format("{0:0.0000}", result));
                    return task1;
                case 2:
                    Task task2 = new Task(11, 2);

                    int n = random.Next(1800, 2200);
                    double p = random.Next(1, 10) / 10000.0;
                    double q = 1 - p;
                    task2.condition = $" Аппаратура содержит {n} одинаково надежных элементов; вероятность отказа для каждого из них " +
                        $"равна {p}.Какова вероятность отказа данной аппаратуры, если он наступает при отказе хотя бы одного элемента?";
                    //double x = (studentsAmount - allStudentsAmount * (1 / 365.0)) / Math.Sqrt(allStudentsAmount * (1 / 365.0) * (1 - 1 / 365.0));
                    //double k = 1 / Math.Sqrt(allStudentsAmount * (1 / 365.0) * (1 - 1 / 365.0));
                    // task2.answers.Add(string.Format("1/√("+ allStudentsAmount + "*(1/365)*(1-1/365)) * φ({0:0.00}) ≈ {1:0.00} * φ({0:0.00})", x, k));
                    var ans = 1 - ((1 / Math.Sqrt(n*p*q))*0.3989);
                    task2.answers.Add(string.Format("{0:0.000}", ans));
                    return task2;
            }
            throw new ArgumentException();
        }
        private static Task CreateTaskType12(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(12, 1);
                    

                    var prob =  random.Next(3, 7) / 10.0;

                    task1.condition = "Вероятность поражения цели при одном выстреле равна " + prob + ".";
                    task1.questions.Add("Составить ряд распределения числа выстрелов, производимых до первого поражения цели, если у стрелка четыре патрона.");
                    task1.questions.Add("Найти M(X), D(X), σ(X), F(X) числа выстрелов до первого поражения цели.");
                    task1.questions.Add("Построить график F(X).");

                    var k1 = prob;
                    var k2 = (1 - prob) * prob;
                    var k3 = (1 - prob) * (1 - prob) * prob;
                    var k4 = (1 - prob) * (1 - prob) * (1 - prob) * prob;
                    var k5 = (1 - prob) * (1 - prob) * (1 - prob) * (1 - prob);

                    var MX = 1 * k1 + 2 * k2 + 3 * k3 + 4 * k4;
                    var DX = 1 * k1 + 4 * k2 + 9 * k3 + 16 * k4 - Math.Pow(MX, 2);

                    task1.answers.Add( "\n" +
                        "P(x = 0) = " + String.Format("{0:0.0000}", k1) + "\n" +
                        "P(x = 1) = " + String.Format("{0:0.0000}",k2) + "\n" +
                        "P(x = 2) = " + String.Format("{0:0.0000}", k3) + "\n" +
                        "P(x = 3) = " + String.Format("{0:0.0000}", k4) + "\n" +
                        "P(x = 4) = " + String.Format("{0:0.0000}", k5)
                    );
                    task1.answers.Add( "\n" + 
                        "M(X) = " + String.Format("{0:0.0000}", MX) + "\n" +
                        "D(X) = " + String.Format("{0:0.0000}", DX) + "\n" +
                        "σ(X) = " + String.Format("{0:0.0000}", Math.Sqrt(DX)) + "\n" +
                        "F(X) = \n" +
                        "    ⎧ 0, x ≤ 0\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", k1) + ", 0 < x ≤ 1\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", k1 + k2) + ", 1 < x ≤ 2\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", k1 + k2 + k3) + ", 2 < x ≤ 3\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", k1 + k2 + k3 + k4) + ", 3 < x ≤ 4\n" +
                        "    ⎩ " + String.Format("{0:0.0000}", k1 + k2 + k3 + k4 + k5) + ", 4 < x"
                    );
                    return task1;
                  
                case 2:
                    /*Task task2 = new Task(12, 2);
                    
                    double probDefective = random.Next(1,10)*5/100.0;
                    task2.condition = string.Format("Вероятность изготовления нестандартной детали равна {0:0.00}. Из партии контролер проверяет не более четырех деталей. " +
                        "Если деталь оказывается нестандартной, испытания прекращаются, а партия задерживается. Если деталь оказывается стандартной, " +
                        "контролер берет следующую и т.д.", probDefective);
                    task2.questions.Add("Составить ряд распределения числа проверенных деталей.");
                    task2.questions.Add("Найти М(Х), D(X), σ(X), F(X).");

                    double[] p = new double[5];
                    for(int i = 0; i < 4; i++)
                    {
                        p[i] = Math.Pow(1 - probDefective, i) * probDefective;
                    }
                    p[4] = Math.Pow(1 - probDefective, 4);
                    task2.answers.Add(string.Format("\n" + 
                        "P(x=0)={0:0.00} \n" +
                        "P(x=1)={1:0.00}*{0:0.00}={2:0.000} \n" +
                        "P(x=2)={1:0.00}*{1:0.00}*{0:0.00}={3:0.000} \n" +
                        "P(x=3)={1:0.00}*{1:0.00}*{1:0.00}*{0:0.00}={4:0.000} \n" +
                        "P(x=4)={1:0.00}*{1:0.00}*{1:0.00}*{1:0.00}={5:0.000}", probDefective, 1- probDefective, p[1], p[2], p[3], p[4]));

                    double mx = 0;
                    for (int i = 1; i <= 4; i++)
                        mx += i*p[i-1];

                    double dx = 0;
                    for (int i = 1; i <= 4; i++)
                        dx += i*i * p[i - 1];
                    dx -= mx * mx;

                    double[] fx = new double[4];
                    fx[0] = p[0];
                    for (int i = 1; i < 4; i++)
                        fx[i] = fx[i - 1] + p[i];
                    task2.answers.Add(string.Format("\nM(X)={0:0.000} \nD(X)={1:0.000} \nσ(X)={2:0.000} \nF(X) = \n    ⎧ 0, x ≤ 0\n    ⎨ {3:0.000}, 0 < x ≤ 1\n    ⎨ {4:0.000}, 1 < x ≤ 2\n    ⎨ {5:0.000}, 2 < x ≤ 3\n    ⎨ {6:0.000}, 3 < x ≤ 4\n    ⎩ 1, 4 < x",
                        mx, dx, Math.Sqrt(dx), fx[0], fx[1], fx[2], fx[3]));
                    return task2;*/
                    Task task2 = new Task(12, 1);


                    var _prob = random.Next(3, 7) / 10.0;

                    task2.condition = "Вероятность поражения цели при одном выстреле равна " + _prob + ".";
                    task2.questions.Add(". Стрелку последовательно выдаются патроны, пока он не промахнется, количество выдаваемых патронов ограниченно четырьмя.");
                    task2.questions.Add("Найти M(X), D(X), σ(X), F(X) числа выстрелов до первого поражения цели.");
                    task2.questions.Add("Построить график F(X).");

                    var _k1 = _prob;
                    var _k2 = (1 - _prob) * _prob;
                    var _k3 = (1 - _prob) * (1 - _prob) * _prob;
                    var _k4 = (1 - _prob) * (1 - _prob) * (1 - _prob) * _prob;
                    var _k5 = (1 - _prob) * (1 - _prob) * (1 - _prob) * (1 - _prob);

                    var _MX = 1 * _k1 + 2 * _k2 + 3 * _k3 + 4 * _k4;
                    var _DX = 1 * _k1 + 4 * _k2 + 9 * _k3 + 16 * _k4 - Math.Pow(_MX, 2);

                    task2.answers.Add("\n" +
                        "P(x = 0) = " + String.Format("{0:0.0000}", _k1) + "\n" +
                        "P(x = 1) = " + String.Format("{0:0.0000}", _k2) + "\n" +
                        "P(x = 2) = " + String.Format("{0:0.0000}", _k3) + "\n" +
                        "P(x = 3) = " + String.Format("{0:0.0000}", _k4) + "\n" +
                        "P(x = 4) = " + String.Format("{0:0.0000}", _k5)
                    );
                    task2.answers.Add("\n" +
                        "M(X) = " + String.Format("{0:0.0000}", _MX) + "\n" +
                        "D(X) = " + String.Format("{0:0.0000}", _DX) + "\n" +
                        "σ(X) = " + String.Format("{0:0.0000}", Math.Sqrt(_DX)) + "\n" +
                        "F(X) = \n" +
                        "    ⎧ 0, x ≤ 0\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", _k1) + ", 0 < x ≤ 1\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", _k1 + _k2) + ", 1 < x ≤ 2\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", _k1 + _k2 + _k3) + ", 2 < x ≤ 3\n" +
                        "    ⎨ " + String.Format("{0:0.0000}", _k1 + _k2 + _k3 + _k4) + ", 3 < x ≤ 4\n" +
                        "    ⎩ " + String.Format("{0:0.0000}", _k1 + _k2 + _k3 + _k4 + _k5) + ", 4 < x"
                    );
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType13(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(13, 1);
                    
                    var count = random.Next(3, 5);

                    task1.condition = "Игральная кость брошена " + count + " раза.";
                    task1.questions.Add("Составить ряд распределения числа выпадений шестерки.");
                    task1.questions.Add("Найти M(X) и D(X) этой случайной величины.");

                    var probs = new List<String>();

                    for(int i = 0; i <= count; i++)
                    {
                        probs.Add("P(x = " + i + ") = " + (int)Math.Pow(5, count - i) * C(count, i) + "/" + (int)Math.Pow(6, count) + "\n");
                    }

                    var result = "";

                    probs.ForEach(value => result += value);

                    var mx = 0.0;
                    var dx = 0.0;

                    for (int i = 0; i <= count; i++)
                    {
                        mx += (Math.Pow(5, count - i) * C(count, i)) / (Math.Pow(6, count)) * i;
                        dx += (Math.Pow(5, count - i) * C(count, i)) / (Math.Pow(6, count)) * Math.Pow(i,2);
                    }

                    dx -= Math.Pow(mx, 2);

                    task1.answers.Add(result);
                    task1.answers.Add(String.Format("\nM(X)={0:0.0000}\nD(X)={1:0.0000}",mx,dx));

                    return task1;
                case 2:
                    Task task2 = new Task(13, 2);
                    
                    int n = random.Next(5, 10);
                    double ver = random.Next(6, 9) / 10.0;
                    task2.condition = $"Составить ряд распределения дискретной случайной величины X — числа отказов элемента некоторо гоустройства " +
                        $"в {n} независимых опытах, если вероятность отказа элемента в каждом опыте" +
                        $" равна {ver}.Найти M(X) и D(X).";

                    double[] p = new double[n + 1];
                    for (int i = 0; i < p.Length; i++)
                        p[i] = C(n, i) * Math.Pow(ver, n);

                    string str = "";
                    for (int i = 0; i < p.Length; i++)
                        str += "P(x=" + i + ")=C(" + n + "," + i + ")*0.5^" + n + "=" + p[i] + "\n";
                    task2.answers.Add(str);
                    double mx2 = 0;
                    for (int i = 1; i <= 4; i++)
                        mx2 += i * p[i - 1];

                    double dx2 = 0;
                    for (int i = 1; i <= 4; i++)
                        dx2 += i * i * p[i - 1];

                    dx2 -= mx2 * mx2;
                    task2.answers.Add(string.Format("\nM(X)={0:0.000} \nD(X)={1:0.000}",mx2, dx2));


                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType14(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(14, 1);

                    double prob = random.Next(1, 2 + 1) * 10 / 10000.0;
                    if (random.Next(0, 1 + 1) == 0)
                    {
                        prob = random.Next(4, 5 + 1) * 10 / 10000.0;
                    }
                    int count = random.Next(1, 5 + 1) * 1000 / (int)(prob * 1000);

                    //var count = random.Next(2,5) * 500;

                    task1.condition = "Устройство содержит " + count + " ламп. Вероятность выхода из строя одной лампы в течение одного часа работы устройства равна " + prob + ".";
                    task1.questions.Add("Составить ряд распределения числа ламп, вышедших из строя в течение одного часа работы устройства.");
                    task1.questions.Add("Найти M(X) этой случайной величины.");

                    var a = count * prob;

                    task1.answers.Add(String.Format("Pn(m) = {0:0.0}^m * 1/m! * e^(-{0:0.0})", a));
                    task1.answers.Add(String.Format("M(X) = {0:0.0}", a));

                    return task1;
                case 2:
                    Task task2 = new Task(14, 2);

                    
                    //double probDamage = random.Next(1, 3 + 1) * 10 / 10000.0;
                    task2.condition = " Рукопись объемом в 1000 страниц машинописного текста содержит 1000 опечаток.";
                    task2.questions.Add("Составить ряд распределения числа лампочек, поврежденных в пути.");
                    task2.questions.Add("Найти M(X) этой случайной величины.");
                    task2.answers.Add(string.Format("Pn(m) = {0:0}^m * 1/m! * e^(-{0:0}), где m = 0,...k,...n = 1000", 1));
                    task2.answers.Add(string.Format("M(X) = Σ (i = 0, ∞) ( mi*{0:0}^i * 1* e^(-{0:0} )/ i!", 1));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType15(ref Random random, int subtype)
        {
            Task task2 = new Task(15, 2);
            

            task2.tables = new List<string[,]>();

            int[] x = new int[3];
            double[] px = new double[3];

            x[0] = random.Next(-5, 0);
            x[1] = random.Next(1, 4);
            x[2] = random.Next(5, 9);

            px[0] = random.Next(1, 8)*10/100.0;
            px[1] = random.Next(1, 10 - (int)(px[0]*10)) * 10 / 100.0;
            px[2] = Math.Round((1 - px[0] - px[1])*10)/10.0;

            task2.tables.Add(new string[3, 2]);
            for (int i = 0; i < 3; i++)
            {
                task2.tables[task2.tables.Count - 1][i, 0] = x[i] +"";
                task2.tables[task2.tables.Count - 1][i, 1] = (Math.Round(px[i] * 10) / 10) + "";
            }
            task2.tables[task2.tables.Count - 1][2, 1] = "p";

            int[] y = new int[2];
            double[] py = new double[2];
            y[0] = random.Next(-2, 0);
            y[1] = random.Next(1, 5);

            py[0] = random.Next(1, 9) * 10 / 100.0;
            py[1] = Math.Round((1 - py[0]) * 10) / 10.0;

            task2.tables.Add(new string[2, 2]);
            for (int i = 0; i < 2; i++)
            {
                task2.tables[task2.tables.Count - 1][i, 0] = y[i] + "";
                task2.tables[task2.tables.Count - 1][i, 1] = (Math.Round(py[i] * 10) /10) + "";
            }

            task2.condition = "Независимые случайные величины X и Y заданы таблицами распределений.\n"+
            "x: " + x[0] + ", " + x[1] + ", " + x[2] + ". \n" +
            "p: " + px[0] + ", " + px[1] + ", p. \n\n" +
            "y: " + y[0] + ", " + y[1] + ". \n" +
            "p: " + py[0] + ", " + py[1] + ". \n Найти: \n";

            task2.questions.Add("M(X), M(Y), D(X), D(Y).");
            task2.questions.Add("Таблицы распределения случайных величин Z1 = 2X + Y, Z2 = X * Y.");
            task2.questions.Add("M(Z1), M(Z2), D(Z1), D(Z2) непосредственно по таблицам распределений и на основании свойств математического ожидания и дисперсии.");

            double mx = 0;
            double dx = 0;
            for (int i = 0; i < 3; i++)
            {
                mx += x[i] * px[i];
                dx += x[i] * x[i] * px[i];
            }
            dx -= mx * mx;

            double my = 0;
            double dy = 0;
            for (int i = 0; i < 2; i++)
            {
                my += y[i] * py[i];
                dy += y[i] * y[i] * py[i];
            }
            dy -= my * my;
                    

            task2.answers.Add(string.Format("\nM(X)={0:0.000} \nM(Y)={1:0.000} \nD(X)={2:0.000} \nD(Y)={3:0.000}", mx, my, dx, dy));

            int[] z1 = new int[6];
            double[] pz1 = new double[6];
            for(int i = 0, j = 0; i < 3; i++, j+=2)
            {
                z1[j] = 2 * x[i] + y[0];
                z1[j+1] = 2 * x[i] + y[1];

                pz1[j] = px[i] * py[0];
                pz1[j + 1] = px[i] * py[1];
            }

            task2.tables.Add(new string[6, 2]);
            for (int i = 0; i < 6; i++)
            {
                task2.tables[task2.tables.Count - 1][i, 0] = z1[i] + "";
                task2.tables[task2.tables.Count - 1][i, 1] = (Math.Round(pz1[i] * 100) / 100) + "";
            }



            int[] z2 = new int[6];
            double[] pz2 = new double[6];
            for (int i = 0, j = 0; i < 3; i++, j += 2)
            {
                z2[j] = x[i] * y[0];
                z2[j + 1] = x[i] * y[1];

                pz2[j] = px[i] * py[0];
                pz2[j + 1] = px[i] * py[1];
            }

            task2.tables.Add(new string[6, 2]);
            for (int i = 0; i < 6; i++)
            {
                task2.tables[task2.tables.Count - 1][i, 0] = z2[i] + "";
                task2.tables[task2.tables.Count - 1][i, 1] = (Math.Round(pz2[i] * 100) / 100) + "";
            }



            task2.answers.Add(string.Format("\nz1: {0:0}, {1:0}, {2:0}, {3:0}, {4:0}, {5:0}", z1[0], z1[1], z1[2], z1[3], z1[4], z1[5]) +
                                string.Format("\np: {0:0.00}, {1:0.00}, {2:0.00}, {3:0.00}, {4:0.00}, {5:0.00}\n", pz1[0], pz1[1], pz1[2], pz1[3], pz1[4], pz1[5]) +
                                string.Format("\nz2: {0:0}, {1:0}, {2:0}, {3:0}, {4:0}, {5:0}", z2[0], z2[1], z2[2], z2[3], z2[4], z2[5]) +
                                string.Format("\np: {0:0.00}, {1:0.00}, {2:0.00}, {3:0.00}, {4:0.00}, {5:0.00}", pz2[0], pz2[1], pz2[2], pz2[3], pz2[4], pz2[5]));

            double mz1 = 0;
            double dz1 = 0;
            double mz2 = 0;
            double dz2 = 0;
            for (int i = 0; i < 6; i++)
            {
                mz1 += z1[i] * pz1[i];
                dz1 += z1[i] * z1[i] * pz1[i];

                mz2 += z2[i] * pz2[i];
                dz2 += z2[i] * z2[i] * pz2[i];
            }
            dz1 -= mz1 * mz1;
            dz2 -= mz2 * mz2;

            task2.answers.Add(string.Format("\nM(Z1)={0:0.000} \nM(Z2)={1:0.000} \nD(Z1)={2:0.000} \nD(Z2)={3:0.000}", mz1, mz2, dz1, dz2));

            
            for (int i = 0; i < task2.tables.Count; i++)
            {
                for (int j = 0; j < task2.tables[i].Length / 2; j++)
                {
                    Console.Write(task2.tables[i][j, 0] + " ");
                }
                Console.WriteLine();
                for (int j = 0; j < task2.tables[i].Length / 2; j++)
                {
                    Console.Write(task2.tables[i][j, 1] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("-----------");
            }
            return task2;
        }

        /*private static Task CreateTaskType19(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(16, 1);
                    

                    var a = random.Next(0,3);
                    var b = random.Next(3, 6);

                    var alpha = a == 0 ? "0" : a == 1 ? "π/6" : "π/4";
                    var beta = b == 3 ? "π/3" : b == 4 ? "π/2" : "π";

                    var alphaF = a == 0 ? 0 : a == 1 ? Math.PI/6.0 : Math.PI/4.0;
                    var betaF = b == 3 ? Math.PI / 3.0 : b == 4 ? Math.PI / 2.0 : Math.PI;

                    task1.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\n" + 
                        "F(x) =\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ (1/2) * (1 - cos x), 0 < x ≤ π\n" +
                        "     ⎩ 1, x > π\n" +
                        "α = " + alpha + ", β = " + beta + "\n" + 
                        "Требуется:";
                    task1.questions.Add("Найти плотность вероятности f(x).");
                    task1.questions.Add("Построить графики F(x) и f(x).");
                    task1.questions.Add("Найти P(α < X < β) для данных α, β.");

                    task1.answers.Add("\nf(x) = \n    ⎧ 0, x ≤ 0\n    ⎨ sin(x) / 2, 0 < x ≤ π\n    ⎩ 0, x > π");
                    task1.answers.Add("");
                    task1.answers.Add(String.Format("P(α < X < β) = {0:0.0000}", ((1.0/2.0) * (1 - Math.Cos(betaF))) - ((1.0/2.0) * (1 - Math.Cos(alphaF)))));
                    return task1;
                case 2:
                    Task task2 = new Task(16, 2);
                    

                    var alpha2 = random.Next(1, 5);
                    var beta2 = random.Next(6, 11);

                    task2.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\n" +
                        "F(x) =\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ x²/100, 0 < x ≤ 10\n" +
                        "     ⎩ 1, x > 10\n" +
                        "α = " + alpha2 + ", β = " + beta2 + "\n" +
                        "Требуется:";
                    task2.questions.Add("Найти плотность вероятности f(x).");
                    task2.questions.Add("Построить графики F(x) и f(x).");
                    task2.questions.Add("Найти P(α < X < β) для данных α,β.");

                    task2.answers.Add("\nf(x) = \n    ⎧ 0, x ≤ 0\n    ⎨ x/50, 0 < x ≤ 10\n    ⎩ 0, x > 10");
                    task2.answers.Add("");
                    task2.answers.Add(String.Format("P(α < X < β) = {0:0.0000}", (beta2 * beta2/100.0) - (alpha2* alpha2/100.0)));
                    return task2;
            }
            throw new ArgumentException();
        }

        static double fun(double x)
        {
            return x * x * x / 3.0 - 3 * x * x + 8 * x;
        } */
        /* private static Task CreateTaskType20(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(17, 1);
                    

                    var variant = random.Next(1, 4);
                    var start = variant == 1 ? 2 : variant == 2 ? 2 : 3;
                    var end = variant == 1 ? 4 : variant == 2 ? 3 : 4;

                    task1.condition = "Дана плотность вероятности f(X) непрерывной случайной величины X:\nf(x)=\n" +
                        "     ⎧ 0, x < " + start + "\n" +
                        "     ⎨ a(x-2)(x-4), " + start + " ≤ x < " + end + "\n" +
                        "     ⎩ 0, x > " + end;
                    task1.questions.Add("Найти параметр a.");
                    task1.questions.Add("Построить функцию распределения F(X).");
                    task1.questions.Add("Построить графики f(X) и F(X).");

                    var aa = 1 / (fun(end) - fun(start));

                    var offset = aa / 3.0 * start * start * start - 3 * aa * start * start + 8 * aa * start;
                    task1.answers.Add("a = " + String.Format("{0:0.00}", aa));

                    task1.answers.Add(
                        "F(x)=\n" +
                        "     ⎧ 0, x < " + start + "\n" +
                        "     ⎨ " + String.Format("{0:0.00}x³ + {1:0.00}x² - {2:0.00}x + {3:0.0000}",
                        aa / 3.0,
                        Math.Abs(3 * aa),
                        Math.Abs(8 * aa),
                        Math.Abs(offset)
                        ) + ", " + start + " ≤ x < " + end + "\n" +
                        "     ⎩ 1, x > " + end
                    );

                    return task1;
                case 2:
                    
                    var b=random.Next(2, 10);
                    var a=random.Next(1, b-1);
                    Task task2 = new Task(17, 2);
                    task2.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\nf(x)=\n"+
                                     "     ⎧ 0, x < " + a + '\n' +
                                     "     ⎨ a(4x+3), " + a + " ≤ x ≤ " + b + '\n' +
                                     "     ⎩ 0, x > " + b;
                    task2.questions.Add("Найти параметр a.");
                    task2.questions.Add("Найти функцию распределения F(x).");
                    task2.questions.Add("Построить графики f(x) и F(x).");
                    double ot = 1/(2 *(double)b * (double)b + 3 * (double)b - (2 * (double)a * (double)a + 3 * (double)a));
                    task2.answers.Add(string.Format("A={0:0.0000}",ot));
                    double f1 = ot * 2;
                    double f2 = ot * 3;
                    double f3 = 2 * a * a * ot + 3 * a * ot;

                    task2.answers.Add(
                        "F(x)=\n" +
                                     "     ⎧ 0, x < " + a + '\n' +
                                     "     ⎨ " + string.Format("{0:0.000}x²+{1:0.000}x-{2:0.000}", f1, f2, f3) + ", " + a + " ≤ x ≤ " + b + '\n' +
                                     "     ⎩ 1, x > " + b
                        );
                    return task2;
            }
            throw new ArgumentException();
        }

        static double fun2(double x)
        {
            return (x * x) / 2.0;
        }

        static double fun3(double x)
        {
            return -(x * x) / 2.0 + 2 * x - 1;
        }
        
        static double fun4(double x)
        {
            return x * x * (1.0 / 3.0);
        }
        static double fun5(double x)
        {
            return ((-(x * x) - 5) / 6.0 + x + 1.0 / 3.0);
        }
        private static Task CreateTaskType21(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(18, 1);
                    

                    var aa = random.Next(0,11) / -10.0 + 0.5;
                    var bb = random.Next(0,3) * 0.5 + 1;
                    
                    task1.condition = "Дана плотность вероятности f(x) непрерывной случайной величины X, имеющая две ненулевые составляющие формулы:\nf(x)=\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ x, 0 < x ≤ 1 \n" +
                        "     ⎨ -x + 2, 1 < x ≤ 2\n" +
                        "     ⎩ 0, x > 2\n" +
                        "α=" + aa + " ,β=" + bb + "\n" +
                        "Требуется:";
                    task1.questions.Add("Проверить свойство -∞∫∞(f(x)dx)=1.");
                    task1.questions.Add("Найти функцию распределения F(x).");
                    task1.questions.Add("Найти P(α≤x≤β) для данных α,β.");
                    task1.questions.Add("Найти M(X),D(x),σ(X).");
                    task1.questions.Add("Построить график f(x).");

                    task1.answers.Add("Условие выполняется.");
                    task1.answers.Add("F(X) =\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ (x²)/2, 0 < x ≤ 1 \n" +
                        "     ⎨ -(x²)/2 + 2x - 1, 1 < x ≤ 2\n" +
                        "     ⎩ 1, x > 2");

                    var realA = aa < 0 ? 0 : aa;
                    var realB = bb > 2 ? 2 : bb;

                    var ans = fun3(realB) - fun2(realA);
                    task1.answers.Add("P(α≤x≤β) = " + String.Format("{0:0.0000}", ans));

                    var mx = 1;
                    var dx = 1 / 4.0 + 11/12.0 - 1;
                    var delta = Math.Sqrt(dx);
                    task1.answers.Add(String.Format("M(X)={0:0.0000}; D(X)={1:0.0000}; σ(X)={2:0.0000}", mx, dx, delta));

                    return task1;
                    
                case 2:
                    Task task2 = new Task(18, 2);

                    var aa2 = random.Next(0, 11) / -10.0 + 0.5;
                    var bb2 = random.Next(0, 3) * 0.5 + 1;

                    task2.condition = "Дана плотность вероятности f(x) непрерывной случайной величины X, имеющая две ненулевые составляющие формулы:\nf(x)=\n" +
                                     "     ⎧ 0, x ≤ 0" + '\n' +
                                     "     ⎨ 2x/3, 0 ≤ x ≤ 1" + '\n' +
                                     "     ⎨ (3-x)/3, 1 ≤ x ≤ 3" + '\n' +
                                     "     ⎩ 0, x > 3" + '\n' +
                                     "α=" + aa2 + ",β=" + bb2 + '\n' +
                                     "Требуется:";

                    task2.questions.Add("Проверить свойство -∞∫∞(f(x)dx)=1.");
                    task2.questions.Add("Найти функцию распределения F(x).");
                    task2.questions.Add("Найти P(α≤x≤β) для данных α,β.");
                    task2.questions.Add("Найти M(X),D(x),σ(X).");
                    task2.questions.Add("Построить график f(x).");

                    task2.answers.Add("Условие выполняется.");
                    task2.answers.Add("F(x)="+'\n' +
                                      "     ⎧ 0, x ≤ 0" + '\n' +
                                      "     ⎨ x²/3, 0 ≤ x ≤ 1" + '\n' +
                                      "     ⎨ (-x²-5)/6+x+1/3, 1 ≤ x ≤ 3" + '\n' +
                                      "     ⎩ 1, x > 3");

                    var realA2 = aa2 < 0 ? 0 : aa2;
                    var realB2 = bb2 > 3 ? 3 : bb2;

                    double ot3 = fun5(realB2) - fun4(realA2);
                    task2.answers.Add("P(α≤x≤β) = " + String.Format("{0:0.000}", ot3));

                    double x1 = 4.0 / 3.0, x2 = 7.0 / 18.0, x3 = Math.Sqrt(7.0 / 18.0);
                    task2.answers.Add(string.Format("M(X)={0:0.000}, D(X)={1:0.000}, σ(X)={2:0.000}", x1, x2, x3));
                    return task2;
            }
            throw new ArgumentException();
        }
        */

        private static Task CreateTaskType16(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(19, 1);

                    

                    var lambda = random.Next(6) + 5; 

                    task1.condition = "Срок службы прибора – случайная величина X, распределенная по экспоненциальному закону с параметром λ = " + lambda + ". Необходимо:";
                    task1.questions.Add("Указать плотность вероятности f(x) и числовые характеристики этой случайной величины.");
                    task1.questions.Add("Построить кривую распределения.");

                    task1.answers.Add("f(x)=\n" +
                        "     ⎧ " + lambda + " * exp(-" + lambda + "x), x >= 0\n" +
                        "     ⎩ 0, x < 0\n\n" +
                        String.Format("M(X) = {0:0.0000}; D(X) = {1:0.0000}", (1.0 / lambda), (1.0 / (lambda * lambda))));
                        
                    return task1;
                case 2:
                    Task task2 = new Task(19, 2);
                    
                    int hours = random.Next(1, 6 + 1);
                    int minutes = random.Next(1, 20 + 1);
                    task2.condition = "Интервал движения теплоходов «Москва» на реке Иртыш составляет "+ hours + " ч. " +
                        "Дачники подходят к пристани в некоторый момент, не зная расписания. Какова вероятность того, " +
                        "что они опоздали на очередной теплоход не более чем на "+ minutes +" мин?";
                    task2.answers.Add(string.Format(minutes + "/" + (hours*60) + " ≈ {0:0.000}", minutes/(hours * 60.0)));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType17(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(20, 1);
                    double σ = random.Next(10, 21) / 10.0;
                    double val = random.Next(5, (int)(σ * 10)) / 10.0;
                    task1.condition = "Производится взвешивание стандартных узлов. Систематические ошибки " +
                        "взвешивания отсутствуют, а случайные – подчинены нормальному закону " +
                        "с σ = " + σ + " кг. С какой вероятностью ошибка очередного взвешивания не превысит " +
                        "по абсолютной величине " + val + " кг?";
                    task1.answers.Add(String.Format("P(|X| < " + val + ") = 2Ф({0:0.00})", val / σ));
                    return task1;
                case 2:
                    Task task2 = new Task(20, 2);
                    var mou = Convert.ToDouble(random.Next(13, 20));

                    task2.condition = "Время T безотказной работы тягового электродвигателя распределено по экспоненциальному закону с математическим ожиданием " +
                        (int)mou + " месяцев. Какова вероятность того, что данный двигатель откажет:";
                    task2.questions.Add("Менее чем через месяц после ремонта.");
                    task2.questions.Add("Не менее чем через год после ремонта.");
                    double ly = 1 / mou;
                    task2.answers.Add(String.Format("1-{0:0.000}*e^(-{1:0})", ly, ly * mou));
                    task2.answers.Add(String.Format("1-{0:0.000}*e^(-{1:0.000})", ly, ly * 12));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType18(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(21, 1);
                    int sigma = random.Next(2, 10 + 1);
                    int mx = random.Next(30, 50 + 1);
                    int a = random.Next(mx - 10, mx - 5);
                    int b = random.Next(mx + 5, mx + 11);
                    task1.condition = "Время формирования поездов подчиняется нормальному закону распределения " +
                        "со средним квадратическим отклонением "+ sigma + " мин и средним значением "+ mx + " мин. " +
                        "Определить вероятность того, что время формирования поезда примет значение " +
                        "в интервале от "+a+" до "+b+" мин.";

                    task1.answers.Add(String.Format("P("+a+" < X < "+b+") = Ф({0:0.00}) - Ф({1:0.00})",
                        (b-mx)/((double) sigma), (a-mx)/((double) sigma)));
                    return task1;
                case 2:
                    
                    Task task2 = new Task(21, 2);

                    var gamma = random.Next(8) * 5 + 15;
                    var error = random.Next(8) * 5 + 15;

                    task2.condition = "Случайные ошибки измерения подчинены нормальному закону со " +
                        "средним квадратическим отклонением " + gamma + " мм и математическим ожиданием, равным нулю. " +
                        "Найти вероятность того, что измерение будет произведено с ошибкой, не превосходящей " +
                        "по абсолютной величине " + error + " мм.";

                    task2.answers.Add(String.Format("2Ф({0:0.0000})", Convert.ToDouble(error) / Convert.ToDouble(gamma)));

                    return task2;
            }
            throw new ArgumentException();
        }

        private static double Factorial(double n) {
            if (n <= 0) return 1;
            return n * Factorial(n - 1);
		}
        private static double C(double n, double k) {
            return Convert.ToDouble(Factorial(n)) / Convert.ToDouble((Factorial(k) * Factorial(n - k)));
		}

        public static string EndingNoun(int number)
        {
            string singularForm = ""; 
            string pluralForm1 = "а";
            string pluralForm2 = "ов";
            number = Math.Abs(number) % 100;
            int remainder = number % 10;

            if (number > 10 && number < 20)
            {
                return pluralForm2;
            }

            if (remainder > 1 && remainder < 5)
            {
                return pluralForm1;
            }

            if (remainder == 1)
            {
                return singularForm;
            }

            return pluralForm2;
        }
        public static string EndingAdj(int number)
        {
            string singularForm = "ый";
            string pluralForm1 = "ых";
            string pluralForm2 = "ых";
            number = Math.Abs(number) % 100;
            int remainder = number % 10;

            if (number > 10 && number < 20)
            {
                return pluralForm2;
            }

            if (remainder > 1 && remainder < 5)
            {
                return pluralForm1;
            }

            if (remainder == 1)
            {
                return singularForm;
            }

            return pluralForm2;
        }

    }
}
