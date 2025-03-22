using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Lecture02
{
    class property
    {
        public class Player
        {
            private int currentHP;
            public int CurrentHP
            {
                get => currentHP;
                set
                {
                    if(currentHP > 0)
                    {
                        currentHP = value;
                    }
                    else
                    {
                        currentHP = 0;
                    }
                }
            }
        }
        public class GameController
        {
            private void Awake()
            {
                Player player = new Player();
                player.CurrentHP = 100;
                Console.WriteLine("Player HP : " + player.CurrentHP);
                player.CurrentHP = -100;
                Console.WriteLine("Player HP : " + player.CurrentHP);
            }
        }
    }
}
*/