
namespace SFS.Domain.Common;

public abstract class AuditableAggregate<TId> : AggregateRoot<TId> where TId : notnull
{
    protected AuditableAggregate()
    {
    }

    protected AuditableAggregate(TId id) : base(id)
    {
    }

    public DateTime? CDT { get; set; }
    public DateTime? MDT { get; set; }
}
