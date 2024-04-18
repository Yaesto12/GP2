using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YavuzKaanGezgin_MP_Midterm_215040049
{
    public class Enemy : Character
    {
        public Enemy(string name, int health, int damage) : base(name, health, damage)
        {
        }

        // enemy's attack
        public override void Attack(Character target)
        {
            Console.WriteLine($"{this.name} the enemy is attacking {target.name}!");
            target.health -= this.damage * 2; // Enemies deal double damage
            Console.WriteLine($"{target.name}'s health decreased to {target.health}!");
        }
    }
}

