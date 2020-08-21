using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    public class PurchasedOrderProdecer
    {
        private readonly BlockingCollection<PurchasedOrder> ordersQueue;
        private readonly object lockObject;

        public PurchasedOrderProdecer(object lockObject)
        {
            this.lockObject = lockObject;
            this.ordersQueue = new BlockingCollection<PurchasedOrder>();
        }

        public void Produce()
        {
            while (true)
            {
                var newOrder = this.GenerateOrder();
                Console.WriteLine($"Item name is {newOrder.ItemName}");
                lock (this.lockObject)
                {
                    this.ordersQueue.TryAdd(newOrder);
                    Console.WriteLine("added");
                
                 
                }
                Thread.Sleep(5000);
            }
        }

        private PurchasedOrder GenerateOrder()
        {
            Random rnd = new Random();
            var itemNum = rnd.Next(1, 1000);
            return new PurchasedOrder { ItemId = itemNum, ItemName = $"ItemName{itemNum}", DeliveryAddress = $"Address{itemNum}" };
        }

        public IEnumerable<PurchasedOrder> GetOrders()
        {
            return this.ordersQueue;
        }
    }
}
