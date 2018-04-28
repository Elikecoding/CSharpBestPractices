using FirstHelperLibrary.Model_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstHelperLibrary.Model_Classes.Order;

namespace FirstHelperLibrary.Service_Classes
{
    class OrderService
    {
        //This is a service I will use when my customers place orders this will call from the Order Class
        private IStorage _storage;

        //Assign my order service to my order object
        public void OrderSevice(IStorage storage) => _storage = storage;

        //Logic for when my order is placed 
        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);

            //Some Querying


            return orderId;

        }

    }
}
