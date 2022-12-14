using Npgsql;
using Template.Data.Infrastructure.Abstractions;
using Template.Data.Infrastructure.Entities;

namespace Template.Data.Infrastructure.Repositories.Interfaces;

public interface IUsersRepository : IRepository<User, NpgsqlConnection>
{
    User FindByUsernameAndPassword(string username, string password);
}