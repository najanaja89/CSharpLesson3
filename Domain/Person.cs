using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain

    /*
     * 
     * AutoProperty - автосвойтво
     * public возвращаемый тип ИмяСвойства { модификатор доступа (орц)get; (опц(public, private))set;}
     * 
     * 
     */
{
    public class Person
    {
        public DateTime BirthDate { get; set; } //автосвойство и метод и перемання одновременно

        /*
         * 
         * Indexator -  индексатор, позволяет обращаться к текущему оъекту как к массиву
         * private тип[] имяПеременной;
         * public возвр.тип this [int index]
         * {
         * get
         * {
         *          return имяПеременной[index];
         * }
         * 
         * set
         * {
         *          имяПеременной[index] = value;
         * }
         * 
         * }
         * 
         * 
        */

        private int[] marks;
        //indexer tab
        public int this[int index]
        {
            get
            {
                return marks[index];
            }

            set
            {
                // anotherPerson[1] = 5;
                marks[index] = value;
            }
        }

        /*
        * 
        * FullProperty - полное свойство.
        * private тип имяПеременной;
        * public тип ИмяСвойства
        * {
        * 
        * get
        * {
        *  // какие-то действия 
        *  return имяПеременной; //не Свойства, а переменной!
        * }
        * 
        * set
        * {
        *   //какие-то действия 
        *   имяПеременной = value;
        * }
        * 
        * }
        * 
        */

        private string fullName;

        public string FullName
        {

            get
            {
                //какие-то действия.
                //int number = 3;
                return fullName;
            }

            set
            {   
                //какие-то действия.
                fullName = value;
            }

        }

        //public void SetFullName(string fullName)
        //{
        //    this.fullName = fullName;
        //}
        //public string GetFullName() { return fullName; }
    }
}
