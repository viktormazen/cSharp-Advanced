using MyLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class ProFighter : Fighter, IStreet, Ibox
    {
        public ProFighter(double health, double powerPunch, double speed, double expirience) : base(health, powerPunch, speed)
        {
            Expirience = expirience;
        }
        public double Expirience { get; set; }

        public void DoBoxing(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Expirience;
            opponent.TakeDamage(dmg);
        }

        public void DoStreet(Fighter opponent)
        {
            double dmg = Speed + PowerPunch + Expirience;
            FightMethod(opponent, dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with karlicno,expected recovery 5 weeks");
        }
     
    }
}
