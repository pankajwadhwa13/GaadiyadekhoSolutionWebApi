﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class GetStatesByIDResult
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public string RTACode { get; set; }
        public string OLDRTACode { get; set; }
        [Column("latitude", TypeName = "decimal(18,0)")]
        public decimal? latitude { get; set; }
        [Column("longirtude", TypeName = "decimal(18,0)")]
        public decimal? longirtude { get; set; }
        public string pic { get; set; }
    }
}
