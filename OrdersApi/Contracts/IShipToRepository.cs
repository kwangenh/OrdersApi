using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Models;

namespace OrdersApi.Contracts
{
    public interface IShipToRepository
    {
        public List<ShipTo> GetShipTos();
        public ShipTo GetShipTo(int shipToId);
        public ShipTo CreateShipTo(ShipTo thisShipTo);
        public ShipTo DeleteShipTo(int shipToId);
        public ShipTo EditShipTo(ShipTo thisShipTo);
    }
}
