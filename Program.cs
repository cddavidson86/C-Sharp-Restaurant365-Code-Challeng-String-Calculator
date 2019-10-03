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
            String[] separator = { "\\n", "," }; 

            // Splitting the string into an array called strList.
            String[] strList = inputString.Split(separator, StringSplitOptions.RemoveEmptyEntries); 

            // Int var that holds the total addition.
            int totalCount = 0; 
    
                // Parsing the string into and int and adding. Else throw exception. 
                foreach(String value in strList)
                { 
                    int number;
            
                    bool success = Int32.TryParse(value, out number);

                    // if number was parsed and is not a negative or 0 then throw an exception. 
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
                Console.WriteLine("The answer is " + totalCount); 
        }

        // static string checkerFunction(string strlist)
        // {
          
        // }
    }
}