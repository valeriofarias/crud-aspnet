using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Core;

namespace Bll
{
    public class GroupsBll
    {
        public void Save(string name, int type)
        {
            Groups groups = new Groups { Name = name, Type = type };
            try
            { 
                GroupsDal.Save(groups);
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public void Update(int id, string name, int type)
        {
            Groups groups = new Groups { Id = id, Name = name, Type = type };
            try
            {
                GroupsDal.Update(groups);
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public Groups FindById(int id)
        {
            Groups groups = new Groups();
            try
            {
                groups = GroupsDal.FindById(id);
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
            return groups;
        }

        public List<Groups> FindAll()
        {
            List<Groups> listGroups = new List<Groups>();
            try
            {
                listGroups = GroupsDal.FindAll();
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
            return listGroups;
        }
    }
}
