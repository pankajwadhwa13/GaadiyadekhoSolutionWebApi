﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class getapprovedbidsResult
    {
        public int id { get; set; }
        public string BidUserid { get; set; }
        public int? EventID { get; set; }
        public int? EventVehicleID { get; set; }
        public int? BidPrice { get; set; }
        public DateTime upadtetime { get; set; }
        public bool bidstatus { get; set; }
        public string allvechimg { get; set; }
        public long? RowNum { get; set; }
        public long? TotalRows { get; set; }
    }
}
