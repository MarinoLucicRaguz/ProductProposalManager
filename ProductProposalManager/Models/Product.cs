using ProductProposalManager.Models.Common;

namespace ProductProposalManager.Models
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
    }
}
