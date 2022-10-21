using System;

namespace NumberOfWords{

    class Program{

        static void Main(string[] args){

            int a = 0;
            int count = 1;

            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();


           for(a = 0; a <= str.Length-1; a++){
                if(str[a] == ' ' || str[a] == '\t' ){
                    count += 1;
                }
            }

            Console.WriteLine(count);


        }
        
    }
}
