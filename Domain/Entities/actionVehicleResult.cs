﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class actionVehicleResult
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public string RegisterNumer { get; set; }
        public string ChassieNumber { get; set; }
        public string Name { get; set; }
        public int? BrandID { get; set; }
        public string brandname { get; set; }
        public string categoryname { get; set; }
        public string modelname { get; set; }
        public int? ModelID { get; set; }
        public int? varietID { get; set; }
        public string varietName { get; set; }
        public int? ManfuctringYear { get; set; }
        public int? CategoryID { get; set; }
        public int? SubCategoryID { get; set; }
        public string StateName { get; set; }
        public string Districtname { get; set; }
        public string subDistrictsName { get; set; }
    }
}