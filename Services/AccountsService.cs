using System;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
  public class AccountsService
  {
    private readonly AccountsRepository _repo;

    public AccountsService(AccountsRepository repo)
    {
      _repo = repo;
    }

    internal Account GetOrCreateAccount(object userInfo)
    {
      throw new NotImplementedException();
    }
  }
}