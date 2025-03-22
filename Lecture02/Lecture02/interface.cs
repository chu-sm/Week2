using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Lecture02
{
    class @interface
    {
        interface IMovingEntity
        {
            void MoveTo(Vector3 destination);
        }
        public class Goblin:IMovingEntity
        {
            public void MoveTo(Vector3 destination)
            {
                Console.WriteLine(destination + "까지 기어서 이동");
            }
        }
        public class Slime:IMovingEntity
        {
            public void MoveTo(Vector3 destination)
            {
                Console.WriteLine(destination + "까지 기어서 이동");
            }
        }
        public class GameController:MonoBehaviour{
            private IMovingEntity goblin;
            private IMovingEntity slime;
           }

        private void Awake()
        {
            goblin = new Goblin();
            slime = new Slime();

            goblin.MoveTo(new Vector3(1,2,3));
            slime.MoveTo(new Vector3(4.5.6));
        }
}
