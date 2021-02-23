using System.Data;
using construction.Models;
using Dapper;

namespace construction.Repositories
{
  public class BidsRepository
  {

    private readonly IDbConnection _db;

    public BidsRepository(IDbConnection db)
    {
      _db = db;
    }

    public int Create(Bid newBid)
    {
      string sql = @"
    INSERT INTO bids
    (jobId, contractorId)
    VALUES
    (@JobId, @ContractorId);
    SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newBid);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM bids WHERE id = @id;";
      _db.Execute(sql, new { id });
    }

  }
}