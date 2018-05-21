using MapRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarauderMap.Controllers
{
    public class MapController : ApiController
    {
        private readonly IMapDB _mapDB;

        public MapController(IMapDB mapDB)
        {
            _mapDB = mapDB;
        }

        public List<Map> Get() => _mapDB.GetAll();

        public Map Get(int id) => _mapDB.Get(id);

        public int Post([FromBody] Map map) => _mapDB.Create(map);

        public void Put([FromBody] Map map) => _mapDB.Update(map);

        public void Delete(int id) => _mapDB.Delete(id);
    }
}
