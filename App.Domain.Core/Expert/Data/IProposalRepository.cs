﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface IProposalRepository
    {
        public Task<Expert.Entities.Proposal> CreateProposal(Expert.Entities.Proposal submittedProposal, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> UpdateProposal(Expert.Entities.Proposal updatedProposal, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> SoftDeleteProposal(int proposalId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> HardDeleteProposal(int proposalId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Proposal> GetProposalById(int proposalId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Proposal>> GetProposals(CancellationToken cancellationToken);
    }
}