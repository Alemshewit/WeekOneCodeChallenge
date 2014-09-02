using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop throught the numbers 0 to 20 and call the function
            //FizzBuzz
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            // loop through the numbers 92 to 79, and call the function FizzBuzz 
            for (int i = 92; i >= 79; i = i - 1)
            {
                FizzBuzz(i);
            }

            //call the Yodaizer function with "I like code" parameter
            Yodaizer("I like code");

            TextStats("Create a function which takes an string parameter and prints " +
            "\nout the words in reverse order. In Main, call your function. " +
            "\nModify your Yodaizer to check to see the number of words in the sentence.");

            //loop from 1 to 25, and call the function IsPrime to check if the 
            //given loop is prime or not.
            for (int i = 1; i <= 25 ; i++)
            {
               //if the current loop is prime, print to the console that the given
                //number is prime, if it is not print to the console that it is not prime.
                if (IsPrime(i))
                {
                    Console.WriteLine("{0} is a prime number", i);
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }

           DashInsert(867530);

            //keep console open
            Console.ReadKey();
        }

            // create a function FizzBuzz that takes a number and checks 
            // to see if it is divisible by both 5 & 3, just 5 or 3 and 
            //return FizzBuzz, Fizz, or Buzz respectively.
        static void FizzBuzz(int num)
        {
            int number = num;
            //an if/else if statement that checks which of the three 
            //conditions is true..
            //if number is divisible by both 5 & 3 
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

             //check if number is divisible by 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
             //check if number is divisible by 3
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
             //if number is not divisible by either number
             //print number to the console
            else
            {
                Console.WriteLine(number);
            }
        }

        static void Yodaizer(string text)
        {
            //take the array of string that comes in as argument
            //splip the the string in to words by spaces
            string[] words = text.Split(' ');

            //rearrange the words back to front 
            Array.Reverse(words);
            
            // print to the console the words joined in reverse order
           Console.WriteLine(string.Join(" ", words));

            //extra credit ...modifiy Yodaizer to check number of words
           if (words.Length == 3)
           {
               Console.WriteLine(string.Join(", ",  words));
           }

        }

        static void TextStats(string input)
        {
            //declare variables to hold how many of each exists in the given string
            int numCharacters = 0;
            int numWords = 0;
            int numVowels = 0;
            int numConsonants = 0;
            int numSpeChar = 0;

            //take the input and split it by space in order to detect the number of
            //words in the string, and store it into a new list string 
            List<string> words = input.Split(' ').ToList();

            //loop through the new word string and count the number of words in the given string
            for (int i = 0; i <= words.Count - 1; i++)
            {
                //take each word and store them into a string named item.
                string item = words[i];

                //store the number of words into numWord with each loop and increase the count by 1
                numWords += 1;

                //loop through each incoming word stored in the variable item and 
                //count the number of characters, vowels, consonants, and special characters
                for (int j = 0; j <= item.Length - 1; j++)
                {
                    //take each character going through the loop change it to a string and store 
                    //in the variable letter.
                    string letter = item[j].ToString();
                    //after every loop increase numCharacters by one to keep track of how many 
                    //characters in the string
                    numCharacters += 1;

                    //declare a string vowel that holds the value of "aeiou"
                    string vowel = "aeiou";

                    //with every loop check to see if the letter in the incoming index is infact 
                    //a vowel, a special character or consonant, and increment which ever of this
                    //conditions is true. 
                    if (vowel.Contains(letter))
                    {
                        numVowels += 1;
                    }
                    else if (!char.IsLetterOrDigit(letter.ToString(), 0))
                    {
                        numSpeChar += 1;
                    }
                    else
                    {
                        numConsonants += 1;
                    }
                }
            }

            //print tot he console the number total number of each type. 
            Console.WriteLine("Number of Characters: " + numCharacters + 
                "\nNumber of Words: " + numWords + 
                "\nNumber of Vowels: " + numVowels + 
                "\nNumber of Consonants: " + numConsonants + 
                "\nNumber of Special Characters: " + numSpeChar);

            //display the words list from the longest to the shortest. 

            var longest = from items in words
                          orderby items.Length descending
                          select items;

            foreach (var w in longest)
            {
                Console.WriteLine(string.Join(", ", w));
            }

        }

       //This function checks to see if a given number is prime or not
        static bool IsPrime(int number)
        {
            //first check to see if the number is either 0 or 1 since those 
            //numbers are not prime we eliminate them by checking
            if(number == 0 || number == 1)
            {
                return false;
            }
              
            //we check to see if the given number is 2 and return true
            //if it is, since 2 is the only even number that is only divisible 
            //by 1 and itself
            else if (number == 2)
            {
                return true;

            }
            //then we check to see if the given number is even, and return false 
            //if it is since all even numbers, 2 excepted are not prime
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            //if the above conditions aren't met, then it means the given number
            //is odd and we loop through the odd number to see if it is prime or  
            //not since only some odd numbers are prime
            {
                //loop through the number until it reaches half its value, since
                //a number is only divisible by numbers half its value and lower,
                //and increment the loop by 2 every loop 
                for (int i = 3; i < number / 2; i += 2)
                {
                    //if the number is divisible by i then return false, if not 
                    //return true
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //create a function DashInstert that inserts dashes in between odd numbers
        static void DashInsert(int number)
        {
            //take the integer input and convert it to string, so we can loop through
            //the array 
            string inputNum = number.ToString();

            //create a for loop that loops through the input string array
            for (int i = 0; i < inputNum.Length; i++ )
            {
                //conver each character in the array and convert to integer to check
                //if number is an odd number or not
                if (int.Parse(inputNum[i].ToString()) % 2 != 0)
                {
                    //if the number is odd loop
                    for (int j = int.Parse(inputNum[i-1].ToString()); j < inputNum.Length; j++)
                    {
                        Console.WriteLine("-" + inputNum[i]);    

                    }
                
                }
                Console.WriteLine(inputNum[i]);    
            }
        }
        
    }
    
}


