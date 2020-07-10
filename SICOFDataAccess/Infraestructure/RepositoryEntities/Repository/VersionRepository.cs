using SICOFDataAccess.Entities;
using SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository;
using SICOFModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SICOFDataAccess.Infraestructure.RepositoryEntities.Repository
{
    public class VersionRepository : GenericRepository<VersionEntity, DataBaseContext>, IVersionRepository
    {
        private readonly DataBaseContext context;

        public VersionRepository(DataBaseContext context) : base(context)
        {
            this.context = context;
        }


        /// <summary>
        /// Consulta la Version masreciente
        /// </summary>
        /// <returns>Modelo Version</returns>
        public VersionDTO ConsultarVersionSICOF()
        {
            return (from x in context.Set<VersionEntity>()
                    orderby x.FechaPublicacion descending
                    select mapEntity2Dto(x)
                          ).FirstOrDefault();

        }

        /// <summary>
        /// Se realiza el mapero entre la Entidad Version y el Modelo VersionDTO
        /// </summary>
        /// <param name="x"> Entidad Version</param>
        /// <returns>Version DTO</returns>
        private static VersionDTO mapEntity2Dto(VersionEntity x)
        {
            return new VersionDTO
            {
                Ambiente = x.Ambiente,
                Descripcion = x.Descripcion,
                FechaPublicacion = x.FechaPublicacion,
                Id = x.Id,
                NombrePlataforma = x.NombrePlataforma,
                NumeroVersion = x.NumeroVersion,
                RamaOrigen = x.RamaOrigen
            };
        }
    }
}
