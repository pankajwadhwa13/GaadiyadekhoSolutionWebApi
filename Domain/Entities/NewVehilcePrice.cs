﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NewVehilcePrice
{
    public int Id { get; set; }

    public int? VehicleId { get; set; }

    public string Price { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? CityId { get; set; }

    public double? Exshowrommprice { get; set; }

    public double? Rtoprice { get; set; }

    public double? Insuranceprice { get; set; }

    public double? Insurancetime { get; set; }

    public double? Otherprice { get; set; }

    public double? Rtopricepercentage { get; set; }

    public virtual Country Country { get; set; }

    public virtual District District { get; set; }

    public virtual State State { get; set; }

    public virtual NewVehicle Vehicle { get; set; }
}