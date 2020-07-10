using SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository;
using SICOFDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SICOFDataAccess.ModuleDataAccess
{

    public class HomeDataAccess : IHomeDataAccess
    {
        private readonly ITaskRepository _taskRepository;


        public HomeDataAccess(ITaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ObetnerDescripcion()
        {
            try
            { //Insert de Log De Entrada  LogInfo
                var x = this._taskRepository.GetAll();
                //Insert de Log De Salida   LogError 
                return x.FirstOrDefault().Description;
                
            }
            catch (Exception)
            {
                //Log De Error Excepcion de Base de datos , 
                throw;
            }
            
        }
    }

}
