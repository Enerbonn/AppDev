namespace MVC.Models
{
    public class EnerbonModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Favorite { get; set; }
        public string Occupation { get; set; }
        public string LivesIn { get; set; }
        public string[] Skills { get; set; }
        public string Portfolio { get; set; }

        public EnerbonModel(int Age, string Name, string Favorite, string Occupation, string LivesIn, string[] Skills, string Portfolio)
        {
            this.Age = Age;
            this.Name = Name;
            this.Favorite = Favorite;
            this.Occupation = Occupation;
            this.LivesIn = LivesIn;
            this.Skills = Skills;
            this.Portfolio = Portfolio;
        }
    }
}
