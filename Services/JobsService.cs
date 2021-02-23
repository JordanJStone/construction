using System;
using System.Collections.Generic;
using construction.Models;
using construction.Repositories;

namespace construction.Services
{
  public class JobsService
  {

    private readonly JobsRepository _repo;
    // private readonly KitsRepository _krepo;

    // public JobsService(JobsRepository repo, KitsRepository krepo)
    public JobsService(JobsRepository repo)
    {
      _repo = repo;
      //   _krepo = krepo;
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



    // internal IEnumerable<Job> GetJobsByKitId(int kitId)
    // {
    //   Kit exists = _krepo.Get(kitId);
    //   if (exists == null)
    //   {
    //     throw new Exception("Invalid Id");
    //   }
    //   return _repo.GetJobsByKitId(kitId);
    // }

  }
}