using EPiSv3NetworkFolder.DbModels;
using EPiSv3NetworkFolder.Enums;
using Action = EPiSv3NetworkFolder.DbModels.Action;

namespace EPiSv3NetworkFolder.DataTransferModels
{
    public class ProcessDetail
    {
        public int Id { get; set; }
        public RequestType RequestType { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public string EPiSNo { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToPos { get; set; }
        public string UserId { get; set; }
        public IEnumerable<ActionTaken>? Actions { get; set; }
    }
}
