﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OldVehicleBid
{
    public int Id { get; set; }

    public int? Vehicleid { get; set; }

    public DateOnly? PostedUtcdate { get; set; }

    public DateOnly? PostedIstdate { get; set; }

    public DateOnly? StartUtcdate { get; set; }

    public DateOnly? EndIstdate { get; set; }

    public double? ExpectedPrice { get; set; }

    public bool? Status { get; set; }

    public DateOnly? StartIstdate { get; set; }

    public DateOnly? EndUtcdate { get; set; }

    public DateOnly? CloseIstdate { get; set; }

    public DateOnly? ClosedUtcdate { get; set; }
}