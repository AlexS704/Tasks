using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    /// <summary>
    /// дана строка be, or not to be?
    /// найди дубликаты слов
    /// 
    /// вывод be
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string freeProposal = "be, or not to be?";

            var words = freeProposal.Split(' ', '.', '!', '?', ',');

            //Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            
            ////foreach (var word in words)
            ////{
            ////    if (!String.IsNullOrWhiteSpace(word))
            ////    {
            ////        if (!wordCounts.ContainsKey(word))
            ////        {
            ////            wordCounts[word]++;
            ////        }
            ////        else
            ////        {
            ////            wordCounts.Add(word, 1);
            ////        }
            ////    }
            ////}

            ////var repatedWords = wordCounts.Where(kvp.Value > 1).Select(kvp => kvp.Key);




        }
    }
}
