namespace construction.Models
{
  public class Job
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
  }

  // TODO add ViewModel here? (id needed)
  public class BidViewModel : Job
  {
    public int BidId { get; set; }
  }
}