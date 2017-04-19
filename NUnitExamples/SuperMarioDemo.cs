using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    public class SuperMarioDemo
    {
        public SuperMarioDemo(int health)
        {
            Health = health;

            InitializePowers();

            IsAlive = true;
        }

        public string Name { get { return "Mario"; } }
        public int Health { get; set; }
        public List<string> Powers { get; set; }

        public bool IsAlive { get; set; }

        public void TakeRest()
        {
            var r = new Random();

            var healthIncrease = r.Next(1, 101);

            Health += healthIncrease;
        }

        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }

        private void InitializePowers()
        {
            Powers = new List<string> {
                "Unlimited Lives",
                "Untouchable",
                "High Jumper",
                //""
            };
        }
    }
}
