using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapRepository
{
    public interface IMapDB
    {
        List<Map> GetAll();
        Map Get(int id);
        int Create(Map map);
        void Update(Map map);
        void Delete(int id);
    }
}
