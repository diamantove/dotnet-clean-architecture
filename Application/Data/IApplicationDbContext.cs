namespace Application.Data;

public interface IApplicationDbContext
{
    DbSet<Topic> Topics { get; }
}
