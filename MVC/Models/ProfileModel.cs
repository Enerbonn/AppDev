namespace MVC.Models

{
	public class ProfileModel
	{
	public int Age { get; set; }
	public string Name { get; set; }
	public string Favorite { get; set; }

	public ProfileModel(int Age, string Name, string Favorite){
    this.Age = Age;
    this.Name = Name;
	this.Favorite = Favorite;
	}
	}
}
