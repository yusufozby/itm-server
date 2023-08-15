using ITM_Server.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ITM_Server.Persistance.Configurations;



public class GroupCodeConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasOne(x => x.GroupCode)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.GroupCodeId);
    }
}

public class LineTotalQualityConfiguration: IEntityTypeConfiguration<LineTotalQuality>
{
    public void Configure(EntityTypeBuilder<LineTotalQuality> builder)
    {
        builder.HasOne(x => x.Group)
            .WithMany(x => x.LineTotalQualities)
            .HasForeignKey(x => x.GroupId);
    }
}






public class OperationActivationConfiguration : IEntityTypeConfiguration<OperationActivation>
{
    public void Configure(EntityTypeBuilder<OperationActivation> builder)
    {
        builder.HasOne(x => x.Operation).WithMany(x => x.OperationActivations).HasForeignKey(x => x.OperationId);
    }

}

public class OperationActivationStyleConfiguration : IEntityTypeConfiguration<OperationActivation>
{
    public void Configure(EntityTypeBuilder<OperationActivation> builder)
    {
        builder.HasOne(x => x.Style).WithMany(x => x.OperationActivations).HasForeignKey(x => x.styleId);
    }
    
}



public class VaryantConfiguration : IEntityTypeConfiguration<StyleVaryant>
{
    public void Configure(EntityTypeBuilder<StyleVaryant> builder)
    {
        builder.HasOne(x => x.Varyant).WithMany(x => x.StyleVaryants).HasForeignKey(x => x.VaryantId);
    }
}

public class StyleConfiguration : IEntityTypeConfiguration<StyleVaryant>
{
    public void Configure(EntityTypeBuilder<StyleVaryant> builder)
    {
        builder.HasOne(x => x.Style).WithMany(x => x.StyleVaryants).HasForeignKey(x => x.StyleId);
    }
}


public class LineVaryantConfiguration : IEntityTypeConfiguration<LineTotalQuality>
{
    public void Configure(EntityTypeBuilder<LineTotalQuality> builder)
    {
        builder.HasOne(x => x.StyleVaryant).WithMany(x => x.LineTotalQualities).HasForeignKey(x => x.Style_VaryantId);
    }  
}

public class LineEmployeeConfiguration : IEntityTypeConfiguration<LineTotalQuality>
{
    public void Configure(EntityTypeBuilder<LineTotalQuality> builder)
    {
        builder.HasOne(x => x.Employee).WithMany(x => x.LineTotalQualities).HasForeignKey(x => x.EmployeeId);
    }
}













