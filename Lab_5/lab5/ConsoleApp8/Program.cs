//Вариант 7 Средний уровень Символьный тип
// try
// {
//     string inputText= Console.ReadLine();
//     char[] words = inputText.ToCharArray();
//     Console.WriteLine();
//     string text = new string(words);
//     char[] split = new char[] {' ', '.'};
//     string[] words2 = text.Split(split, StringSplitOptions.RemoveEmptyEntries);
//     foreach (string word in words2)
//     {
//         if (word.Length == 3)
//         {
//             Console.WriteLine(word);
//         }
//     }
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }
// Вариант 12 Средний урвоень Строковый тип
try
{
    Console.Write("Введите количество футболистов:");
    int n = int.Parse(Console.ReadLine());
    futbol[] people = new futbol[n];
    for (int i = 0; i < people.Length; i++)
    {
        Console.WriteLine($"Введите данные об {i + 1} футболисте:");
        Console.Write("Введите фамилию футболиста:");
        people[i].family = Console.ReadLine();
        Console.Write("Введите дату рождения сотрудника:");
        people[i].bornData = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите амплуа футболиста:");
        people[i].bornMesto = Console.ReadLine();
        Console.Write("Введите место рождения футболиста:");
        people[i].amplua = Console.ReadLine();
        Console.Write("Введите количество игр футболиста:");
        people[i].kolIgr = int.Parse(Console.ReadLine());
        Console.Write("Введите количесво желтых карточек:");
        people[i].kolYellowCard = int.Parse(Console.ReadLine());
    }
    foreach (futbol fut in people)
    {
        if (fut.kolIgr / 10 >= fut.kolYellowCard && fut.vozr() > 20)
        {
            fut.Print();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct futbol
{
    public string family;
    public DateTime bornData;
    public string bornMesto;
    public string amplua;
    public int kolIgr;
    public int kolYellowCard;
    public int vozr()
    {
        return Convert.ToInt32((DateTime.Today - bornData).Days / 365.25);
    }
    public void Print()
    {
        Console.WriteLine($"{family} {bornData} {bornMesto} {amplua}" +
            $"{kolIgr} {kolYellowCard} {vozr}");
    }
};



