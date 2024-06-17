using ProductProposalManager.Models;

namespace ProductProposalManager.Repositories.Interface
{
    public interface IProposalRepository
    {
        Task<IEnumerable<Proposal>> GetProposalsByUserId(int userId);
        Task<Proposal> GetProposalById(int proposalId);
        Task AddProposal(Proposal proposal);
        Task UpdateProposal(Proposal proposal);
    }
}
