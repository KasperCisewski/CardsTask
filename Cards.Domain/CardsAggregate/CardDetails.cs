using Cards.Domain.ActionAggregate;
using Cards.Domain.CardsAggregate.ValueObjects;
using Action = Cards.Domain.ActionAggregate.Action;

namespace Cards.Domain.CardsAggregate;


public record CardDetails(string CardNumber, CardType CardType, CardStatus CardStatus, bool IsPinSet)
{

    public IReadOnlyCollection<Action> GetAllowedActions(IAllowedActionsProvider allowedActionsProvider)  
    {  
        var key = (CardType, CardStatus, IsPinSet);  
        
        return allowedActionsProvider.GetMap().TryGetValue(key, out var specificActions)  
            ? new List<Action>(specificActions)  
            : throw new ArgumentException(key.ToString());  
    }  
}
