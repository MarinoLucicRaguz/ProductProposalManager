using ProductProposalManager.Enums;
using ProductProposalManager.Models;

namespace ProductProposalManager.Services.Interface
{
    public interface IProposalService
    {
        Task<IEnumerable<Proposal>> GetUserProposals(int userId);
        Task AddProposal(Proposal proposal);
        Task UpdateProposal(int proposalId, ProposalStatus status);
    }
}
