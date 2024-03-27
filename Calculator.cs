using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DVCalc
{
    internal static class Calculator
    {
        private static long seed;
        public static void setSeed(long seed)
        {

            Calculator.seed = seed;

        }


        //this function is lifted from turtleisaac's Pokeditor
        //See https://github.com/turtleisaac/PokEditor-v2/blob/72ca6ab641f616b8be9a87624b81896baa45f947/src/com/turtleisaac/pokeditor/utilities/TrainerPersonalityCalculator.java
        public static long getNextRandom()
        {
            long random = 0x41c64e6d * seed + 0x6073;

            //last 32 bits is new seed
            seed = random & 0xFFFFFFFFL;

            return random;
        }

        public static int findHighestDV(int trainerIdx, int trainerClassIdx, bool trainerClassMale, int pokeIdx, int pokeLevel, uint nature)
        {
            int DV;

            for (DV = 255; DV > 0; DV--)
            {
                if (getNatureFromPID(generatePID(trainerIdx, trainerClassIdx, trainerClassMale, pokeIdx, pokeLevel, DV)) == nature)
                { return DV; }
            }

            return -1;

        }

        //this function is lifted from turtleisaac's Pokeditor
        //See https://github.com/turtleisaac/PokEditor-v2/blob/72ca6ab641f616b8be9a87624b81896baa45f947/src/com/turtleisaac/pokeditor/utilities/TrainerPersonalityCalculator.java
        public static uint generatePID(int trainerIdx, int trainerClassIdx, bool trainerClassMale, int pokeIdx, int pokeLevel, int difficultyValue)
        {
            long newSeed = trainerIdx + pokeIdx + pokeLevel + difficultyValue;

            long random = 0;

            setSeed(newSeed);

            while (trainerClassIdx > 0)
            {
                trainerClassIdx--;
                random = getNextRandom();
            }

            //don't really get this part
            long PID = (random >> 16) & 0xffff;
            PID = PID * 256;

            //this seems super arbitrary (wtf GameFreak?)
            PID += trainerClassMale ? 136 : 120;

            return (uint)PID;
        }

        public static uint getNatureFromPID(uint PID)
        {
            return (PID % 100) % 25;
        }

        public static List<DVIVNatureTriplet> getAllNatures(int trainerIdx, int trainerClassIdx, bool trainerClassMale, int pokeIdx, int pokeLevel)
        {
            List<DVIVNatureTriplet> natureDict = new List<DVIVNatureTriplet>();

            int DV;
            uint natureIdx;

            for (DV = 255; DV > 0; DV--)
            {
                natureIdx = getNatureFromPID(generatePID(trainerIdx, trainerClassIdx, trainerClassMale, pokeIdx, pokeLevel, DV));

                natureDict.Add(new DVIVNatureTriplet(DV, DV*31/255 , Natures[(int)natureIdx]));


            }

            return natureDict;
        }

        public static List<string> Natures = new List<string>
    {
    "Hardy: Neutral",
    "Lonely: +Atk, -Def",
    "Brave: +Atk, -Spe",
    "Adamant: +Atk, -SpA",
    "Naughty: +Atk, -SpD",
    "Bold: +Def, -Atk",
    "Docile: Neutral",
    "Relaxed: +Def, -Spe",
    "Impish: +Def, -SpA",
    "Lax: +Def, -SpD",
    "Timid: +Spe, -Atk",
    "Hasty: +Spe, -Def",
    "Serious: Neutral",
    "Jolly: +Spe, -SpA",
    "Naive: +Spe, -SpD",
    "Modest: +SpA, -Atk",
    "Mild: +SpA, -Def",
    "Quiet: +SpA, -Spe",
    "Bashful: Neutral",
    "Rash: +SpA, -SpD",
    "Calm: +SpD, -Atk",
    "Gentle: +SpD, -Def",
    "Sassy: +SpD, -Spe",
    "Careful: +SpD, -SpA",
    "Quirky: Neutral"
    };


    }
}