
using Homework7_Threads.Extend;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    internal class ConsoleHost
    {
        internal void Run()
        {
            var lockObject = new object();
            var orderProducer1 = new PurchasedOrderProdecer(lockObject);
            var orderProcessor1 = new PurchasedOrderProcessor(orderProducer1.GetOrders().As<BlockingCollection<PurchasedOrder>>(), lockObject);

            var orderProducer2 = new PurchasedOrderProdecer(lockObject);
            var orderProcessor2 = new PurchasedOrderProcessor(orderProducer2.GetOrders().As<BlockingCollection<PurchasedOrder>>(), lockObject);


            Thread orderproducerThread1 = new Thread(orderProducer1.Produce);
            orderproducerThread1.Start();

            Thread orderprocessorThread1 = new Thread(orderProcessor1.ProcessItem);
            orderprocessorThread1.Start();

            Thread orderproducerThread2 = new Thread(orderProducer2.Produce);
            orderproducerThread2.Start();

            Thread orderprocessorThread2 = new Thread(orderProcessor2.ProcessItem);
            orderprocessorThread2.Start();
        }
    }
}