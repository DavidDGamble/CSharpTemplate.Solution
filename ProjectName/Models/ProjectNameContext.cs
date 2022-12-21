// Needed for accessing database

using Microsoft.EntityFrameworkCore;


namespace [ProjectName].Models // CHANGE PROJECT NAME!!!
{
  public class [ProjectName]Context : DbContext // CHANGE PROJECT NAME!!!
  {
    public DbSet<ClassName> ClassNames { get; set; }  // CHANGE CLASS NAME!!!

    public [ProjectName]Context(DbContextOptions options) : base(options) { } // CHANGE PROJECT NAME!!!
  }
}