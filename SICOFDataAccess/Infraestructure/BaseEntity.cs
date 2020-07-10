using SICOFModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFDataAccess.Infraestructure
{
    public class BaseEntity
    {
        public EstadoRegistro Estado { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string UsuarioCrea { get; set; }
        public DateTime fechaEdicion { get; set; }
        public string usuarioModifica { get; set; }
        //Todo: Quitar los campos fechaEliminacion y UsuarioEliminacion
        //public DateTime? fechaEliminacion { get; set; }
        //public string UsuarioElimina { get; set; }
    }
}
