using ProductProposalManager.Models.Common;

namespace ProductProposalManager.Models
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public Proposal Proposal { get; set; }
    }
}
