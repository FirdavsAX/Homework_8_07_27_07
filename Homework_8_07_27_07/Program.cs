namespace Homework_8_07_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str= "The Lord of the rings is most famous film  and I like it";

            int position = (FindPosition(str));
           str =  FindEventMax(str, position);
            Console.WriteLine(str);
        }
        static int FindPosition(string str)
        {
            int count=0, maxCount = 1, pos = 0;
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count = 0 ;
                }
                else
                {
                    count++;
                }
                if(maxCount < count)
                {
                    pos = i;
                    maxCount= count;
                }
            }
            return pos+1;
        }
        static string FindEventMax(string str , int pos)
        {
            int lengthEvent = 1;

            if(str.Length-3 < pos)
            {
                return "-1";
            }

            for (int i = pos+1; i<str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    lengthEvent++; 
                }
                else
                {
                    break;
                }
            }
            return str.Substring(pos+1, lengthEvent);
        }
    }
}