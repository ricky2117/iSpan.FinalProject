﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class PromotionProductType
    {
        public PromotionProductType()
        {
            ActivityDiscounts = new HashSet<ActivityDiscount>();
            Coupons = new HashSet<Coupon>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ActivityDiscount> ActivityDiscounts { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}