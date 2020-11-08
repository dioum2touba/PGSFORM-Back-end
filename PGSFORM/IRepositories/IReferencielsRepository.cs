using PGSFORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGSFORM.IRepositories
{
    public interface IReferencielsRepository
    {
        // GET: api/Referenciels
        Task<IEnumerable<Referenciel>> GetReferenciel();

        // GET: api/Referenciels/5
        Task<Referenciel> GetReferenciel(int id);

        // PUT: api/Referenciels/5
        Task PutReferenciel(int id, Referenciel referenciel);

        // POST: api/Referenciels
        Task<Referenciel> PostReferenciel(Referenciel referenciel);

        // DELETE: api/Referenciels/5
        Task<Referenciel> DeleteReferenciel(int id);

        bool ReferencielExists(int id);
    }
}
