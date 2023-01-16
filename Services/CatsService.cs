namespace catHotel.Services;
public class CatsService
{
  private readonly CatsRepository _repo;

  public CatsService(CatsRepository repo)
  {
    // NOTE the repo layer takes over what mongoose used to do for us in node
    _repo = repo;
  }

  internal Cat Create(Cat catData)
  {
    Cat newCat = _repo.Create(catData);
    return newCat;
  }

  internal List<Cat> Get()
  {
    // const cats = await dbContext.Cats.find()
    // _repo => dbContext.Cats
    // inside repo, find will be written by us
    List<Cat> cats = _repo.Get();
    return cats;
  }

  internal string Remove(int id)
  {
    string message = _repo.Remove(id);
    return message;
  }
}