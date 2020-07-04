using System;
using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class ShippingDelivery : EntityBase
    {
        public DateTime EstimateDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public double DeliveryValue { get; set; }

        public int QuantityDelivered { get; set; }

        public string IdProvider { get; set; }

        public virtual Provider Provider { get; set; }
    }
}