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
            String[] separator = { "\\n", ","};
            string customDel = "";

            // inputString.Slice(1,3);
            Console.WriteLine(inputString.IndexOfAny("["));
            Console.WriteLine(inputString);

            // Working math using another var.
            // int actualDel = (index2)-(index1+1);
            // customDel = inputString.Substring(index1+1, (index2-3));

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
                // Console.WriteLine("Custom DELIMITER is " + customDel);
                Console.WriteLine("The ANSWER is " + totalCount); 
        }
    }

    public static class Extensions
    {
        public static string Slice(this string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
            {
                end = source.Length + end;
                Console.WriteLine("end " + end + " source.length " + source.Length + " end " + end); 
            }
            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }
    }
}