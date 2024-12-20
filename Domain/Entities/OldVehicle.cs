﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OldVehicle
{
    public int Id { get; set; }

    public string RegisterNumer { get; set; }

    public string ChassieNumber { get; set; }

    public string Name { get; set; }

    public int? BrandId { get; set; }

    public string VehicleType { get; set; }

    public int? ModelId { get; set; }

    public int? ManfuctringYear { get; set; }

    public string Color { get; set; }

    public string City { get; set; }

    public string Odomiter { get; set; }

    public double? Price { get; set; }

    public string Fule { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? CategoryId { get; set; }

    public int? SubCategoryId { get; set; }

    public int? VarietId { get; set; }

    public DateTime? InsurenceExphiryDate { get; set; }

    public bool? Rc { get; set; }

    public bool? InviceBill { get; set; }

    public DateTime? TaxValidityDate { get; set; }

    public DateTime? FitnessExphiryDate { get; set; }

    public DateTime? PermitExphiryDate { get; set; }

    public bool? IsurgentSale { get; set; }

    public bool? IsBankIt { get; set; }

    public bool? IsHotDeal { get; set; }

    public bool? Isscarp { get; set; }

    public bool? IsoferedinBid { get; set; }

    public bool? Isbanner1 { get; set; }

    public bool? Isbanner2 { get; set; }

    public bool? Homepages { get; set; }

    public string BodyType { get; set; }

    public string Lenth { get; set; }

    public string SittingCapsity { get; set; }

    public string PostedByUserId { get; set; }

    public int? CityId { get; set; }

    public string Ipaddress { get; set; }

    public int? BodyTypeId { get; set; }

    public int? BodyLenthId { get; set; }

    public int? Onwer { get; set; }

    public bool? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public int? StateId { get; set; }

    public int? DistricId { get; set; }

    public int? UserRoleid { get; set; }

    public string Latitude { get; set; }

    public string Longitude { get; set; }

    public bool? Ispopuler { get; set; }

    public bool? IsoferedinBidconfirmed { get; set; }

    public virtual VechileType Category { get; set; }

    public virtual SubDistrict CityNavigation { get; set; }

    public virtual District Distric { get; set; }

    public virtual VechileModel Model { get; set; }

    public virtual ICollection<OldVechileImage> OldVechileImages { get; set; } = new List<OldVechileImage>();

    public virtual State State { get; set; }

    public virtual VechileSubType SubCategory { get; set; }
}