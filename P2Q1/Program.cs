using System;
using System.Collections.Generic;

namespace P2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
                List<string> words = new List<string>()
                    { "java", "jjava" , "vaj",  "aavj",  "j",  "vjaa",  "dan",  "and", "ddan"};

                Dictionary<string, int> numbersMapName = new Dictionary<string, int>();

                if (words != null)
                {
                    foreach (string w in words)
                    {
                        char[] chars = w.ToCharArray();

                        Array.Sort(chars);

                        string newWord = new string(chars);
                        if (numbersMapName.ContainsKey(newWord))
                            numbersMapName[newWord] += 1;
                        else
                            numbersMapName.Add(newWord, 0);
                    }

                    foreach (KeyValuePair<string, int> line in numbersMapName)
                    {
                        Console.WriteLine(line.Key + "=>" + (line.Value+1));
                    }
                
            }

        }
    }
}
