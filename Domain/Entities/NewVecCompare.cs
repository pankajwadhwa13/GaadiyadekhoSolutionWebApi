﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NewVecCompare
{
    public int Id { get; set; }

    public int? VehicleId { get; set; }

    public int? Branid { get; set; }

    public int? ModelId { get; set; }

    public int? VarietId { get; set; }

    public virtual Brand Bran { get; set; }

    public virtual VechileModel Model { get; set; }

    public virtual Variet Variet { get; set; }

    public virtual NewVehicle Vehicle { get; set; }
}