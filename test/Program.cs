namespace ConsoleApp1
{
    class Program
    {


        public static string ReplaceSubstring(string baseString, string stringToReplace, string replacement)
        {
            string newStr = "";
            string buffer = "";
            bool flagStringDetected = false;
            int bufferIndex = 0;
            foreach(char c in baseString)
            {
                if (flagStringDetected)
                {
                    if(c == stringToReplace[bufferIndex])
                    {
                        buffer += c;
                        bufferIndex++;
                    }
                    else
                    {
                        flagStringDetected = false;
                        newStr += buffer;
                        newStr += c;
                        buffer = "";
                        bufferIndex = 0;
                    }
                    if(bufferIndex == stringToReplace.Length)
                    {
                        flagStringDetected = false;
                        newStr += replacement;
                        buffer = "";
                        bufferIndex = 0;
                    }
                }
                else if (c == stringToReplace[bufferIndex])
                {
                    flagStringDetected = true;
                    buffer += c;
                    bufferIndex++;
                }
                else
                {
                    newStr += c;
                }

                
            }
            return newStr;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceSubstring("No worrie no curries", "ies", "y"));
        }
    }
}