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
// Вариант 7 Средний уровень Строковый тип
using System.Text;
try
{
    Console.WriteLine("Введите строку:");
    string text = Console.ReadLine();
    StringBuilder sb = new StringBuilder();
    foreach (char c in text)
    {
        if (c == '!')
        {
            sb.Append(",");
        }
        sb.Append(c);
    }
    string newtext = sb.ToString();
    Console.WriteLine(newtext);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

