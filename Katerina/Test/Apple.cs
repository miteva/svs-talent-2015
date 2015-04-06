using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Apple : Fruit
    {
        public bool GrowOnTree = true;
        

        public override string Grow() {

           //TODO smth
               return grows = "grows ";
            
        }
        /// <summary>
        ///Does the fruit have vitamins
        /// </summary>
        /// <param name="check">Chek if fruit has vitamins</param>
        ///<return>Return true or false</return> 

        public override void Does(bool check)
        {
            base.Does(check);
            //int len = 10;
            //for (int i = 0; i < len; i++)
            //{
            //    len++;
            //}
            //TODO smthelse
        }






        //static void Main(string[] args) {
            
        //    Apple a = new Apple();
        //    a.Color = "Red";
        //    a.vitamins = "A";
        //    a.grows = a.Grow();
        //    a.Does(true);

        //    Watermelon w = new Watermelon();
        //    w.Color = "Green";
        //    w.vitamins = "A";
        //    w.grows = w.Grow();
        //    w.Does(false);

        //    bool vitA=a.hasVitamin(a.vitamins);
        //    bool vitW = w.hasVitamin(w.vitamins);

        //    Fruit af = (Fruit)a;
        //    Fruit wf = (Fruit)w;
            

        //    Console.Write("Apples " + a.does + " and it " + a.grows +"on tree");
        //    Console.Write("\n Watermellons " + w.does + " and it " + w.grows );
        //    Console.Write("\n Fruits " + af.grows);
        //    Console.Write("\n Fruits " + wf.grows);
        //    //if (vitA && a.GrowOnTree) {

        //    //    Console.Write("This fruit "+a.does+" and it "+a.grows+" on tree");
        //    // }

        //    //if (!vitA && !a.GrowOnTree) {

        //    //    Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
        //    //}
        //    //if (vitA && !a.GrowOnTree)
        //    //{

        //    //    Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
        //    //}
        //    //if (!vitA && a.GrowOnTree)
        //    //{

        //    //    Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
        //    //}

        //    Console.ReadLine();





        //}
    }

    
}
