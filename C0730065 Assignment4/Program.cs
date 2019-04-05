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
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            //Read files using StreamReader.Reads file line by line using (StreamReader("C:/area51/beowulf.text"))
            int counter = 0;
            String in;
            while ((in = file.ReadLine()) != null)
            {
                Console.WriteLine(1n);
                Beowulf.Add(In);

            }

            file.Close();
            Console.WriteLine("File has {contour) lines.");
        }
            public int FindNumberOfBlankSpaces(string line)
        {
            //https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-
            int counterletters = 0;

            int countSpaces = 0;

           foreach (char c in line)

              if (char.Isletter(c)) { count letters c++;)
          if (char.IswhiteSpace(c))
         {count Spaces C++; }
            return count Spaces;
      }
    }

