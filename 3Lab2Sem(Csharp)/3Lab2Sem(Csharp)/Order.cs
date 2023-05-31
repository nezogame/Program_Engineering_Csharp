using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lab2Sem_Csharp_
{
    class Order
    {
        public string Topic { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public int ExecutionTime { get; set; }
        public Order(string Topic, DateTime TimeOfOrder, int ExecutionTime)
        {
            this.Topic = Topic;
            this.TimeOfOrder = TimeOfOrder;
            this.ExecutionTime = ExecutionTime;
        }
        public Order()
        {
            this.Topic = "Some Topic";
            this.TimeOfOrder = new DateTime(1800, 26, 5, 8, 00, 00);
            this.ExecutionTime = 240;
        }
        public Order(Order order)
        {
            Topic = order.Topic;
            TimeOfOrder = order.TimeOfOrder;
            ExecutionTime = order.ExecutionTime;
        }
        public override string ToString()
        {
            return $"Topic of order: {Topic}, Time of order: {TimeOfOrder}, Execution time in hours:{ExecutionTime} ";
        }
    }
}
