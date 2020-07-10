using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFModels.Model
{
    public class VersionDTO
    {

        public Guid Id { get; set; }
        public string NombrePlataforma { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string NumeroVersion { get; set; }
        public string Ambiente { get; set; }
        public string RamaOrigen { get; set; }
        public string Descripcion { get; set; }

    }
}
