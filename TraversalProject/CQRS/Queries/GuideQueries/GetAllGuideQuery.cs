using MediatR;
using System.Collections.Generic;
using AkınTurizm.CQRS.Results.GuideResults;

namespace AkınTurizm.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
