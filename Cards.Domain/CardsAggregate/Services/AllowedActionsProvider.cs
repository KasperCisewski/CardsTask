using Cards.Domain.CardsAggregate.ValueObjects;

namespace Cards.Domain.CardsAggregate.Services;

public class AllowedActionsProvider
{
    public static readonly Dictionary<(CardType, CardStatus), List<Action>> AllowedActionsMap = new()
    {
        { (CardType.Prepaid, CardStatus.Ordered), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Inactive), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Active), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Restricted), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Blocked), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Expired), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Closed), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Debit, CardStatus.Ordered), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Inactive), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Active), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Restricted), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Blocked), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Expired), [Actions.Action3, Actions.Action4,Actions.Action9] },
        { (CardType.Debit, CardStatus.Closed), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Credit, CardStatus.Ordered), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Inactive), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Active), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Restricted), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Blocked), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9] },
        { (CardType.Credit, CardStatus.Expired), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Closed), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
    };
}