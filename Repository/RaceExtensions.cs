using Microsoft.EntityFrameworkCore;

namespace SSS.Repository;
public static partial class SSSMapper
{
    public static partial IQueryable<Models.Race> EFToUI(this IQueryable<dbModels.Race> q);
    public static partial dbModels.Race ToEF(this Models.Race item);
    private static partial Models.Race Map(dbModels.Race item);
}

public partial class Repository
{
    public async Task<List<Models.Race>> GetRacesAsync()
    {
        var context = factory.CreateDbContext();
        try
        {
            return await context.Races
                .OrderByDescending(x => x.StartTime)
                .EFToUI()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
        return new List<Models.Race>();
    }
    public async Task<Models.Race> SaveRaceAsync(Models.Race uiRace)
    {
        var context = factory.CreateDbContext();
        dbModels.Race race =  uiRace.ToEF();
        if (race.Id == 0)
        {
            context.Add(race);
        }
        else
        {
            context.Update(race);
        }
        await context.SaveChangesAsync();
        uiRace.Id = race.Id;
        return uiRace;

    }
    public async Task<Models.Race> GetRaceAsync(int id)
    {
        try
        {
            var context = factory.CreateDbContext();
            return await context.Races
                .Where(x => x.Id == id)
                .EFToUI()
                .FirstOrDefaultAsync()?? new();
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
        return new();
    }

}
