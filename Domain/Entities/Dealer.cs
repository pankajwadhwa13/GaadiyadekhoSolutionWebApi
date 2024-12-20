﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Dealer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public int? DealersPointId { get; set; }

    public virtual DealerPoint DealersPoint { get; set; }

    public virtual ICollection<DelersVehcile> DelersVehciles { get; set; } = new List<DelersVehcile>();
}