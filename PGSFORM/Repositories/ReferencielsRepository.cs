using PGSFORM.IRepositories;
using PGSFORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSFORM.Repositories
{
    public class ReferencielsRepository : IReferencielsRepository
    {
        private readonly PgsformContext _context;

        public ReferencielsRepository(PgsformContext context)
            => (_context) = (context);

        public async Task<Referenciel> DeleteReferenciel(int id)
        {
            var referenciel = await _context.Referenciel.FindAsync(id);
            if (referenciel == null)
            {
                return null;
            }

            _context.Referenciel.Remove(referenciel);
            await _context.SaveChangesAsync();

            return referenciel;
        }

        public Task<IEnumerable<Referenciel>> GetReferenciel()
        {
            throw new NotImplementedException();
        }

        public Task<Referenciel> GetReferenciel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Referenciel> PostReferenciel(Referenciel referenciel)
        {
            throw new NotImplementedException();
        }

        public Task PutReferenciel(int id, Referenciel referenciel)
        {
            throw new NotImplementedException();
        }

        public bool ReferencielExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
