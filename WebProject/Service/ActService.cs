using Microsoft.EntityFrameworkCore;
using WebProject.Models;
using WebProject.Modelss;
using WebProject.Modelsss;

namespace WebProject.Service
{
    public class ActService
    {
        //private NewsContext _db;
        private CartsContext _db1;
        private EBCNEWSContext _db2;
        public ActService(CartsContext db1, EBCNEWSContext db2)
        {
            //this._db = db;
            this._db1 = db1;
            this._db2 = db2;
        }

        //public async Task<IEnumerable<NEWSACT>> get()
        //{
        //    return await _db.NEWSACTs.Select(x => x).ToListAsync();
        //}
        public IEnumerable<Order> get()
        {
            return _db1.Orders.Select(x => x).ToList();
        }

        public IEnumerable<Newsvoice> get2()
        {
            return _db2.Newsvoices.Select(x => x).ToList();
        }
    }
}
