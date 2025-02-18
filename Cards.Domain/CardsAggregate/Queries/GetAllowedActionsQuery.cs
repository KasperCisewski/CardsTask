using Cards.Domain.ActionAggregate;
using Cards.Domain.CardsAggregate.Services;
using Action = Cards.Domain.ActionAggregate.Action;

namespace Cards.Domain.CardsAggregate.Queries;

public class GetAllowedActionsQuery
{
    private readonly ICardService _cardService;
    private readonly IAllowedActionsProvider _allowedActionsProvider;

    public GetAllowedActionsQuery(ICardService cardService, IAllowedActionsProvider allowedActionsProvider)
    {
        _cardService = cardService;
        _allowedActionsProvider = allowedActionsProvider;
    }

    public async Task<IReadOnlyCollection<Action>> Get(AllowedActionsQueryCriteria queryCriteria)
    {
        var cardDetails = await _cardService.GetCardDetails(queryCriteria.UserId, queryCriteria.CardNumber);

        if (cardDetails is null)
        {
            throw new ArgumentNullException(nameof(cardDetails), $"Card details for user with id: {queryCriteria.UserId} and card numer: {queryCriteria.CardNumber} was not found");
        }

        return cardDetails.GetAllowedActions(_allowedActionsProvider);
    }
}