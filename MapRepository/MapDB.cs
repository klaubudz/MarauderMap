using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Models;

namespace MapRepository
{
    public class MapDB : IMapDB
    {
        private readonly string _connectionString = @"C:\DB\Marauder";
        private readonly string _collectionname = "maps";

        public int Create(Map map)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Map>(_collectionname);

                return collection.Insert(map);
            }
        }

        public void Delete(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Map>(_collectionname);

                collection.Delete(id);
            }
        }

        public Map Get(int id)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Map>(_collectionname);

                return collection.FindById(id);
            }
        }

        public List<Map> GetAll()
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Map>(_collectionname);

                return collection.FindAll().ToList();
            }
        }

        public void Update(Map map)
        {
            using (var db = new LiteDatabase(_connectionString))
            {
                var collection = db.GetCollection<Map>(_collectionname);

                collection.Update(map);
            }
        }
    }
}
