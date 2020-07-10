using SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository;
using SICOFDataAccess.Interface;
using SICOFModels.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SICOFDataAccess.ModuleDataAccess
{
    public class GestionVersionDataAccess : IGestionVersionDataAccess
    {
        private readonly IVersionRepository _versionRepository;

        public GestionVersionDataAccess(IVersionRepository versionRepository)
        {
            this._versionRepository = versionRepository;
        }

        /// <summary>
        /// Consulta la Version masreciente
        /// </summary>
        /// <returns>Modelo Version</returns>
        public VersionDTO ConsultarVersionSICOF()
        {
            try
            {
                return _versionRepository.ConsultarVersionSICOF();
            }
             catch (Exception)
            {

                throw;
            }
            
        }
    }
}
