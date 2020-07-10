using SICOFDataAccess.Entities;
using SICOFModels.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository
{
    public interface IVersionRepository : IGenericRepository<VersionEntity>
    {
        VersionDTO ConsultarVersionSICOF();
    }
}
