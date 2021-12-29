namespace RoboSum.Persistence.EntityBuilders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoboSum.Domain.Entities;

/// <summary>
/// Represents an entity builder for <see cref="Teacher"/>.
/// </summary>
public class TeacherBuilder : IEntityTypeConfiguration<Teacher>
{
    /// <inheritdoc cref="IEntityTypeConfiguration{TEntity}.Configure(EntityTypeBuilder{TEntity})"/>
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        _ = builder
            .HasOne(teacher => teacher.School)
            .WithMany(school => school.Teachers)
            .HasForeignKey(teacher => teacher.SchoolId);

        _ = builder
            .HasMany(teacher => teacher.Teams)
            .WithOne(team => team.Teacher)
            .HasForeignKey(teacher => teacher.TeacherId);
    }
}
