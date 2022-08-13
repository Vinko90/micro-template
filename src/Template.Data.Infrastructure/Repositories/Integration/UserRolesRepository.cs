using Microsoft.Extensions.Options;
using Template.Data.Infrastructure.Common;
using Template.Data.Infrastructure.Entities;
using Template.Data.Infrastructure.Repositories.Interfaces;

namespace Template.Data.Infrastructure.Repositories.Integration;

public class UserRolesRepository : 
    Repository<UserRoles>, IUserRolesRepository
{
    public UserRolesRepository(IOptions<DbSettings> options)
        : base(options)
    {
    }

    public IEnumerable<UserRoles> GetRoleIdsByUserId(object id) => 
        Query(x => x.UserId == (int) id,
            transaction: _unitOfWork?.Transaction)?.ToList();
    
    public IEnumerable<UserRoles> GetAllByRoleId(object id) => 
        Query(x => x.RoleId == (int) id,
            transaction: _unitOfWork?.Transaction)?.ToList();
}