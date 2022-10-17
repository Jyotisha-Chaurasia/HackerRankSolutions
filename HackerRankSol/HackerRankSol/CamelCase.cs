using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int camelcase(string s)
    {
        int count = 1;
        char[] n = s.ToCharArray(); // set character of string in to char[] Array
        for (int i = 1; i < n.Length; i++)
        {
            char m = Convert.ToChar(n[i]); // change int to char
            if (Char.IsUpper(m)) // check character is in UpperCase or not
            {
                count++;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();

        int result = Result.camelcase(s);

        Console.WriteLine(result);

     
    }
}
