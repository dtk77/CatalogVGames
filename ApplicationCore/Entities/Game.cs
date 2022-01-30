using System.Collections.Generic;

namespace ApplicationCore
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Developer { get; set; }



        public virtual IList<Genre> Genre { get; set; } = new List<Genre>();
    }
}
