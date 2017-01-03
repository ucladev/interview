using System;

namespace UCLA.EA.Interview
{
    public class RandomCommand : ICommand
    {
        private Random RandomGenerator = new Random();

        public void Run(string[] args)
        {
            var numberToGenerate = int.Parse(args[0]);

            while(numberToGenerate > 0) {
                Console.WriteLine(RandomGenerator.Next());
                --numberToGenerate;
            }
        }
    }
}
