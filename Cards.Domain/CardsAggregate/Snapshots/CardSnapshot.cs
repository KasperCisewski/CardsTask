using Cards.Domain.CardsAggregate.ValueObjects;

namespace Cards.Domain.CardsAggregate.Snapshots;

public record CardSnapshot(CardType CardType, CardStatus CardStatus, bool IsPinSet);