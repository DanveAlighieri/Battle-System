using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            mp = 5;
            hp = 20;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }
    public class Ranger : Player
    {
        public Ranger(string name) : base(name)
        {
            strength = 4;
            mp = 10;
            hp = 10;
            ClassName = "Ranger";
            EquipItem(new Weapon("Bow", "a basic Bow", 1));
        }
        public override int Attack()
        {
            Console.WriteLine("I'm gonna nuke ya");
            return (1000000);
        }
    }
    public class Wizard : Player
    {
        public Wizard(string name) : base(name)
        {
            strength = 7;
            mp = 20;
            hp = 5;
            ClassName = "Wizard";
            EquipItem(new Weapon("Staff", "a basic Staff", 1));
        }
    }
}
