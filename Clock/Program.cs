using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] number = new string[][]    
            {
                 new string[]{"███","█ █","█ █","█ █","███"}, /* 0 */
                 new string[]{"  █","  █","  █","  █","  █"}, /* 1 */
                 new string[]{"███","  █","███","█  ","███"}, /* 2 */
                 new string[]{"███","  █","███","  █","███"}, /* 3 */
                 new string[]{"█ █","█ █","███","  █","  █"}, /* 4 */
                 new string[]{"███","█  ","███","  █","███"}, /* 5 */
                 new string[]{"███","█  ","███","█ █","███"}, /* 6 */
                 new string[]{"███","  █","  █","  █","  █"}, /* 7 */
                 new string[]{"███","█ █","███","█ █","███"}, /* 8 */
                 new string[]{"███","█ █","███","  █","███"}, /* 9 */
                 new string[]{" "," "," "," "," "}, /* 10, space */
                 new string[]{"   "," █ ","   "," █ ","   "}, /* 11, colon */
                 new string[]{"                        ","                        ","                        ","                        ","                        "}, /* 12, centering. */

            };

            Console.Clear();

            while (true) {
                int[] digits = new int[16];
                digits[0] = 12;
                digits[1] = DateTime.Now.Hour / 10;
                digits[2] = 10;
                digits[3] = DateTime.Now.Hour % 10;
                digits[4] = 10;
                digits[5] = 11;
                digits[6] = 10;
                digits[7] = DateTime.Now.Minute / 10;
                digits[8] = 10;
                digits[9] = DateTime.Now.Minute % 10;
                digits[10] = 10;
                digits[11] = 11;
                digits[12] = 10;
                digits[13] = DateTime.Now.Second / 10;
                digits[14] = 10;
                digits[15] = DateTime.Now.Second % 10;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                string buffer = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < digits.Length; j++)
                        buffer += number[digits[j]][i];
                        buffer += "\r\n";
                }
                Console.Write(buffer);
                System.Threading.Thread.Sleep(10);
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}