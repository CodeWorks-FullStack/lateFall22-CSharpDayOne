namespace catHotel.Models;

public class Cat
{
  // NOTE this constructor is for FAKEDB only
  public Cat(int id, string name, int age, string color)
  {
    Id = id;
    Name = name;
    Age = age;
    Color = color;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public string Color { get; set; }

}