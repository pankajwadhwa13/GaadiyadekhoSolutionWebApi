﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class GetVecimagesResult
    {
        public int ID { get; set; }
        public int? VechileID { get; set; }
        public string URl { get; set; }
        public bool? IsMain { get; set; }
        public string Discription { get; set; }
        public string Color { get; set; }
        public string imagetype { get; set; }
        public int? displayorder { get; set; }
    }
}
