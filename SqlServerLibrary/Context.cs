namespace SqlServerLibrary;

class TestDbContext : DbContext
{

    public TestDbContext(DbContextOptions options) : base(options) { }

    protected TestDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Server=localhost;Database=master;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
