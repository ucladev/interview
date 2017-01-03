using System;
using System.Collections.Generic;

namespace UCLA.EA.Interview
{
    public class SortCommand : ICommand
    {
        public void Run(string[] args)
        {
            var numbers = new List<int>();

            while(true) {
                var input = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(input)) {
                    break;
                }
                numbers.Add(int.Parse(input));
            }

            // do the sorting...

            foreach(var number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
