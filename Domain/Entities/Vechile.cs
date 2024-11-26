﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Vechile
{
    public int Id { get; set; }

    public int KindId { get; set; }

    public int TypeId { get; set; }

    public int SubTypeId { get; set; }

    public int BrandId { get; set; }

    public int ModelId { get; set; }

    public string Name { get; set; }

    public string Year { get; set; }

    public string Disciption { get; set; }

    public double? Price { get; set; }

    public string VinNo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? BuyedDate { get; set; }

    public double? BuyedPrice { get; set; }

    public virtual VechileModel Model { get; set; }

    public virtual VechileSubType SubType { get; set; }

    public virtual VechileType Type { get; set; }
}