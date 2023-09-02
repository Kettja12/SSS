using Microsoft.EntityFrameworkCore;

namespace SSS.Repository;
public static partial class SSSMapper
{
    public static partial IQueryable<Models.Boat> EFToUI(this IQueryable<dbModels.Boat> q);
    public static partial dbModels.Boat ToEF(this Models.Boat boat);
    private static partial Models.Boat Map(dbModels.Boat boat);
}


public partial class Repository
{
    public async Task<List<Models.Boat>> GetBoatsAsync()
    {
        var context = factory.CreateDbContext();
        try
        {
            return await context.Boats
                .OrderBy(x => x.Name)
                .EFToUI()
                .ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex.Message);
        }
        return new List<Models.Boat>();
    }
    public async Task<Models.Boat> SaveBoatAsync(Models.Boat uiBoat)
    {
        var context = factory.CreateDbContext();
        dbModels.Boat boat = uiBoat.ToEF();
        if (boat.Id == 0)
        {
            context.Add(boat);
        }
        else
        {
            context.Update(boat);
        }
        await context.SaveChangesAsync();
        uiBoat.Id = boat.Id;
        return uiBoat;

    }
  
}
