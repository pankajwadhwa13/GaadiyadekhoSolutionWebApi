﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class searchCitiesResult
    {
        public int SubDistrictsId { get; set; }
        public string SubDistrictsName { get; set; }
        public int DistrictId { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
