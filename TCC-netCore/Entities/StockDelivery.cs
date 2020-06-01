using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class StockDelivery : EntityBase
    {
        public StockDelivery(DateTime estimateDate, DateTime deliveryDate, double deliveryValue, int quantityDelivered, Provider provider)
        {
            EstimateDate = estimateDate;
            DeliveryDate = deliveryDate;
            DeliveryValue = deliveryValue;
            QuantityDelivered = quantityDelivered;
            Provider = provider;
        }

        public DateTime EstimateDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public double DeliveryValue { get; set; }

        public int QuantityDelivered { get; set; }

        public Provider Provider { get; set; }
    }
}
