namespace catHotel.Repositories;



public class CatsRepository
{

  private List<Cat> catDb;

  // NOTE only written this way today for fake database
  // NOTE this whole repo will look different for today
  public CatsRepository()
  {
    this.catDb = new List<Cat>(){
    new Cat(1, "Maxell", 2, "yellow-green"),
    new Cat(2, "Jeremiah", 6, "Gray"),
    new Cat(3, "Randall", 11, "Black"),
    new Cat(4, "Abraham", 72, "Orange"),
    new Cat(5, "Archie", 4, "Tabby")
  };
  }

  internal Cat Create(Cat catData)
  {

    catData.Id = catDb[catDb.Count - 1].Id + 1;
    catDb.Add(catData);
    return catData;

  }

  internal List<Cat> Get()
  {
    return catDb;
  }

  internal string Remove(int id)
  {
    Cat catToRemove = catDb.Find(c => c.Id == id);
    // are the you the creator 
    // can you do this?
    bool result = catDb.Remove(catToRemove);
    if (result)
    {
      return $"{catToRemove.Name} was removed from db";
    }
    return "no cat to delete.";
  }
}