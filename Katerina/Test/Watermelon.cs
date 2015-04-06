using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Watermelon :Fruit
    {

        public bool GrowOnTree = false;

        public override string Grow()
        {
            //TODO watermelon


          return  grows = "doesn't grow on tree";

        }

        public override void Does(bool check)
        {
            base.Does(check);
        }

        static void main(string[] args)
        {

            Watermelon a = new Watermelon();
            a.Color = "Red";
            a.vitamins = "B";
            
            bool vit =a.hasVitamin(a.vitamins);
            a.grows = a.Grow();        
            a.Does(false);

          
            if (vit && a.GrowOnTree)
            {

                Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
            }

            if (!vit && !a.GrowOnTree)
            {

                Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
            }
            if (vit && !a.GrowOnTree)
            {

                Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
            }
            if (!vit && a.GrowOnTree)
            {

                Console.Write("This fruit" + a.does + " and it" + a.grows + " on tree");
            }





        }
    }
}
