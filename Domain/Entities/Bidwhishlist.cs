﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Bidwhishlist
{
    public int Id { get; set; }

    public string Userid { get; set; }

    public string VehicleList { get; set; }

    public int? EventId { get; set; }

    public DateTime? Utcdate { get; set; }

    public DateTime? Ist { get; set; }
}