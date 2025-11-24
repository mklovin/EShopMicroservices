using MediatR;
namespace BuildingBlocks.CQRS;


public interface IQueryHandler <in TQuery> : IRequestHandler<TQuery, Unit>
    where TQuery : IQuery<Unit>
{
}

public interface IQueryHandler<in TQuery, TRespone>: IRequestHandler<TQuery, TRespone>
    where TQuery : IQuery<TRespone>
    where TRespone : notnull
{
}
