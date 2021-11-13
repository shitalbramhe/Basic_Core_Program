using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    public class Check_Vowel_consonant
    {
         public void vowel_consonant(char ch)
         {
             if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
             {
             Console.WriteLine(ch + " is Vowel.");
             }
             else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
             {
             Console.WriteLine(ch + " is Consonant.");
             }
         }
    }
}
