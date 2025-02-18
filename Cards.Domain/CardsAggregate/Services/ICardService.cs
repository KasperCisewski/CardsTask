namespace Cards.Domain.CardsAggregate.Services;

public interface ICardService
{
    Task<CardDetails?> GetCardDetails(string userId, string cardNumber);
}