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
          
            // The current separator for the delimiter. 
            String[] separator = { "," }; 

            // Splitting the string into an array called strList.
            String[] strList = inputString.Split(separator, StringSplitOptions.RemoveEmptyEntries); 

            // Int var that holds the total addition.
            int totalCount = 0; 

            // Checking if the array has an index of more than 2.
            if (strList.Length > 2) 
            {
                Console.WriteLine("Too many entries. Please try again."); 
            }
            else 
            {
                // Parsing the string into and int and adding. Else throw exception. 
                foreach(String value in strList) 
                { 
                    int number;
            
                    bool success = Int32.TryParse(value, out number);

                    if (success)
                    {
                        totalCount += number;         
                    }
                    else
                    {
                        Console.WriteLine("Attempted conversion of '{0}' failed. '{0}' is not a number.", 
                                        value ?? "<null>");
                    }
                } 
                // Display total
                Console.WriteLine(totalCount); 
            }
        }

        // static string checkerFunction(string strlist)
        // {
          
        // }
    }
}
