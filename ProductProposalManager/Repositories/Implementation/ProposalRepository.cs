using ProductProposalManager.Enums;
using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Interface;

namespace ProductProposalManager.Repositories.Implementation
{
    public class ProposalRepository : IProposalRepository
    {
        private readonly List<Proposal> _proposals;

        public ProposalRepository()
        {
            _proposals = new List<Proposal>
            {
                new Proposal { Id = 1, UserId = 1, ProductId = 1, ProposalText = "Prijedlog za proizvod broj 1.", Status = ProposalStatus.ACCEPTED },
                new Proposal { Id = 2, UserId = 1, ProductId = 2, ProposalText = "Prijedlog za proizvod broj 2.", Status = ProposalStatus.REJECTED },
                new Proposal { Id = 3, UserId = 2, ProductId = 1, ProposalText = "Prijedlog za proizvod broj 1.", Status = ProposalStatus.REJECTED },
            };
        }

        public Task<IEnumerable<Proposal>> GetProposalsByUserId(int userId)
        {
            return Task.FromResult(_proposals.Where(p => p.UserId == userId).AsEnumerable());
        }

        public Task<Proposal> GetProposalById(int proposalId)
        {
            return Task.FromResult(_proposals.FirstOrDefault(p => p.Id == proposalId));
        }
        public Task AddProposal(Proposal proposal)
        {
            proposal.Id = _proposals.Count + 1;
            _proposals.Add(proposal);
            return Task.CompletedTask;
        }

        public Task UpdateProposal(Proposal proposal)
        {
            var existingProposal = _proposals.FirstOrDefault(p => p.Id == proposal.Id);
            existingProposal = proposal;
            return Task.CompletedTask;
        }
    }
}
