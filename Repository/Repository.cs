using Microsoft.EntityFrameworkCore;

namespace SSS.Repository;
public partial class Repository
{
    private IDbContextFactory<SSSDatacontext> factory;
    private readonly ILogger<Repository> logger;

    public Repository(IDbContextFactory<SSSDatacontext> factory, ILogger<Repository> logger)
    {
        this.factory = factory;
        this.logger = logger;
    }
}
