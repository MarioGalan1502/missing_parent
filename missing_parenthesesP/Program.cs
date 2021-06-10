using System;
using System.Collections.Generic;

namespace missing_parenthesesP
{
    public class check_missing
    {
        public char missing(string exp)
        {
            if(exp == null)
            {
                throw new ArgumentNullException();
            }
            Stack<char> st = new Stack<char>();

            char[] expArray = exp.ToCharArray();

            for (int i = 0; i < expArray.Length; i++)
            {
                if(expArray[i]=='(')
                {
                    st.Push(expArray[i]);
                }

                if(expArray[i]==')')
                {
                    if(st.Count != 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        return '(';
                    }
                }
            }
            
            if(st.Count !=0)
            {
                return ')';
            }



            return ' ';
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
