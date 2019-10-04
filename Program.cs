using System;

namespace R365
{
    class R365Program
    {
        static void Main(string[] args)
        {
            // Enter input and store it as a string called inputString.
            Console.WriteLine("Please enter your input below: ");
            String inputString = Console.ReadLine();
          
            // Took the 2nd index of the input string and converted it to a string down below. 
            char customDel = inputString[2];
            
            // The current separator for the delimiter. 
            String[] separator = { "\\n", ",", customDel.ToString() }; 

            // Splitting the string into an array called strList.
            String[] strList = inputString.Split(separator, StringSplitOptions.RemoveEmptyEntries); 

            // Int var that holds the total addition.
            int totalCount = 0; 

                // Parsing the string into and int and adding. Else throw exception. 
                foreach(String value in strList)
                { 
                    int number;
            
                    bool success = Int32.TryParse(value, out number);

                    // if number was parsed and over 1000, remove it. 
                    if (success && number <= 1000)
                    {
                            totalCount += number;        
                    }
                    else
                    {   
                        Console.WriteLine("'{0}' is not a number or is a negative number.", 
                                        value ?? "<null>");
                    }
                } 
                // Display total
                Console.WriteLine("Custom DELIMITER is " + customDel);
                Console.WriteLine("The ANSWER is " + totalCount); 
        }

        // static string checkerFunction(string strlist)
        // {
          
        // }
    }
}