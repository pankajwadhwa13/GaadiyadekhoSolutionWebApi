﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BodyType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<FreeOldVehicle> FreeOldVehicles { get; set; } = new List<FreeOldVehicle>();

    public virtual ICollection<NewVehicle> NewVehicles { get; set; } = new List<NewVehicle>();

    public virtual ICollection<Newvehicle1> Newvehicle1s { get; set; } = new List<Newvehicle1>();
}