using System;
using System.Collections.Generic;
class Program2
{
    static void Main(string[] args)
    {
        var list = new List<string>{ "What brings you joy? ", "Describe a place where you felt happiest. ",
        "What is something that you would like to change about yourself? How can you change it? ",
        "If you are granted a wish, what would you wish for and why? ",
        "How could you make someone you care about feel better if he/she just lost something important to them? " };


        PromptGenerator prompt1 = new PromptGenerator();
        var random = new Random();
        int index = random.Next(list.Count);
        prompt1._prompt =index;
    }
}