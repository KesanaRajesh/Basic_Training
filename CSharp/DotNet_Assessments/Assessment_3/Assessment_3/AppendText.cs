using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program in C# Sharp to append some text to an existing file. If file is not available, then create one in the same workspace.
//Hint: (Use the appropriate mode of operation. Use stream writer class)

namespace Assessment_3
{
    class AppendText
    {
        static void Main(string[] args)
        {
            string path = @"C:\DotNet_Training\Infinite_1\CSharp\DotNet_Assessments\Assessment_3\Assessment3_AppendProgram Text.txt";
            string txt = Console.ReadLine();
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(txt);
                    Console.WriteLine("Text appended successfully");
                }
            }
            Console.Read();
        }
    }
}
