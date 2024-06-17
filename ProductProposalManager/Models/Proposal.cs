using ProductProposalManager.Enums;
using ProductProposalManager.Models.Common;

namespace ProductProposalManager.Models
{
    public class Proposal : BaseModel
    {
        public string ProposalText { get; set; }
        public ProposalStatus Status { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
