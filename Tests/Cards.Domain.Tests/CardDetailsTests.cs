using Cards.Domain.ActionAggregate;
using Cards.Domain.CardsAggregate.ValueObjects;
using FluentAssertions;
using Action = System.Action;
using CardDetails = Cards.Domain.ActionAggregate.CardDetails;

namespace Cards.Domain.Tests;

[TestFixture]
public class CardDetailsTests
{
    private IAllowedActionsProvider _provider;

    [SetUp]
    public void SetUp()
    {
        _provider = new CardDetails();
    }

    [TestCase(CardType.Prepaid, CardStatus.Closed, false, ExpectedResult = new[] { "Action3", "Action4", "Action9" })]
    [TestCase(CardType.Credit, CardStatus.Blocked, true, ExpectedResult = new[] { "Action3", "Action4", "Action5", "Action6", "Action7", "Action8", "Action9" })]
    [TestCase(CardType.Credit, CardStatus.Blocked, false, ExpectedResult = new[] { "Action3", "Action4", "Action5", "Action8", "Action9" })]
    public IEnumerable<string> GetAllowedActions_ShouldReturnCorrectActions(CardType cardType, CardStatus cardStatus, bool isPinSet)
    {
        var cardDetails = new CardsAggregate.CardDetails("123456", cardType, cardStatus, isPinSet);
        return cardDetails.GetAllowedActions(_provider).Select(a => a.Name);
    }

    [Test]
    public void GetAllowedActions_WhenCardDetailsNotInMap_ShouldBeArgumentException()
    {
        var cardDetails = new CardsAggregate.CardDetails("123456", CardType.Debit, (CardStatus)999, false);
        Action act = () => cardDetails.GetAllowedActions(_provider);

        act.Should().Throw<ArgumentException>();
    }
}