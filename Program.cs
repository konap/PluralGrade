using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott Grade Book";
            Console.Write(g2.Name);

            
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Всем привет");
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatictics();
            Console.WriteLine(stats.AverageGrade);
            
        }
    }
}
