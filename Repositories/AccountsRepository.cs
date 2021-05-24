using System.Data;

namespace allspice.Repositories
{
  public class AccountsRepository
  {
    private readonly IDbConnection _db;
    public AccountsRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}