namespace CarBook.Aplication.Features.Mediator.Results.AppUserResults;

public record GetCheckAppUserQueryResult(int Id,string UserName,string Role,bool IsExist);
