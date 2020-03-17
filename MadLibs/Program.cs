﻿using System;

namespace MadLibs
{
    class Program
    {
        string input = Console.ReadLine();
        string story;
        string name;
        string adjective1;
        string adjective2;
        string noun1;
        string noun2;
        string noun3;
        string adverb;
        string randomNums;
        Random rand = new Random();

        //Getters
        public string getStrory()
        {
            return story;
        }

        public string getName()
        {
            return name;
        }

        public string getAdjective1()
        {
            return adjective1;
        }

        public string getAdjective2()
        {
            return adjective2;
        }

        public string getNoun1()
        {
            return noun1;
        }

        public string getNoun2()
        {
            return noun2;
        }

        public string getNoun3()
        {
            return noun3;
        }

        public string getAdverb()
        {
            return adverb;
        }

        public string getRandomNums()
        {
            return randomNums;
        }

        //Setters
        public void setStory(string newStory)
        {
            this.story = newStory;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }

        public void setAdjective1(string newAdj1)
        {
            this.adjective1 = newAdj1;
        }

        public void setAdjective2(string newAdj2)
        {
            this.adjective2 = newAdj2;
        }

        public void setNoun1(string newNoun1)
        {
            this.noun1 = newNoun1;
        }

        public void setNoun2(string newNoun2)
        {
            this.noun2 = newNoun2;
        }

        public void setNoun3(string newNoun3)
        {
            this.noun3 = newNoun3;
        }

        public void setAdverb(string newAdverb)
        {
            this.adverb = newAdverb;
        }

        public void setRandomNums()
        {

        }

        //Print instructions to player
        public void printInstructions()
        {
            Console.WriteLine("Welcome to the MadLibs game. Start typing in a name and you will get a story");
        }

        //Get data from player
        public void enterName()
        {
            setName(Console.ReadLine());
        }

        public void enterNoun1()
        {
            Console.WriteLine("Give me a noun");
            setNoun1(Console.ReadLine());
        }

        public void enterNoun2()
        {
            Console.WriteLine("Give me another noun");
            setNoun2(Console.ReadLine());
        }

        public void enterNoun3()
        {
            Console.WriteLine("Give me the last noun");
            setNoun3(Console.ReadLine());
        }

        public void enterAdjective1()
        {
            Console.WriteLine("I need an adjective");
            setAdjective1(Console.ReadLine());
        }

        public void enterAdjective2()
        {
            Console.WriteLine("Give me another adjective");
            setAdjective2(Console.ReadLine());
        }

        public void enterAdverb()
        {
            Console.WriteLine("Give me an adverb");
            setAdverb(Console.ReadLine());
        }

        public void putTogetherTheStroy()
        {
            string story = "My family" + getName() + "went to Disney World last month!" + "we saw a" + getNoun1() +
                "in a show at the Magic Kingdom and ate a" + getAdjective1()
                + "feast for dinner. The next day we went" + getAdverb() + "to meet Mickey Mouse and his" + getNoun2()
                + "and then that night I gazed at the" + getRandomNums() + " " + getAdjective2() + "fireworks shooting from the"
                + getNoun3() + ".";
            setStory(story);
        }

        public void play()
        {
            enterName();
            enterNoun1();
            enterAdjective1();
            enterAdjective2();
            enterNoun2();
            enterAdverb();
            enterNoun3();             
        }

        static void Main(string[] args)
        {
            Program game = new Program();
            game.printInstructions();
        }
    }
}
