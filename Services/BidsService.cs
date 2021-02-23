using construction.Models;
using construction.Repositories;

namespace construction.Services
{
  public class BidsService
  {

    private readonly BidsRepository _repo;

    public BidsService(BidsRepository repo)
    {
      _repo = repo;
    }

    public Bid Create(Bid newBid)
    {
      int id = _repo.Create(newBid);
      newBid.Id = id;
      return newBid;
    }

    internal string Delete(int id)
    {
      _repo.Delete(id);
      return "Successfully Deleted";
    }

  }
}