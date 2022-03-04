using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spearman spearman1 = new Spearman();
            Skeleton skeleton1 = new Skeleton();
            int damage1, damage2;
            while (!spearman1.IsDead() && !skeleton1.IsDead())
            {
                damage1 = spearman1.Storming();
                skeleton1.LossOfHealth(damage1);
                if (!skeleton1.IsDead())
                {
                    damage2 = skeleton1.Storming();
                    spearman1.LossOfHealth(damage2);
                    Console.WriteLine(damage2);
                }
            }
          
            Console.WriteLine("Копейщик 1 мертв: {0}", spearman1.IsDead());
            Console.WriteLine("Скелетон 1 мертв: {0}", skeleton1.IsDead());
            Console.ReadLine();
        }

    }
}