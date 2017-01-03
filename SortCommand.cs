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

            numbers.Sort();

            foreach(var number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
