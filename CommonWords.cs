using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble
{
    public static class CommonWords
    {
        public static string[] ThreeLetterWords { get; } = new[]
        {
            "the", "and", "are", "for", "not", "but", "had", "has", "was", "all", "any", "one", "man", "out", "you", "his", "her", "can"
        };

        public static string[] FourLetterWords { get; } = new[]
        {
            "that", "with", "have", "this", "will", "your", "from", "they", "want", "been", "good", "much", "some", "very"
        };

        public static Dictionary<int, List<string>> PointValues { get; } = new Dictionary<int, List<string>>()
        {
            {1, new List<string>() {"A", "E", "I", "O", "U", "L", "N", "S", "T", "R"}},
            {2, new List<string>() {"D", "G"}},
            {3, new List<string>() {"B", "C", "M", "P"}},
            {4, new List<string>() {"F", "H", "V", "W", "Y"}},
            {5, new List<string>() {"K"}},
            {8, new List<string>() {"J", "X"}},
            {10, new List<string>() {"Q", "Z"}},
        };

        public static Dictionary<string, int> LetterValues { get; } = new Dictionary<string, int>()
        {
            { "A", 1 },
            { "B", 3 },
            { "C", 3 },
            { "D", 2 },
            { "E", 1 },
            { "F", 4 },
            { "G", 2 },
            { "H", 4 },
            { "I", 1 },
            { "J", 8 },
            { "K", 5 },
            { "L", 1 },
            { "M", 3 },
            { "N", 1 },
            { "O", 1 },
            { "P", 3 },
            { "Q", 10 },
            { "R", 1 },
            { "S", 1 },
            { "T", 1 },
            { "U", 1 },
            { "V", 4 },
            { "W", 4 },
            { "X", 8 },
            { "Y", 4 },
            { "Z", 10 }
        };
    }
}
