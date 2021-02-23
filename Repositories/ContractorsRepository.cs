using System.Collections.Generic;
using System.Data;
using construction.Models;
using Dapper;

namespace construction.Repositories
{
  public class ContractorsRepository
  {

    private readonly IDbConnection _db;

    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Contractor> Get()
    {
      string sql = "SELECT * FROM contractors;";
      return _db.Query<Contractor>(sql);
    }

    internal Contractor Get(int id)
    {
      string sql = "SELECT * FROM contractors WHERE id = @id;";
      return _db.QueryFirstOrDefault<Contractor>(sql, new { id });
    }

    internal int Create(Contractor newContractor)
    {
      string sql = @"
      INSERT INTO contractors
      (company, workers)
      VALUES
      (@Company, @Workers);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newContractor);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM contractors WHERE id = @id;";
      _db.Execute(sql, new { id });
    }


    // internal IEnumerable<Contractor> GetContractorsByKitId(int kitId)
    // {
    //   string sql = @"
    //   SELECT b.*,
    //   kb.id as KitContractorId 
    //   FROM kitcontractors kb
    //   JOIN contractors b ON b.id = kb.contractorId
    //   WHERE kitId = @kitId";

    //   return _db.Query<KitBrickViewModel>(sql, new { kitId });
    // }

  }
}