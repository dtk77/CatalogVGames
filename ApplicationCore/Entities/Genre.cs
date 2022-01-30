namespace ApplicationCore
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public IList<Game> Games { get; set; } = new List<Game>();
    }
}