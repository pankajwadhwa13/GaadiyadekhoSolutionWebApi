﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DelersVehcile
{
    public int Id { get; set; }

    public int? CateGoryId { get; set; }

    public int? SubCategoryId { get; set; }

    public int? BrandId { get; set; }

    public string Brands { get; set; }

    public string Models { get; set; }

    public int? DealerId { get; set; }

    public virtual Brand Brand { get; set; }

    public virtual VechileType CateGory { get; set; }

    public virtual Dealer Dealer { get; set; }
}