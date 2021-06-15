using System;

namespace missing_Part2
{
    public class check_missing2
    {
        public char missing_P2(string exp)
        {
            if(exp == null)
            {
                throw new ArgumentNullException();
            }

            int x=0;

            foreach(char val in exp)
            {
                if(val == '(' || val == ')')
                {
                    x= val == '(' ? ++x : --x; 
                }
            }

            if(x>0)
            {   
                return ')';
            }
            else if(x<0)
            {
                return '(';
            }
            else
            {
                return ' ';
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
