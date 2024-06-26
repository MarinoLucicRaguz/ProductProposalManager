﻿using ProductProposalManager.Enums;
using ProductProposalManager.Models.Common;

namespace ProductProposalManager.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public virtual ICollection<Proposal> Proposals { get; set; } = new List<Proposal>();
    }
}
