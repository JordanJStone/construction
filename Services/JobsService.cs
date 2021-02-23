using System;
using System.Collections.Generic;
using construction.Models;
using construction.Repositories;

namespace construction.Services
{
  public class JobsService
  {

    private readonly JobsRepository _repo;
    private readonly ContractorsRepository _crepo;

    public JobsService(JobsRepository repo, ContractorsRepository crepo)
    {
      _repo = repo;
      _crepo = crepo;
    }


    internal IEnumerable<Job> Get()
    {
      return _repo.Get();
    }
    internal Job Get(int id)
    {
      Job exists = _repo.Get(id);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      return exists;
    }

    internal Job Create(Job newJob)
    {
      int id = _repo.Create(newJob);
      newJob.Id = id;
      return newJob;
    }


    internal string Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
      return "Successfully Deleted";
    }



    internal IEnumerable<Job> GetJobsByContractorId(int contractorId)
    {
      Contractor exists = _crepo.Get(contractorId);
      if (exists == null)
      {
        throw new Exception("Invalid Id");
      }
      return _repo.GetJobsByContractorId(contractorId);
    }

  }
}