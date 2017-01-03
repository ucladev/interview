using System;
using System.Linq;
using System.Collections.Generic;

namespace UCLA.EA.Interview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processors = new Dictionary<string,ICommand> {
                { "sort", new SortCommand() },
                { "random", new RandomCommand() }
            };

            processors[args[0]].Run(args.Skip(1).ToArray());
        }
    }
}
