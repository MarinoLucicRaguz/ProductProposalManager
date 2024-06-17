using ProductProposalManager.Enums;
using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Interface;
using ProductProposalManager.Services.Interface;

namespace ProductProposalManager.Services.Implementation
{
    public class ProposalService : IProposalService
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalService(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }

        public Task<IEnumerable<Proposal>> GetUserProposals(int userId)
        {
            return _proposalRepository.GetProposalsByUserId(userId);
        }

        public Task AddProposal(Proposal proposal)
        {
            if (proposal == null)
            {
                return Task.FromException(new InvalidOperationException("Prijedlog je null."));
            }

            if (string.IsNullOrEmpty(proposal.ProposalText))
            {
                return Task.FromException(new InvalidOperationException("Opis prijedloga je obavezan."));
            }

            if (proposal.Product == null || proposal.Product.Id == 0)
            {
                return Task.FromException(new InvalidOperationException("Proizvod nije odabran ili nije validan."));
            }

            if (proposal.UserId == 0)
            {
                return Task.FromException(new InvalidOperationException("Korisnik nije validan."));
            }

            return _proposalRepository.AddProposal(proposal);
        }

        public async Task UpdateProposal(int proposalId, ProposalStatus status)
        {
            var existingProposal = await _proposalRepository.GetProposalById(proposalId);
            if (existingProposal == null)
            {
                throw new InvalidOperationException("Taj prijedlog ne postoji.");
            }

            existingProposal.Status = status;

            await _proposalRepository.UpdateProposal(existingProposal);
        }
    }
}
