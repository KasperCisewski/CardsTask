using Cards.Domain.CardsAggregate.ValueObjects;

namespace Cards.Domain.ActionAggregate;

public interface IAllowedActionsProvider
{
    Dictionary<(CardType CardType, CardStatus CardStatus, bool IsSetPin), List<Action>> GetMap();
}