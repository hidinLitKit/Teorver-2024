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
                case 19:
                    return CreateTaskType19(ref random, subtype == 0 ? randomSubtype : subtype);
                case 20:
                    return CreateTaskType20(ref random, subtype == 0 ? randomSubtype : subtype);
                case 21:
                    return CreateTaskType21(ref random, subtype == 0 ? randomSubtype : subtype); 
            }
            throw new NotImplementedException();
        }

        private static Task CreateTaskType1(ref Random random, int subtype)
		{
            switch (subtype)
            {
                case 1:


                    Task task1 = new Task(1, 1);
                    var totalRooms = 4 + Convert.ToInt32(Math.Floor(random.NextDouble() * 3));
                    var sndNum = 1;
                    for (int i = 0; i < totalRooms; i++)
                    {
                        sndNum *= (10 - i);
                    }
                    var numString = (totalRooms == 4) ? "10" : (totalRooms == 5) ? "15" : "20";
                    task1.condition = "В университете после обеда оказалось свободным " + numString + " аудиторий. Преподаватель Иваненко, Петренко и " +
                        "Сидоренко случайным образом занимают аудитории для консультаций со студентами." +
                        "Какова вероятность того, что: ";
                    task1.questions.Add("аудитории №401, №405. №406 займут соответственно Иваненко, Петренко и Сидоренко;");
                    task1.questions.Add("аудитория №433 не будет занята Иваненко?");



                    task1.answers.Clear();
                    double probQuestionA = 1.0 / (totalRooms * (totalRooms - 1) * (totalRooms - 2)); // 1/(N*(N-1)*(N-2))
                    task1.answers.Add(String.Format("1/{0:0} ≈ {1:0.00000}", totalRooms * (totalRooms - 1) * (totalRooms - 2), probQuestionA));


                    if (totalRooms >= 433)
                    {
                        task1.answers.Add("Невозможно, так как аудитории №433 нет среди свободных.");
                    }
                    else
                    {
                        double probQuestionB = (totalRooms - 1.0) / totalRooms; // (N-1)/N
                        task1.answers.Add(String.Format("{0:0}/{1:0} ≈ {2:0.000000}", totalRooms - 1, totalRooms, probQuestionB));
                    }


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



                    var totalPosters = 20 + Convert.ToInt32(Math.Floor(random.NextDouble() * 11)); // 20 to 30 posters
                    var analyticGeometryPosters = 10 + Convert.ToInt32(Math.Floor(random.NextDouble() * 6)); // 10 to 15 posters for analytic geometry
                    var calculusPosters = 5 + Convert.ToInt32(Math.Floor(random.NextDouble() * 6)); // 5 to 10 posters for calculus
                    var pickedPosters = 5;

                    var task1 = new Task(2, 1);

                    task1.condition = $"На кафедре математики в шкафу хранятся {totalPosters} свернутых в рулоны плакатов, из которых {analyticGeometryPosters} — для занятий по аналитической геометрии, а {calculusPosters} — по математическому анализу. Преподаватель берет {pickedPosters} рулонов наугад.";

                    task1.questions.Add("Три плаката будут по аналитической геометрии.");
                    task1.questions.Add("Два плаката — по аналитической геометрии и два — по математическому анализу.");

                    double result1 = (double)(C(analyticGeometryPosters, 3) * C(totalPosters - analyticGeometryPosters, 2)) / C(totalPosters, pickedPosters);
                    double result2 = (double)(C(analyticGeometryPosters, 2) * C(calculusPosters, 2) * C(totalPosters - analyticGeometryPosters - calculusPosters, 1)) / C(totalPosters, pickedPosters);

                    task1.answers.Add(String.Format("C({0:0},{1:0})*C({2:0},{3:0})/C({4:0},{5:0}) ≈ {6:0.0000}", analyticGeometryPosters, 3, totalPosters - analyticGeometryPosters, 2, totalPosters, pickedPosters, result1));
                    task1.answers.Add(String.Format("C({0:0},{1:0})*C({2:0},{3:0})*C({4:0},{5:0})/C({6:0},{7:0}) ≈ {8:0.0000}", analyticGeometryPosters, 2, calculusPosters, 2, totalPosters - analyticGeometryPosters - calculusPosters, 1, totalPosters, pickedPosters, result2));


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

                    task1.condition = "Опыт заключается в бросании двух монет. Рассматриваются следующие события: " +
                        "A — появление герба на первой монете; B — появление герба на второй монете; " +
                        "D — появление решки на второй монете. Составить множество элементарных исходов для данного " +
                        "опыта и определить состав подмножеств, соответствующих событиям: ";

                    task1.questions.Add("B ∪ D");
                    task1.questions.Add("A ∩ B");
                    task1.answers.Add("B ∪ D = {HH, HT, TH, TT} - всевозможные события");
                    task1.answers.Add("A ∩ B = {HH}");
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


                    double jokeProb = (random.Next(1, 10)) / 10.0;  // Вероятность того, что кандидат шутит
                    double lifeExampleProb = (random.Next(1, 10)) / 10.0;  // Вероятность того, что кандидат приводит личные примеры

                    Task task1 = new Task(4, 1);
                    task1.condition = "Кандидат в депутаты во время выступления на публике с вероятностью " + jokeProb +
                        " шутит и рассказывает анекдоты, с вероятностью " + lifeExampleProb + " приводит примеры из собственной жизни. " +
                        "Какова вероятность того, что на очередной встрече с трудящимися:";

                    task1.questions.Add("он ни разу не пошутит;");
                    task1.questions.Add("воспользуется обоими приемами общения с публикой;");
                    task1.questions.Add("обойдется без личных примеров?");

                    double noJokes = 1 - jokeProb; // Не шутит
                    double both = jokeProb * lifeExampleProb; // Использует оба приема
                    double noExamples = 1 - lifeExampleProb; // Без личных примеров

                    task1.answers.Add(string.Format("{0:0.00}", noJokes));
                    task1.answers.Add(string.Format("{0:0.00}", both));
                    task1.answers.Add(string.Format("{0:0.00}", noExamples));

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



                    double winProb = random.Next(1, 8) / 10.0; // Вероятность выигрыша балерины в одной партии
                    double drawProb = random.Next(1, 10 - (int)(winProb * 10) - 1) / 10.0; // Вероятность ничьей
                    double lossProb = 1.0 - winProb - drawProb; // Вероятность проигрыша (выигрыша вахтера)

                    Task task1 = new Task(5, 1);
                    task1.condition = "Известная в городе балерина любит играть в шашки с вахтером театра. Вероятность ее выигрыша в одной партии равна " +
                        winProb + ", вероятность ничьей — " + drawProb + ". Какова вероятность того, что балерина выиграла партий больше, чем вахтер?";

                    double winMoreThanLoss = (winProb * winProb * winProb) +
                                             (3 * winProb * winProb * lossProb) +
                                             (3 * winProb * winProb * drawProb);

                    task1.answers.Add(string.Format(" {0:0.0000}", winMoreThanLoss));
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


                    int totalBooks = 100;
                    int newBooks = random.Next(1, 5) * 5;
                    int booksPicked = 3;

                    Task task1 = new Task(6, 1);
                    task1.condition = "На стеллаже в библиотеке стоят " + totalBooks + " книг по математике, " +
                        newBooks + " из которых новые (2009 года издания). Библиотекарь наугад взял " +
                        booksPicked + " учебника. Найти вероятность того, что они окажутся новыми.";

                    // Вычисление вероятности
                    double probability = CalculateCombination(newBooks, booksPicked) / CalculateCombination(totalBooks, booksPicked);
                    task1.answers.Add(string.Format(" {0:0.000000}", probability));

                    static double CalculateCombination(int n, int k)
                    {
                        return Factorial(n) / (Factorial(k) * Factorial(n - k));
                    }

                    static double Factorial(int number)
                    {
                        double result = 1;
                        for (int i = 2; i <= number; i++)
                        {
                            result *= i;
                        }
                        return result;
                    }


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
                    double probFlower1 = Math.Round(0.1 + random.NextDouble() * 0.8, 1);
                    double probFlower2 = Math.Round(0.1 + random.NextDouble() * (0.8 - probFlower1), 1);
                    double probFlower3 = Math.Round(1 - probFlower1 - probFlower2, 1);

                    // Корректировка если сумма вероятностей не равна 1
                    if (probFlower3 < 0.1 || probFlower3 > 0.9)
                    {
                        probFlower1 = Math.Round(0.1 + random.NextDouble() * 0.5, 1);
                        probFlower2 = Math.Round(0.1 + random.NextDouble() * (0.4 - probFlower1), 1);
                        probFlower3 = Math.Round(1 - probFlower1 - probFlower2, 1);
                    }

                    // Генерация случайных вероятностей для похода в музей
                    double probMuseum1 = Math.Round(0.1 + random.NextDouble() * 0.8, 1);
                    double probMuseum2 = Math.Round(0.1 + random.NextDouble() * 0.8, 1);
                    double probMuseum3 = Math.Round(0.1 + random.NextDouble() * 0.8, 1);


                    Task task1 = new Task(7, 1);
                    task1.condition = "Студент Лямурский Петя любит дарить девушкам цветы: " +
                        "маргаритки он дарит с вероятностью " + probFlower1 + ", хризантемы — " + probFlower2 +
                        ", герань, выращенную его бабушкой, — с вероятностью " + probFlower3 + ". Девушки, " +
                        "одаренные маргаритками, идут с Петей в палеонтологический музей с вероятностью" +
                        +probMuseum1 + ", получившие хризантемы, — с вероятностью " + probMuseum2 + ", " +
                        "герань — " + probMuseum3;

                    double totalProbability = (probFlower1 * probMuseum1) + (probFlower2 * probMuseum2) + (probFlower3 * probMuseum3);

                    task1.answers.Add(string.Format("Вероятность того, что знакомая Пети провела вечер в музее: {0:0.0000}", totalProbability));

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
                    Task task1 = new Task(8, 2);

                    int[] rabbitPercentages = new int[] {
                        random.Next(1, 11),  // Для первого маршрута от 1% до 10%
                        random.Next(1, 11),  // Для второго маршрута от 1% до 10%
                        random.Next(1, 11)   // Для третьего маршрута от 1% до 10%
                        };
                    // Отношения пассажиров между маршрутами
                    double passengerRatioRoute2 = 1;  // Примем число пассажиров второго маршрута за базовое
                    double passengerRatioRoute1 = 3 * passengerRatioRoute2;  // Втрое больше на первом
                    double passengerRatioRoute3 = 1.5 * passengerRatioRoute2;  // В полтора раза больше на третьем

                    // Общее число пассажиров, пропорционально
                    double totalPassengers = passengerRatioRoute1 + passengerRatioRoute2 + passengerRatioRoute3;

                    // Вероятности, что пенсионер приехал на каждом маршруте
                    double[] probabilities = new double[3];

                    for (int i = 0; i < 3; i++)
                    {
                        probabilities[i] = (rabbitPercentages[i] / 100.0) * (passengerRatioRoute1 / totalPassengers);
                    }
                    double maxProbability = 0;
                    int likelyRoute = 0;
                    for (int i = 0; i < probabilities.Length; i++)
                    {
                        if (probabilities[i] > maxProbability)
                        {
                            maxProbability = probabilities[i];
                            likelyRoute = i + 1;
                        }
                    }

                    task1.condition = " Контролер работает на трех автобусных маршрутах.Число пассажиров первого маршрута втрое превышает число пассажиров второго " +
            "и в полтора раза — третьего. Процент «зайцев» на этих маршрутах составляет " + rabbitPercentages[0] + ", " + rabbitPercentages[1] + " и " + rabbitPercentages[2] + " соответственно. " +
            "Пассажир, случайно пойманный контролером на остановке «Вокзал», оказался пенсионером, имеющим право на бесплатный проезд. " +
            "Каким маршрутом вероятнее всего приехал пенсионер?";
                    task1.answers.Add($" {likelyRoute}");

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
                    int n = 8;
                    int k = random.Next(1, 9);

                    Task task1 = new Task(9, 1);
                    task1.condition = $"В ячейку памяти записывается 8-разрядное двоичное число. Значения 0 и 1 в каждом разряде появляются с равной вероятностью. Найти вероятность того, что в записи двоичного числа содержится {k} единиц.";

                    double probability = CalculateCombination(n, k) * Math.Pow(0.5, n);
                    task1.answers.Add($" {probability:0.000000}");

                    static double CalculateCombination(int n, int k)
                    {
                        if (k > n) return 0;
                        if (k == 0 || k == n) return 1;
                        if (k > n - k) k = n - k; // Симметрия C(n, k) == C(n, n-k)
                        double result = 1;
                        for (int i = 0; i < k; i++)
                        {
                            result *= (n - i) / (double)(i + 1);
                        }
                        return result;
                    }

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


                    // var testCount = random.Next(7,10) * 100;
                    //var prob = random.Next(5, 15) / 20.0;
                    // var equalCount = random.Next(5,10) * 50;

                    //var startCount = random.Next(2, 6) * 50;
                    //var endCount = random.Next(6, 11) * 50;


                    int totalTickets = 500;  // Общее количество билетов
                    double lossProb = random.Next(10, 80) / 100.0;  // Вероятность проигрыша от 0.1 до 0.79

                    int minCount = random.Next(1, 5) * 10;  // Минимальное количество проигрышных билетов от 10 до 40
                    int maxCount;
                    do
                    {
                        maxCount = random.Next(5, 11) * 10;  // Максимальное количество проигрышных билетов от 50 до 100
                    } while (maxCount <= minCount);

                    int equalCount = totalTickets / 2;  // Ровно половина билетов

                    task1.condition = $"Вероятность покупки в лотерее проигрышного билета составляет {lossProb}. " +
                        $"Какова вероятность того, что из {totalTickets} наугад приобретенных билетов будут без выигрыша:";
                    task1.questions.Add($"не менее {minCount} и не более {maxCount} билетов;");
                    task1.questions.Add($"ровно {equalCount} билетов;");

                    double probRange = CalculateBinomialRangeProbability(totalTickets, lossProb, minCount, maxCount);
                    double probExact = CalculateBinomialProbability(totalTickets, lossProb, equalCount);

                    task1.answers.Add($"Вероятность, что проигрышных билетов будет от {minCount} до {maxCount}: {probRange:0.0000}");
                    task1.answers.Add($"Вероятность, что проигрышных билетов будет ровно {equalCount}: {probExact:0.0000}");

                    static double CalculateBinomialProbability(int n, double p, int k)
                    {
                        return Choose(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
                    }

                    static double CalculateBinomialRangeProbability(int n, double p, int k1, int k2)
                    {
                        double totalProb = 0;
                        for (int k = k1; k <= k2; k++)
                        {
                            totalProb += CalculateBinomialProbability(n, p, k);
                        }
                        return totalProb;
                    }

                    static double Choose(int n, int k)
                    {
                        if (k > n) return 0;
                        if (k == 0 || k == n) return 1;
                        double result = 1;
                        for (int i = 1; i <= k; i++)
                        {
                            result *= (n - (k - i)) / (double)i;
                        }
                        return result;
                    }

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


                    int n = random.Next(1, 9 + 1) * 100; // Количество изделий
                    double p = Math.Round(0.001 + random.NextDouble() * 0.008, 3); // Вероятность отказа одного изделия

                    task1.condition = $"Вероятность того, что изделие не выдержит испытание, равна {p}. " +
                        $"Найти вероятность того, что из {n} изделий более чем одно не выдержит испытание.";

                    double prob0 = Math.Pow(1 - p, n);
                    double prob1 = n * p * Math.Pow(1 - p, n - 1);

                    double probMoreThanOne = 1 - (prob0 + prob1);

                    task1.answers.Add($" {probMoreThanOne:0.0000}");


                    return task1;
                case 2:
                    Task task2 = new Task(11, 2);

                    int _n = random.Next(1800, 2200);
                    double _p = random.Next(1, 10) / 10000.0;
                    double q = 1 - _p;
                    task2.condition = $" Аппаратура содержит {_n} одинаково надежных элементов; вероятность отказа для каждого из них " +
                        $"равна {_p}.Какова вероятность отказа данной аппаратуры, если он наступает при отказе хотя бы одного элемента?";
                    //double x = (studentsAmount - allStudentsAmount * (1 / 365.0)) / Math.Sqrt(allStudentsAmount * (1 / 365.0) * (1 - 1 / 365.0));
                    //double k = 1 / Math.Sqrt(allStudentsAmount * (1 / 365.0) * (1 - 1 / 365.0));
                    // task2.answers.Add(string.Format("1/√("+ allStudentsAmount + "*(1/365)*(1-1/365)) * φ({0:0.00}) ≈ {1:0.00} * φ({0:0.00})", x, k));
                    var ans = 1 - ((1 / Math.Sqrt(_n*_p*q))*0.3989);
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
                    double pe = random.Next(2, 9) / 10.0;  // Вероятность правильного ответа на вопрос
                    int maxQuestions = 3;  // Максимальное количество вопросов

                    Task task1 = new Task(12, 1);
                    task1.condition = $"Экзаменатор задает студенту дополнительные вопросы. " +
                        $"Вероятность того, что студент ответит на любой заданный вопрос, равна {pe}. " +
                        $"Преподаватель задает не более трех вопросов и прекращает экзамен, " +
                        $"как только студент обнаруживает незнание ответа.";
                    task1.questions.Add("Составить ряд распределения случайной величины X — числа " +
                        "дополнительных вопросов, которые задаст преподаватель.");
                    task1.questions.Add("Найти M(X), D(X), σ(X), F(X) этой случайной величины.");

                    double[] k = new double[maxQuestions + 1];
                    double cumProbability = 0;
                    double MX = 0;
                    double DX = 0;

                    // Расчет вероятностей и накопленной функции распределения
                    for (int x = 0; x < maxQuestions; x++)
                    {
                        k[x] = Math.Pow(pe, x) * (1 - pe);
                        cumProbability += k[x];
                        MX += x * k[x];
                        DX += x * x * k[x];
                        task1.answers.Add($"P(x = {x}) = {k[x]:0.0000}");
                    }
                    k[maxQuestions] = Math.Pow(pe, maxQuestions);
                    cumProbability += k[maxQuestions];
                    MX += maxQuestions * k[maxQuestions];
                    DX += maxQuestions * maxQuestions * k[maxQuestions];
                    task1.answers.Add($"P(x = {maxQuestions}) = {k[maxQuestions]:0.0000}");

                    DX = DX - MX * MX;
                    double sigmaX = Math.Sqrt(DX);

                    // Добавление математического ожидания, дисперсии и стандартного отклонения
                    task1.answers.Add($"\nM(X) = {MX:0.0000}");
                    task1.answers.Add($"D(X) = {DX:0.0000}");
                    task1.answers.Add($"σ(X) = {sigmaX:0.0000}");

                    // Функция распределения
                    string fX = "F(X) = \n    ⎧ 0, x ≤ 0\n";
                    double F = 0;
                    for (int i = 0; i <= maxQuestions; i++)
                    {
                        F += k[i];
                        fX += $"    ⎨ {F:0.0000}, {i} < x ≤ {i + 1}\n";
                    }
                    fX += $"    ⎩ 1.0000, x > {maxQuestions}";
                    task1.answers.Add(fX);
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
                    int n = random.Next(1, 9);
                    double pe = random.Next(2, 9) / 10.0;

                    task1.condition = "Отдел технического контроля проверяет изделия на " +
                        "стандартность. Вероятность того, что изделие стандартно, " +
                        "равна " + pe + ". В партии " + n + " изделий.";
                    task1.questions.Add("Составить ряд распределения числа стандартных деталей в партии из " + n + " изделий.");
                    task1.questions.Add("Найти M(X) и D(X) этой случайной величины.");

                    string distribution = "";
                    double MX = 0;
                    double DX = 0;

                    for (int k = 0; k <= n; k++)
                    {
                        double prob = Choose(n, k) * Math.Pow(pe, k) * Math.Pow(1 - pe, n - k);
                        distribution += $"P(x = {k}) = {prob:0.0000}\n";
                        MX += k * prob;
                        DX += k * k * prob;
                    }
                    DX = DX - MX * MX;

                    static double Choose(int n, int k)
                    {
                        if (k > n) return 0;
                        if (k == 0 || k == n) return 1;
                        double result = 1;
                        for (int i = 1; i <= k; i++)
                        {
                            result *= (n - (k - i)) / (double)i;
                        }
                        return result;
                    }

                    task1.answers.Add(distribution);
                    task1.answers.Add($"M(X) = {MX:0.0000}");
                    task1.answers.Add($"D(X) = {DX:0.0000}");

                    return task1;
                case 2:
                    Task task2 = new Task(13, 2);
                    
                    int _n = random.Next(5, 10);
                    double ver = random.Next(6, 9) / 10.0;
                    task2.condition = $"Составить ряд распределения дискретной случайной величины X — числа отказов элемента некоторо гоустройства " +
                        $"в {_n} независимых опытах, если вероятность отказа элемента в каждом опыте" +
                        $" равна {ver}.Найти M(X) и D(X).";

                    double[] p = new double[_n + 1];
                    for (int i = 0; i < p.Length; i++)
                        p[i] = C(_n, i) * Math.Pow(ver, _n);

                    string str = "";
                    for (int i = 0; i < p.Length; i++)
                        str += "P(x=" + i + ")=C(" + _n + "," + i + ")*0.5^" + _n + "=" + p[i] + "\n";
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
                    int n = 100; // Количество абонентов
                    double pe = random.Next(2, 9) / 100.0; // Вероятность того, что абонент позвонит в течение минуты
                    double a = n * pe;
                    task1.condition = $"Коммутатор учреждения обслуживает {n} абонентов. Вероятность того, что в течение одной минуты абонент позвонит на коммутатор, равна {pe}.";
                    task1.questions.Add("Составить ряд распределения числа абонентов, которые могут позвонить на коммутатор в течение одной минуты.");
                    task1.questions.Add("Найти M(X) этой случайной величины.");


                    task1.answers.Add(String.Format("Pn(m) = {0:0.0}^m * 1/m! * e^(-{0:0.0})", a));
                    task1.answers.Add($"M(X) = {a:0.0000}");


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

        private static Task CreateTaskType16(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(16, 1);


                    var alpha = random.Next(-1, 5);
                    var beta = random.Next(3, 12);

                    task1.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\n" +
                        "F(x) =\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ x/4, 0 < x ≤ 4\n" +
                        "     ⎩ 1, x > 4\n" +
                        "α = " + alpha + ", β = " + beta + "\n" +
                        "Требуется:";
                    task1.questions.Add("Найти плотность вероятности f(x).");
                    task1.questions.Add("Построить графики F(x) и f(x).");
                    task1.questions.Add("Найти P(α < X < β) для данных α, β.");


                    task1.answers.Add("\nf(x) = \n    ⎧ 0, x ≤ 0\n    ⎨ x/4, 0 < x ≤ 10\n    ⎩ 0, x > 4");
                    task1.answers.Add("");
                    task1.answers.Add(String.Format("P(α < X < β) = {0:0.0000}", (beta * beta / 100.0) - (alpha * alpha / 100.0)));
                    return task1;
                case 2:
                    Task task2 = new Task(16, 2);

                    var beta2 = random.Next(11, 20)/10.0;
                    var alpha2 = random.Next(0, 10)/10.0;
                    

                    task2.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\n" +
                        "F(x) =\n" +
                        "     ⎧ 0, x ≤ 0\n" +
                        "     ⎨ x²/4, 0 < x ≤ 2\n" +
                        "     ⎩ 1, x > 2\n" +
                        "α = " + alpha2 + ", β = " + beta2 + "\n" +
                        "Требуется:";
                    task2.questions.Add("Найти плотность вероятности f(x).");
                    task2.questions.Add("Найти M(x), D(x), σ(x)");
                    task2.questions.Add("Найти P(α < X < β) для данных α,β.");
                    Func<double, double> MX = x => (Math.Pow(x,3) )/ 6.0;
                    Func<double, double> DX = x => x * x * x* x / 8.0;
                    double mx = MX(2.0) - MX(0.0);
                    double dx = DX(2.0) - DX(0.0) - mx*mx;
                    double s = Math.Sqrt(dx);
                    task2.answers.Add("\nf(x) = \n    ⎧ 0, x ≤ 0\n    ⎨ x/2, 0 < x ≤ 2\n    ⎩ 0, x > 2");
                    task2.answers.Add(String.Format("M(x) = {0:0.0000}, D(x) = {1:0.0000}, σ(x) = {2:0.0000}",mx,dx,s));
                    task2.answers.Add(String.Format("P(α < X < β) = {0:0.0000}", (beta2 * beta2/4.0) - (alpha2* alpha2/4.0)));
                    return task2;
            }
            throw new ArgumentException();
        }

        static double fun(double x)
        {
            return x * x * x / 3.0 - 3 * x * x + 8 * x;
        }

        private static Task CreateTaskType17(ref Random random, int subtype)
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
                        "     ⎨ a(1-x), " + start + " ≤ x < " + end + "\n" +
                        "     ⎩ 0, x > " + end;
                    task1.questions.Add("Найти параметр a.");
                    task1.questions.Add("Построить функцию распределения F(X).");
                    task1.questions.Add("Построить графики f(X) и F(X).");

                    double ot = 1 / ((double)end - ((double)end * (double)end / 2) - ((double)start - ((double)start * (double)start / 2)));
                    task1.answers.Add(string.Format("A={0:0.0000}", ot));
                    double f1 = ot;
                    double f2 = ot * ot;
                    double f3 = start * ot + (start * start) / 2 * ot;

                    task1.answers.Add(
                        "F(x)=\n" +
                                     "     ⎧ 0, x < " + start + '\n' +
                                     "     ⎨ " + string.Format("{0:0.000}x²+{1:0.000}x-{2:0.000}", f1, f2, f3) + ", " + start + " ≤ x ≤ " + end + '\n' +
                                     "     ⎩ 1, x > " + end
                        );

                    return task1;
                case 2:
                    
                    var b=random.Next(2, 5);
                    var a=random.Next(1, b-1);
                    Task task2 = new Task(17, 2);
                    task2.condition = "Дана функция распределения F(x) непрерывной случайной величины X:\nf(x)=\n"+
                                     "     ⎧ 0, x < " + a + '\n' +
                                     "     ⎨ a(6x² - x - 3), " + a + " ≤ x ≤ " + b + '\n' +
                                     "     ⎩ 0, x > " + b;
                    task2.questions.Add("Найти параметр a.");
                    task2.questions.Add("Найти функцию распределения F(x).");
                    Func<double, double> integral1 = x => 2.0 * Math.Pow(x, 3) - 0.5 * Math.Pow(x, 2) - 3 * x;
                    double _ot = 1 / ( integral1(b)-integral1(a) );
                    task2.answers.Add(string.Format("A={0:0.0000}",_ot));

                    double C = integral1(a);
                    task2.answers.Add(
                        "F(x)=\n" +
                                     "     ⎧ 0, x < " + a + '\n' +
                                     "     ⎨ " + string.Format("{0:0.000}(2x³ - 0.5x² - 3x + ({1:0.000}))", _ot,C) + ", " + a + " ≤ x ≤ " + b + '\n' +
                                     "     ⎩ 1, x > " + b
                        );

                    Func<double, double> integralMat = x => _ot * (2.5*Math.Pow(x,4) - Math.Pow(x,3)/3.0 - 1.5*Math.Pow(x,2) );
                    double matx = integralMat(b)-integralMat(a);
                    Func<double, double> integralAs = x => _ot*(Math.Pow(x - matx, 4) * (4 * x * (5 * x + 2 * matx - 1) + (matx - 3) * (2 * matx + 5))) / 20;
                    Func<double, double> integralEk = x => _ot * ((Math.Pow(x - a , 5) * (5 * x * (36 * x + 12 * matx- 7) + 12 * matx*matx - 7 * matx - 126)) / 210);
                    double _as = integralAs(b) - integralAs(a);
                    double _ek = integralEk(b) - integralEk(a);
                    task2.answers.Add(string.Format("As = {0:0000}, Ek = {1:0000}", _as, _ek));
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
            return x* x * (1.0 / 3.0);
        }
        static double fun5(double x)
        {
            return ((-(x * x) - 5) / 6.0 + x + 1.0 / 3.0);
        }
    static double PforTask18(double down, double up)
        {
            Func<double, double> firstx = x => (Math.Pow(x + 3, 3) ) / 103.0;
            Func<double, double> secondx = x => (( 3 * x )/ 17.0 ) - ( ( 3 * x * x )/ 136.0);
            double first = firstx(0) - firstx(down);
            double second = secondx(up) - secondx(0);
            return first + second;
        }
        private static Task CreateTaskType18(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(18, 1);

                    var aa1 = random.Next(0, 11) / -10.0 + 0.5;
                    var bb1 = random.Next(0, 3) * 0.5 + 1;

                    task1.condition = "Дана плотность вероятности f(x) непрерывной случайной величины X, " +
                        "имеющая две ненулевые составляющие формулы:\nf(x)=\n" +
                                     "     ⎧ 0, x ≤ 0" + '\n' +
                                     "     ⎨ 2x/5, 0 ≤ x ≤ 1" + '\n' +
                                     "     ⎨ 2/5, 1 ≤ x ≤ 3" + '\n' +
                                     "     ⎩ 0, x > 3" + '\n' +
                                     "α=" + aa1 + ",β=" + bb1 + '\n' +
                                     "Требуется:";

                    task1.questions.Add("Проверить свойство -∞∫∞(f(x)dx)=1.");
                    task1.questions.Add("Найти функцию распределения F(x).");
                    task1.questions.Add("Найти P(α≤x≤β) для данных α,β.");
                    task1.questions.Add("Найти M(X),D(x),σ(X).");
                    task1.questions.Add("Построить график f(x).");

                    task1.answers.Add("Условие выполняется.");
                    task1.answers.Add("F(x)=" + '\n' +
                                      "     ⎧ 0, x ≤ 0" + '\n' +
                                      "     ⎨ x²/5, 0 ≤ x ≤ 1" + '\n' +
                                      "     ⎨ 2x/5, 1 ≤ x ≤ 3" + '\n' +
                                      "     ⎩ 1, x > 3");

                    var realA1 = aa1 < 0 ? 0 : aa1;
                    var realB1 = bb1 > 3 ? 3 : bb1;

                    double ot3 = fun5(realB1) - fun4(realA1);
                    task1.answers.Add("P(α≤x≤β) = " + String.Format("{0:0.000}", ot3));

                    double x1 = 4.0 / 3.0, x2 = 7.0 / 18.0, x3 = Math.Sqrt(7.0 / 18.0);
                    task1.answers.Add(string.Format("M(X)={0:0.000}, D(X)={1:0.000}, σ(X)={2:0.000}", x1, x2, x3));
                    return task1;

                case 2:
                    Task task2 = new Task(18, 2);

                    var aa2 = random.Next(-30, 0) / 10.0;
                    var bb2 = random.Next(0, 40) /  10.0;

                    task2.condition = "Дана плотность вероятности f(x) непрерывной случайной величины X, имеющая две ненулевые составляющие формулы:\nf(x)=\n" +
                                     "     ⎧ 0, x ≤ -3" + '\n' +
                                     "     ⎨ 1/27 (x+3)², -3 < x ≤ 0" + '\n' +
                                     "     ⎨ 1/3 - x/12, 0 < x ≤ 4" + '\n' +
                                     "     ⎩ 0, x > 3" + '\n' +
                                     "α=" + aa2 + ",β=" + bb2 + '\n' +
                                     "Требуется:";

                    task2.questions.Add("Проверить свойство -∞∫∞(f(x)dx)=1.");
                    task2.questions.Add("Найти функцию распределения F(x).");
                    task2.questions.Add("Найти P(α≤x≤β) для данных α,β.");
                    task2.questions.Add("Найти M(X),D(x),σ(X).");
                    task2.questions.Add("Построить график f(x).");

                    task2.answers.Add("Условие не выполняется.");
                    task2.answers.Add("F(x)="+'\n' +
                                      "     ⎧ 0, x ≤ -3" + '\n' +
                                      "     ⎨ (x+3)³/ 103, -3 < x ≤ 0" + '\n' +
                                      "     ⎨ 27/103 + 3x/17 - 3x²/136, 0 < x ≤ 4" + '\n' +
                                      "     ⎩ 1, x > 4");

                    double _ot3 = PforTask18(aa2,bb2);
                    task2.answers.Add("P(α≤x≤β) = " + String.Format("{0:0.000}", _ot3));

                    double _x1 = 0.34, _x2 = 0.98, _x3 = 0.98;
                    task2.answers.Add(string.Format("M(X)={0:0.000}, D(X)={1:0.000}, σ(X)={2:0.000}", _x1, _x2, _x3));
                    return task2;
            }
            throw new ArgumentException();
        }
        
        private static Task CreateTaskType19(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(19, 1);
                    double m = random.Next(1, 8); // среднее значение (математическое ожидание)
                    double sigma = random.Next(1, 8) * 10 / 100.0; ; // стандартное отклонение
                    double gran = random.Next(1, 9) / 10.0;

                    task1.condition = "Диаметр детали — случайная величина X с нормальным законом распределения" + m + " см; " + sigma + " см).";
                    task1.questions.Add("В каком интервале должны находиться диаметры деталей, чтобы вероятность невыхода за границы интервала была равна " + gran + "?");

                    // Значение z для 95% доверительного интервала (для двустороннего интервала это ±1.96)
                    double z = 1.96;

                    double lowerBound = m - z * sigma; // Нижняя граница интервала
                    double upperBound = m + z * sigma; // Верхняя граница интервала

                    task1.answers.Add($" от {lowerBound:0.0000} см до {upperBound:0.0000} см.");

                    return task1;
                case 2:
                    Task task2 = new Task(19, 2);
                    double sigma2 = (double)random.Next(1, 10);
                    double mat = (double) random.Next(70, 90);
                    double alpha = (double)random.Next(50, 60);
                    double beta = (double)random.Next(90, 100);
                    Func<double, double> phi = x => (x - mat) / (sigma2);
                    task2.condition = $"Динамическая нагрузка X на соединительную раму тележек восьмиосного вагона имеет " +
                        $"нормальное распределение(m = {mat} т; σ = {sigma2} т). Какова вероятность диапазона нагрузок от {alpha} до {beta} т ?";
                    task2.answers.Add(string.Format("Ф({0:0.00})-Ф({1:0.00})",phi(beta),phi(alpha)));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType20(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:

                    double lambda = 0.037; // Параметр λ экспоненциального распределения

                    Task task1 = new Task(20, 1);
                    task1.condition = "Случайная величина T имеет плотность вероятности f(t) = 0.037e^–0.037t(t ≥ 0).";
                    task1.questions.Add("Найти числовые характеристики: MT, DT, σ(T).");

                    double MT = 1 / lambda;
                    double DT = 1 / (lambda * lambda);
                    double sigmaT = Math.Sqrt(DT);

                    task1.answers.Add($"M(T) = {MT:0.0000}"); // Математическое ожидание
                    task1.answers.Add($"D(T) = {DT:0.0000}"); // Дисперсия
                    task1.answers.Add($"σ(T) = {sigmaT:0.0000}"); // Стандартное отклонение

                    return task1;
                case 2:
                    Task task2 = new Task(20, 2);
                    double del = (double)random.Next(2, 5)/10.0;
                    double down = -del * 0.5;
                    double up = del * 0.5;
                    double mistake = (double)random.Next(1, Convert.ToInt32( del*10 )) /100.0;
                    Func<double, double> F = x => (x - down) / (up - down);

                    double p1 = F(mistake) - F(-mistake);
                    double p2 = 1 - p1;

                    task2.condition = $" Цена деления шкалы амперметра равна {del} А. " +
                        $"Показания округляются до ближайшего деления. Найти вероятность того, что при отсчете будет сделана " +
                        $"ошибка не более {mistake} А.";

                    task2.answers.Add(string.Format("P = {0:0.00}",p1));
                    return task2;
            }
            throw new ArgumentException();
        }

        private static Task CreateTaskType21(ref Random random, int subtype)
        {
            switch (subtype)
            {
                case 1:
                    Task task1 = new Task(21, 1);
                    int sigma = random.Next(2, 10 + 1);
                    int m = random.Next(30, 50 + 1);
                    int a = random.Next(m - 10, m - 5);
                    int b = random.Next(m + 5, m + 11);
                    task1.condition = "Время движения поезда по перегону Густафьево–Сыропятское имеет" +
                        " нормальное распределение со средним временем " + m + " мин и стандартным отклонением " + sigma + " мин. " +
                        "Определить вероятность того, что время движения поезда окажется в интервале от " + a + " до " + b + " мин.";

                    // Перевод границ в стандартизированную форму Z
                    double zLower = (a - m) / sigma;
                    double zUpper = (b - m) / sigma;

                    // Вычисление вероятности
                    task1.answers.Add(String.Format("P(" + a + " < X < " + b + ") = 2Ф({0:0.0000}) - 1", (zUpper - zLower) / 2 + Math.Abs(zLower)));

                    return task1;
                case 2:
                    
                    Task task2 = new Task(21, 2);
                    double mat = 9;
                    double sigm = 3;
                    double down = (double)random.Next(0, 7);
                    double up = (double)random.Next(8, 16);
                    Func<double, double> phi = x => (x - mat) / (sigm);


                    task2.condition = $"Случайная величина Х имеет нормальное распределение, " +
                        $"причем m = 9. Вероятность попадания Х в интервал (0; 18) равна 0,9973. ";

                    task2.questions.Add($"Чему равна вероятность попадания X в интервал ({down}; {up})? ");
                    task2.questions.Add($"Записать формулу плотности вероятности f(x).");

                    task2.answers.Add(String.Format("Ф({0:0.00}) - Ф({1:0.00})", phi(up),phi(down)));
                    task2.answers.Add(String.Format("1/({0:0}*sqrt(2pi)) * exp( - (x - {1:0})^2 / 2 * {0:0}^2)", sigm, mat));


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
