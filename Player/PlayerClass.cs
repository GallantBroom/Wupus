using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerClass
    {
        public string name { get; set; }
        public int score { get; set; }
        public int position { get; set; }
        public int arrows { get; set; }
        public int gold { get; set; }
        public int room { get; set; }
        public bool alive { get; set; }
        public PlayerClass(string name, int score, int position, int arrows, int gold, int room, bool alive)
        {
            this.name = name;
            this.score = score;
            this.position = position;
            this.arrows = arrows;
            this.gold = gold;
            this.room = room;
            this.alive = alive;
        }

        
    }
}
