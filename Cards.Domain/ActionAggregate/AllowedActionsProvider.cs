using Cards.Domain.CardsAggregate.ValueObjects;

namespace Cards.Domain.ActionAggregate;

//Here we have two solutions
//or we are keeping those mapping on some kind of DB and we can set it by configuration(in UI or somewhere else)
//Or we should keep that map on the CardDetails Aggregate
public class CardDetails : IAllowedActionsProvider
{
    private readonly Dictionary<(CardType CardType, CardStatus CardStatus, bool IsSetPin), List<Action>> _allowedActionMaps = new()
    {
        { (CardType.Prepaid, CardStatus.Ordered, true), [Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Inactive, true), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Active, true), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Restricted, true), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Blocked, true), [Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action7, Actions.Action8, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Expired, true), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Closed, true), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Prepaid, CardStatus.Ordered, false), [Actions.Action3, Actions.Action4, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Inactive, false), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Active, false), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Prepaid, CardStatus.Restricted, false), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Blocked, false), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Expired, false), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Prepaid, CardStatus.Closed, false), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Debit, CardStatus.Ordered, true), [Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Inactive, true), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Active, true), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Restricted, true), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Blocked, true), [Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action7, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Expired, true), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Debit, CardStatus.Closed, true), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Debit, CardStatus.Ordered, false), [Actions.Action3, Actions.Action4, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Inactive, false), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Active, false), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Debit, CardStatus.Restricted, false), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Blocked, false), [Actions.Action3, Actions.Action4, Actions.Action8, Actions.Action9] },
        { (CardType.Debit, CardStatus.Expired, false), [Actions.Action3, Actions.Action4, Actions.Action9] },
        { (CardType.Debit, CardStatus.Closed, false), [Actions.Action3, Actions.Action4, Actions.Action9] },

        { (CardType.Credit, CardStatus.Ordered, true), [Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Inactive, true), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action6, Actions.Action5, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Active, true), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action6, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Restricted, true), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Blocked, true), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action6, Actions.Action7, Actions.Action8, Actions.Action9] },
        { (CardType.Credit, CardStatus.Expired, true), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Closed, true), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },

        { (CardType.Credit, CardStatus.Ordered, false), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Inactive, false), [Actions.Action2, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Active, false), [Actions.Action1, Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action7, Actions.Action8, Actions.Action9, Actions.Action10, Actions.Action11, Actions.Action12, Actions.Action13] },
        { (CardType.Credit, CardStatus.Restricted, false), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Blocked, false), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action8, Actions.Action9] },
        { (CardType.Credit, CardStatus.Expired, false), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
        { (CardType.Credit, CardStatus.Closed, false), [Actions.Action3, Actions.Action4, Actions.Action5, Actions.Action9] },
    };

    public Dictionary<(CardType CardType, CardStatus CardStatus, bool IsSetPin), List<Action>> GetMap() => _allowedActionMaps;
}