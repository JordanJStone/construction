using System.Collections.Generic;
using System.Data;
using construction.Models;
using Dapper;

namespace construction.Repositories
{
  public class JobsRepository
  {

    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Job> Get()
    {
      string sql = "SELECT * FROM jobs;";
      return _db.Query<Job>(sql);
    }

    internal Job Get(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id;";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal int Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs
      (name, description, location)
      VALUES
      (@Name, @Description, @Location);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newJob);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id;";
      _db.Execute(sql, new { id });
    }


    // internal IEnumerable<Job> GetJobsByKitId(int kitId)
    // {
    //   string sql = @"
    //   SELECT b.*,
    //   kb.id as KitJobId 
    //   FROM kitbricks kb
    //   JOIN jobs b ON b.id = kb.brickId
    //   WHERE kitId = @kitId";

    //   return _db.Query<KitBrickViewModel>(sql, new { kitId });
    // }

  }
}