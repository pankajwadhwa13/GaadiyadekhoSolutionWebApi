﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VechileKind
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<VechileType> VechileTypes { get; set; } = new List<VechileType>();
}