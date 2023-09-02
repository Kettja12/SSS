using Microsoft.EntityFrameworkCore;

namespace SSS.Repository;
public static partial class SSSMapper
{
    public static partial IQueryable<Models.Result> EFToUI(this IQueryable<dbModels.Result> q);
    public static partial dbModels.Result UIToEF(this Models.Result item);
    private static partial Models.Result Map(dbModels.Result item);
}

public partial class Repository
{
    public async Task<List<Models.Result>> GetResultsAsync(int raceId)
    {
        try
        {

            var context = factory.CreateDbContext();
            return await context.Results
                .Where(x => x.RaceId == raceId)
                .EFToUI()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
        return new List<Models.Result>();
    }

    public async Task<Models.Result> SaveResultAsync(Models.Result uiResult)
    {
        var context = factory.CreateDbContext();
        dbModels.Result result = uiResult.UIToEF();
        if (result.Id == 0)
        {
            context.Add(result);
        }
        else
        {
            context.Update(result);
        }
        await context.SaveChangesAsync();
        uiResult.Id = result.Id;
        return uiResult;

    }

}
