﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class GetVechileTypesByIDResult
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? VechileKindID { get; set; }
        public string Image { get; set; }
    }
}