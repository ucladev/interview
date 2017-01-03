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
                int number = 0;
                if(int.TryParse(input, out number)) {
                    numbers.Add(number);
                }
            }

            numbers.Sort();

            foreach(var number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
