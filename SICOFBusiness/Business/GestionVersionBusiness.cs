using SICOFBusiness.Interface;
using SICOFDataAccess.Interface;
using SICOFModels.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFBusiness.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class GestionVersionBusiness : IGestionVersionBusiness
    {

        private readonly IGestionVersionDataAccess _gestionVersionDataAccess;



        /// <summary>
        /// Inyección de dependencia ,comunicación con la capa de Data Access
        /// </summary>
        /// <param name="gestionVersionDataAccess">Interfaz de la capa Data Access</param>
        public GestionVersionBusiness(IGestionVersionDataAccess gestionVersionDataAccess)
        {
            this._gestionVersionDataAccess = gestionVersionDataAccess;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public VersionDTO ConsultarVersionSICOF()
        {
            try
            {
                //Insert Log Ini

                //Validacion de los DTO o objetos de entrada (Este método no tiene parametros de entrada)
                //Reglas de Negocio de ser necesario
                     

                //Insert Log Fin 
                return _gestionVersionDataAccess.ConsultarVersionSICOF();                

            }
            catch (Exception)
            {
                ///Log de Error 
                throw;
            }
            
        }
    }
}
