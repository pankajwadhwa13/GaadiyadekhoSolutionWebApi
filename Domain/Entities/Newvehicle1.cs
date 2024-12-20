﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Newvehicle1
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int CategoryId { get; set; }

    public int SubCategoryId { get; set; }

    public int BrandId { get; set; }

    public int MoidelId { get; set; }

    public string Discription { get; set; }

    public int? Imgid { get; set; }

    public int? FeatureId { get; set; }

    public int? Specificationsid { get; set; }

    public int? Priceid { get; set; }

    public int? DealerlocationId { get; set; }

    public int? SafityandconfortId { get; set; }

    public int? VarietId { get; set; }

    public bool? Homepageimage { get; set; }

    public int? BodyTypeId { get; set; }

    public int? BodyLenthId { get; set; }

    public int? CityId { get; set; }

    public string Ipaddress { get; set; }

    public int? StateId { get; set; }

    public int? DistricId { get; set; }

    public string Latitude { get; set; }

    public string Longitude { get; set; }

    public bool? Isupcoming { get; set; }

    public bool? Ispopuler { get; set; }

    public DateTime? Launchdate { get; set; }

    public bool? Islatest { get; set; }

    public bool? Isdiscontinue { get; set; }

    public virtual LengthType BodyLenth { get; set; }

    public virtual BodyType BodyType { get; set; }

    public virtual SubDistrict City { get; set; }

    public virtual DealerLocation Dealerlocation { get; set; }

    public virtual District Distric { get; set; }

    public virtual VechileModel Moidel { get; set; }

    public virtual State State { get; set; }

    public virtual Variet Variet { get; set; }
}