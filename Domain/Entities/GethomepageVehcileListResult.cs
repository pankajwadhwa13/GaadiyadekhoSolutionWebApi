﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class GethomepageVehcileListResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? BrandID { get; set; }
        public int? ModelID { get; set; }
        public double? Price { get; set; }
        public int? CategoryID { get; set; }
        public int? StateID { get; set; }
        public int? DistricID { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string URl { get; set; }
        public string catname { get; set; }
        public long? RowNum { get; set; }
    }
}
