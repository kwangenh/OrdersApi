using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class ShipTosRepository :IShipTosRepository
    {
        public List<ShipTo> GetShipTos()
        {
            throw new NotImplementedException();
        }

        public ShipTo GetShipTo(int shipToId)
        {
            throw new NotImplementedException();
        }

        public ShipTo CreateShipTo(ShipTo thisShipTo)
        {
            throw new NotImplementedException();
        }

        public ShipTo DeleteShipTo(int shipToId)
        {
            throw new NotImplementedException();
        }

        public ShipTo EditShipTo(ShipTo thisShipTo)
        {
            throw new NotImplementedException();
        }
    }
}
