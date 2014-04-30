using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class GroupsBll
    {
        public string Save(string nome, string type)
        {
            try 
	        {
                Dal.Groups groups = new Dal.Groups();
                groups.Nome = nome;
                groups.Type = type;
                
                return groups.Save();
	        }
            catch (ApplicationException e)
	        {
                return e.Message;
	        }           
        }
    }
}
