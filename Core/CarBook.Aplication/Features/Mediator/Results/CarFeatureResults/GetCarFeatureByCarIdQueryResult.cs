namespace CarBook.Aplication.Features.Mediator.Results.CarFeatureResults;

public record GetCarFeatureByCarIdQueryResult(int Id, int FeatureId,string FeatureName, bool Available);