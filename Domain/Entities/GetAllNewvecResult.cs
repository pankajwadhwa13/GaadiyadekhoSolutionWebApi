﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class GetAllNewvecResult
    {
        public int id { get; set; }
        public string name { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int BrandID { get; set; }
        public int MoidelID { get; set; }
        public string Discription { get; set; }
        public int? Imgid { get; set; }
        public int? FeatureID { get; set; }
        public int? SPECIFICATIONSID { get; set; }
        public int? PRICEID { get; set; }
        public int? DEALERLOcationID { get; set; }
        public int? safityandconfortID { get; set; }
        public int? VArietID { get; set; }
        public bool? Homepageimage { get; set; }
        public int? BodyTypeID { get; set; }
        public int? BodyLenthID { get; set; }
        public int? CityID { get; set; }
        public string ipaddress { get; set; }
        public int? StateID { get; set; }
        public int? DistricID { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public bool? isupcoming { get; set; }
        public bool? ispopuler { get; set; }
        public DateTime? launchdate { get; set; }
        public bool? islatest { get; set; }
        public bool? isdiscontinue { get; set; }
        public string modelname { get; set; }
        public string BrandName { get; set; }
        public string URl { get; set; }
        public string catname { get; set; }
        public long? RowNum { get; set; }
        public int? TotalRows { get; set; }
    }
}
