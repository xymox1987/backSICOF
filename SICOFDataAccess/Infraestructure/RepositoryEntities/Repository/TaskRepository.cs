using SICOFDataAccess.Entities;
using SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SICOFDataAccess.Infraestructure.RepositoryEntities.Repository
{
    public class TaskRepository : GenericRepository<TaskEntity, DataBaseContext>, ITaskRepository
    {
        public TaskRepository(DataBaseContext context) : base(context)
        {


        }
    }
}
