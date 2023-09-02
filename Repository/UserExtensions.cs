using Microsoft.EntityFrameworkCore;
using Riok.Mapperly.Abstractions;
using SSS.Repository.dbModels;
using SSS.Repository.Models;
using System.Runtime.CompilerServices;

namespace SSS.Repository;

public static partial class SSSMapper
{
    public static partial IQueryable<Models.User> ToUI(this IQueryable<dbModels.User> q);
    public static partial dbModels.User ToEF(this Models.User user);
    private static partial Models.User Map(dbModels.User user);
}


public partial class Repository
{
    public async Task<Models.User> GetUserAsync(string username)
    {
        try
        {

            var context = factory.CreateDbContext();

            var q = context.Users
                    .Where(x => x.Username == username)
                    .ToUI();
            return await q.FirstOrDefaultAsync() ?? new() { Username = username };
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
        return new Models.User();
    }
    public async Task<Models.User> SaveUserAsync(Models.User uiUser)
    {
        var context = factory.CreateDbContext();
        dbModels.User user = uiUser.ToEF();
        if (user.Id == 0)
        {
            context.Add(user);
        }
        else
        {
            context.Update(user);
        }
        await context.SaveChangesAsync();
        uiUser.Id = user.Id;
        return uiUser;
    }

}
