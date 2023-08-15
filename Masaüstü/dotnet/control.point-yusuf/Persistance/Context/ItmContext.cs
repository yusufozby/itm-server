using ITM_Server.Core.Domain;
using ITM_Server.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ITM_Server.Persistance.Context;

public class ItmContext : DbContext
{

    public ItmContext(DbContextOptions<ItmContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees => this.Set<Employee>();
    public DbSet<Group> Groups => this.Set<Group>();
    public DbSet<GroupCode> GroupCodes => this.Set<GroupCode>();
    public DbSet<Operation> Operations => this.Set<Operation>();
    public DbSet<LineTotalQuality> LineTotalQualities => this.Set<LineTotalQuality>();
    public DbSet<OperationActivation> OperationActivations => this.Set<OperationActivation>();

    public DbSet<StyleVaryant> Style_Variants => this.Set<StyleVaryant>();
    public DbSet<Style> Styles => this.Set<Style>();

    public DbSet<Line> Lines => this.Set<Line>();
    public DbSet<Varyant> Variants => this.Set<Varyant>();
    public DbSet<DailyPlanProduction> DailyProductionPlans => this.Set<DailyPlanProduction>();

    public DbSet<LineMovement> Daily_LineMovements => this.Set<LineMovement>();
    public DbSet<LostTime> LostTimes => this.Set<LostTime>();
    public DbSet<Job> Jobs => this.Set<Job>();
    public DbSet<LineEmployee> Line_Employees => this.Set<LineEmployee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       
        modelBuilder.ApplyConfiguration(new LineTotalQualityConfiguration());
        modelBuilder.ApplyConfiguration(new GroupCodeConfiguration());
        modelBuilder.ApplyConfiguration(new OperationActivationConfiguration());
        modelBuilder.ApplyConfiguration(new StyleConfiguration());
  
        modelBuilder.ApplyConfiguration(new OperationActivationStyleConfiguration());
        modelBuilder.ApplyConfiguration(new VaryantConfiguration());
        modelBuilder.ApplyConfiguration(new LineVaryantConfiguration());
        modelBuilder.ApplyConfiguration(new LineEmployeeConfiguration());



    }
}