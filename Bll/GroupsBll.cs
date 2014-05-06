using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class GroupsBll
    {
        public void Save(string name, string type)
        {
            try
            {
                Dal.Groups groups = new Dal.Groups{ Name = name, Type = type };
                groups.Save();
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public void Update(int id, string name, string type)
        {
            try
            {
                Dal.Groups groups = new Dal.Groups{ Id = id, Name = name, Type = type };
                groups.Update();
            }
            catch (ApplicationException e)
            {
                throw new ApplicationException(e.Message);
            }
        }
    }
}
