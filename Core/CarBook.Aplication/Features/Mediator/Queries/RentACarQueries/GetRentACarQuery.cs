
using CarBook.Aplication.Features.Mediator.Results.RentACarResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;

public record GetRentACarQuery(int LocationID,bool Available):IRequest<ServiceResult<List<GetRentACarQueryResult>>>;