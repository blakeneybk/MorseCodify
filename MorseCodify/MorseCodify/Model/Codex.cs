﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodify.Model
{
    public class Codex
    {
        //This program uses a dictionary because of the constant lookup speed.
        public static Dictionary<char, string> Morse { get; } = new Dictionary<char, string>()
        {
            {'A' , ".-"},{'a' , ".-"},
            {'B' , "-..."},{'b' , "-..."},
            {'C' , "-.-."},{'c' , "-.-."},
            {'D' , "-.."},{'d' , "-.."},
            {'E' , "."},{'e' , "."},
            {'F' , "..-."},{'f' , "..-."},
            {'G' , "--."},{'g' , "--."},
            {'H' , "...."},{'h' , "...."},
            {'I' , ".."},{'i' , ".."},
            {'J' , ".---"},{'j' , ".---"},
            {'K' , "-.-"},{'k' , "-.-"},
            {'L' , ".-.."},{'l' , ".-.."},
            {'M' , "--"},{'m' , "--"},
            {'N' , "-."},{'n' , "-."},
            {'O' , "---"},{'o' , "---"},
            {'P' , ".--."},{'p' , ".--."},
            {'Q' , "--.-"},{'q' , "--.-"},
            {'R' , ".-."},{'r' , ".-."},
            {'S' , "..."},{'s' , "..."},
            {'T' , "-"},{'t' , "-"},
            {'U' , "..-"},{'u' , "..-"},
            {'V' , "...-"},{'v' , "...-"},
            {'W' , ".--"},{'w' , ".--"},
            {'X' , "-..-"},{'x' , "-..-"},
            {'Y' , "-.--"},{'y' , "-.--"},
            {'Z' , "--.."},{'z' , "--.."},
            {'0' , "-----"},
            {'1' , ".----"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
            /*space character*/
            {' '," / "}
        };
    }
}
