using EPiSv3NetworkFolder.Context;
using EPiSv3NetworkFolder.DataTransferModels;
using EPiSv3NetworkFolder.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EPiSv3NetworkFolder.Controllers
{
    [ApiController]
    [Route("mobile")]
    public class MobileController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MobileController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("getdata/{episno}")]
        public IActionResult GetRequestData(string episno)
        {
            //var requestType = DetermineProcess(episno);
            //if(requestType == null)

            var ticket = context.TicketRequests
                .Include(x => x.TechSpec)
                .ThenInclude(x => x.Actions)
                .Include(x => x.Repair)
                .ThenInclude(x => x.Actions)
                .Include(x => x.Delivery)
                .ThenInclude(x => x.Actions)
                .Include(x => x.Staff)
                .ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == Convert.ToInt32(episno));

            if(ticket == null) return BadRequest("EPiS No does not exist.");

            IEnumerable<ActionTaken> actions = null;
            
            if((RequestType)ticket.RequestType == RequestType.TechSpecs) actions = ticket.TechSpec.Actions.Select(x => new ActionTaken
            {
                Action = x.ActionTaken,
                ActionDate = (DateTime)x.ActionDate
            });
            if ((RequestType)ticket.RequestType == RequestType.Repairs) actions = ticket.Repair.Actions.Select(x => new ActionTaken
            {
                Action = x.ActionTaken,
                ActionDate = (DateTime)x.ActionDate
            });
            if ((RequestType)ticket.RequestType == RequestType.Deliveries) actions = ticket.Delivery.Actions.Select(x => new ActionTaken
            {
                Action = x.ActionTaken,
                ActionDate = (DateTime)x.ActionDate
            });

            var data = new ProcessDetail
            {
                Id = ticket.Id,
                RequestType = (RequestType)ticket.RequestType,
                TicketStatus = (TicketStatus)ticket.TicketStatus,
                EPiSNo = "EPiS-" + ticket.Id,
                AssignedTo = ticket.Staff.User.FullName,
                AssignedToPos = ticket.Staff.User.Position,
                UserId = ticket.Staff.UserId,
                Actions = actions
            };

            return Ok(data);
        }

        private RequestType? DetermineProcess(string episno)
        {
            var process = context.TicketRequests.FirstOrDefault(x => x.Id == Convert.ToInt32(episno));
            if (process == null) return null;
            return (RequestType)process.RequestType;
        }
    }
}
