using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingPractice
{
    class TestMyPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Iterator...");
            Console.WriteLine("List all theatrical acts and book chapters");
            int[] acts = new int[5] { 1, 2, 3, 4, 5 };
            acts.GetEnumerator();
            Theatre theatre = new Theatre(acts);
            List<String> chapters = new List<string> { "Chapter 1", "Chpater 2", "Chapter 3" };
            Book book = new Book(chapters);
            Reader reader = new Reader();
            reader.ListAllIntervalsIn(book.contents);
            reader.ListAllIntervalsIn(theatre.acts);

            List<ForetellAppState> foretellAppStates = new List<ForetellAppState>() { new GGAvatarsForForetell(), new ForetellUnified()};
            ForetellAppState currentAppState = foretellAppStates[0];
            string oculusAppId = currentAppState.GetAppId(); 
        }
    }

    public class Reader
    {
        public void ListAllIntervalsIn(MultimediaIterator iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ListAllIntervalsIn(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
