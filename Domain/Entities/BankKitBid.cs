﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BankKitBid
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public int? VehicleId { get; set; }

    public double? BidPrice { get; set; }

    public DateTime? BidTime { get; set; }
}