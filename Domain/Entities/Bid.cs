﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Bid
{
    public int Id { get; set; }

    public string BidUserId { get; set; }

    public int? BidId { get; set; }

    public int? VehicleId { get; set; }

    public decimal? BidPrice { get; set; }

    public DateTime? Updatedtime { get; set; }

    public bool? BidStatus { get; set; }
}