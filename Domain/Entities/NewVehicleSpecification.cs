﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NewVehicleSpecification
{
    public int Id { get; set; }

    public int? VechileId { get; set; }

    public string Engine { get; set; }

    public string Suspension { get; set; }

    public string Wheels { get; set; }

    public string Brakes { get; set; }

    public string Transmission { get; set; }

    public string Electrical { get; set; }

    public virtual ICollection<NewVehicle> NewVehicles { get; set; } = new List<NewVehicle>();
}