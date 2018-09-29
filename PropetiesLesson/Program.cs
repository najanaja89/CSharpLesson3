using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropetiesLesson.Problems;
using static System.Console; //Дает не набирать в коде набирать слово консоль (Console.Writeline())

namespace PropetiesLesson
{    
    class Program
    {
        static void Main(string[] args)
        {

            ProblemClass problemClass = new ProblemClass();
            try
            {
                //код который может не выполниться в связи с какой то проблемой или результатом
                problemClass.BadAction();
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EncoderFallbackException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NotImplementedException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                //Отработает в любом случае
            }
            Console.ReadLine();
        }
    }
}
