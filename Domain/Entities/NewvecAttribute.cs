﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NewvecAttribute
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public string AttributeName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Status { get; set; }

    public int? Disyplayorder { get; set; }

    public bool? HasAttribute { get; set; }

    public virtual VechileType Cat { get; set; }

    public virtual ICollection<NewVecAttrContent> NewVecAttrContents { get; set; } = new List<NewVecAttrContent>();

    public virtual ICollection<NewvecSubAttribute> NewvecSubAttributes { get; set; } = new List<NewvecSubAttribute>();

    public virtual ICollection<NewvecSubAttributesCategory> NewvecSubAttributesCategories { get; set; } = new List<NewvecSubAttributesCategory>();
}