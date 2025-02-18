using Cards.Domain.CardsAggregate.Queries;
using Microsoft.AspNetCore.Mvc;
using MillenniumTask.Args;

namespace MillenniumTask;

[ApiController]
[Route("[controller]")]
public class CardController : ControllerBase
{
    //TODO in future add QueryBus and marked all queries as internal implementation 
    [HttpPost]
    public async Task<IActionResult> GetCardActions(
        [FromBody] CardDetailsArgs args,
        [FromServices] GetAllowedActionsQuery query)
    {
        return Ok(await query.Get(new AllowedActionsQueryCriteria(args.UserId, args.CardNumber)));
    }
}