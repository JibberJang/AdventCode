using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventCode.Days
{
    public class Two
    {
        public void GetSolution()
        {
            var data = new List<PasswordInput>();

            using (var reader = new StreamReader("~/../../../../Resources/Two.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();

                    data.Add(new PasswordInput
                    {
                        Minimum = int.Parse(line.Split('-')[0]),
                        Maximum = int.Parse(line.Substring(line.IndexOf('-') + 1, line.IndexOf(' ') - 1).Split(' ')[0]),
                        Letter = line.Substring(line.IndexOf(' ') + 1, line.IndexOf(':') - 1).Split(':')[0].ToCharArray()[0],
                        Password = string.Join("", string.Join("", line.Reverse()).Split(' ')[0].Reverse())
                    });
                }
            }

            var passwordValidCount = 0;
            foreach (var combination in data)
            {
                var letterCount = combination.Password.ToCharArray().Count(x => x == combination.Letter);
                if (letterCount >= combination.Minimum &&
                    letterCount <= combination.Maximum)
                {
                    passwordValidCount++;
                }
            }

            Console.WriteLine("There are " + passwordValidCount + " valid passwords.");

            var passwordValidPartTwo = 0;
            foreach (var combination in data)
            {
                var letters = combination.Password.ToCharArray();

                if ((letters[combination.Minimum - 1] == combination.Letter ||
                    letters[combination.Maximum - 1] == combination.Letter) &&
                    (letters[combination.Minimum - 1] != letters[combination.Maximum - 1]))
                {
                    passwordValidPartTwo++;
                }
            }

            Console.WriteLine("There are " + passwordValidPartTwo + " valid passwords for part two.");
        }

        private class PasswordInput
        {
            public int Minimum { get; set; }
            public int Maximum { get; set; }
            public char Letter { get; set; }
            public string Password { get; set; }
        }
    }
}
