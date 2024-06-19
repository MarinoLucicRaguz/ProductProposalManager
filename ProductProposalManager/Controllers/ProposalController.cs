using Microsoft.AspNetCore.Mvc;
using ProductProposalManager.Enums;
using ProductProposalManager.Models;
using ProductProposalManager.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductProposalManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProposalService _proposalService;

        public ProposalController(IProposalService proposalService)
        {
            _proposalService = proposalService;
        }

        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Proposal>>> GetUserProposals(int userId)
        {
            var proposals = await _proposalService.GetUserProposals(userId);
            if (proposals == null)
            {
                return NotFound();
            }
            return Ok(proposals);
        }

        [HttpPost]
        public async Task<ActionResult> AddProposal([FromBody] Proposal proposal)
        {
            await _proposalService.AddProposal(proposal);
            return CreatedAtAction(nameof(GetUserProposals), new { userId = proposal.UserId }, proposal);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProposal(int id, [FromBody] ProposalStatus status)
        {
            await _proposalService.UpdateProposal(id, status);
            return NoContent();
        }
    }
}
