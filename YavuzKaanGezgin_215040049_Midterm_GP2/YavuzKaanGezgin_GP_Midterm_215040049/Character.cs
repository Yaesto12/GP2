using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YavuzKaanGezgin_MP_Midterm_215040049
{
    public class Character
    {
        public string name;
        public int health;
        public int damage;

        // character building
        public Character(string name, int health, int damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }

        // attacking
        public virtual void Attack(Character target)
        {
            Console.WriteLine($"{this.name} is attacking {target.name}!");
            target.health -= this.damage;
            Console.WriteLine($"{target.name}'s health decreased to {target.health}!");
        }

        // status
        public virtual void Status()
        {
            Console.WriteLine($"{this.name} - Health: {this.health}, Damage: {this.damage}");
        }
    }
}
