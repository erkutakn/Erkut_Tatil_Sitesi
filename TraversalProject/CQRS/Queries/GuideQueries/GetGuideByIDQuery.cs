using MediatR;
using AkınTurizm.CQRS.Results.GuideResults;

namespace AkınTurizm.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
