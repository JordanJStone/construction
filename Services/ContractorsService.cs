using System;
using System.Collections.Generic;
using construction.Models;
using construction.Repositories;

namespace construction.Services
{
  public class ContractorsService
  {

    private readonly ContractorsRepository _repo;
    // private readonly KitsRepository _krepo;

    // public ContractorsService(ContractorsRepository repo, KitsRepository krepo)
    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
      //   _krepo = krepo;
    }


    internal IEnumerable<Contractor> Get()
    {
      return _repo.Get();
    }
    internal Contractor Get(int id)
    {
      Contractor exists = _repo.Get(id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      return exists;
    }

    internal Contractor Create(Contractor newContractor)
    {
      int id = _repo.Create(newContractor);
      newContractor.Id = id;
      return newContractor;
    }


    internal string Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
      return "Successfully Deleted";
    }



    // internal IEnumerable<Contractor> GetContractorsByKitId(int kitId)
    // {
    //   Kit exists = _krepo.Get(kitId);
    //   if (exists == null)
    //   {
    //     throw new Exception("Invalid Id");
    //   }
    //   return _repo.GetContractorsByKitId(kitId);
    // }

  }
}