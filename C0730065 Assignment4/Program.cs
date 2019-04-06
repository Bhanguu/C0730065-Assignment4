using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace C0730065_Assignment4
//C0730065 Assignment4.
{
    class Program
    {
        ArrayList Beowulf;


        static void Main(string[] args)
        {
            Program p = new Program();

            p.Beowulf = new ArrayList();

            p.Wordfinder();

            Console.ReadLine();



        }

        public void Run()

        {

            this.ReadTextFiles();

        }



        public void ReadTextFiles()

        {



            // Read file using StreamReader. Read file line by line

            using (StreamReader file = new StreamReader("U:/Users/730065/Assignment4/Beowulf.txt"))

            {

                int counter = 0;

                string ln;



                while ((ln = file.ReadLine()) != null)

                {

                    Console.WriteLine(ln);

                    Beowulf.Add(ln);

                }

                file.Close();

                Console.WriteLine($"File has {counter} lines.");

            }

        }

        public int FindNumberOfBlankSpaces(string line)

        {

            int countletters = 0;

            int countSpaces = 0;

            {

                foreach (char c in line)

                {

                    if (char.IsLetter(c)) { countletters++; }

                    if (char.IsWhiteSpace(c)) { countSpaces++; }

                }

                return countSpaces;

            }

        }

        public void CountLinesReader()

        {

            long lineCounter = 0;

            using (StreamReader fil = new StreamReader("U:/Users/730065/Assignment4/Beowulf.txt"))

            {

                while (fil.ReadLine() != null)

                {

                    lineCounter++;

                }

                Console.WriteLine(lineCounter);

            }

        }

        public void WordCounter()

        {



            StreamReader reader = new StreamReader("U:/Users/730065/Assignment4/Beowulf.txt");

            string script = reader.ReadToEnd();



            var text = script.Trim();

            int wordCount = 0, index = 0;



            while (index < text.Length)

            {

                // check if current char is part of a word

                while (index < text.Length && !char.IsWhiteSpace(text[index]))

                    index++;



                wordCount++;



                // skip whitespace until next word

                while (index < text.Length && char.IsWhiteSpace(text[index]))

                    index++;

            }



            Console.WriteLine(wordCount);





        }

        public void Wordfinder()

        {

            int f = 0;

            foreach (string line in File.ReadAllLines("U:/Users/730065/Assignment4/Beowulf.txt"))

            {

                if (line.Contains("sea") && line.Contains("fare"))

                {

                    f++;

                }



            }

            Console.WriteLine(f);

        }

    }



}


