using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;

namespace LetterScramble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = GenerateWords();
            var scrambled = ScrambleWords(words);

            OutputTable(scrambled);

            Console.WriteLine("Enter word:");
            var word = Console.ReadLine();

            var wordValue = CalculateWordValue(word);

            Console.WriteLine($"Your word value is {wordValue}");
        }

        private static int CalculateWordValue(string? word)
        {
            int pointValue = 0;

            if (word == null)
            {
                return pointValue;
            }

            foreach (char c in word)
            {
                string letter = c.ToString().ToUpper();
                pointValue += CommonWords.LetterValues[letter];
            }

            return pointValue;
        }

        private static void OutputTable(List<string> scrambled)
        {
            // Create a table
            var table = new Table();
            table.HideHeaders();

            // Add some columns
            table.AddColumn("");
            table.AddColumn("");
            table.AddColumn("");
            table.AddColumn("");

            for (int i = 0; i < scrambled.Count; i++)
            {
                table.AddRow(scrambled[i], scrambled[i+1], scrambled[i+2], scrambled[i+3]);
                i += 3;
            }

            // Render the table to the console
            AnsiConsole.Write(table);
        }

        private static List<string> ScrambleWords(List<string> words)
        {
            string combinedString = string.Join("", words.ToArray());
            List<string> scrambledLetters = new List<string>();

            Random r = new Random();
            foreach (int i in Enumerable.Range(0, 16).OrderBy(x => r.Next()))
            {
                scrambledLetters.Add(combinedString.Substring(i, 1));
            }

            return scrambledLetters;
        }

        public static List<string> GenerateWords()
        {
            List<string> words = new List<string>();

            var longWord = "suspicious";
            var vowels = "aeiou";

            var mod3 = (16 - longWord.Length) % 3;
            var mod4 = (16 - longWord.Length) % 4;


            var random = new Random();
            if (mod3 == 0)
            {
                for (int j = 0; j < (16 - longWord.Length) / 3; j++)
                {
                    var i = random.Next(0, CommonWords.ThreeLetterWords.Length - 1);
                    words.Add(CommonWords.ThreeLetterWords[i]);
                }
            }
            if (mod4 == 0)
            {
                for (int j = 0; j < (16 - longWord.Length) / 3; j++)
                {
                    var i = random.Next(0, CommonWords.FourLetterWords.Length - 1);
                    words.Add(CommonWords.FourLetterWords[i]);
                }
            }

            words.Add(longWord);

            words.ForEach(Console.WriteLine);
            return words;

        }
    }
}
