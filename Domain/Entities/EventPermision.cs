﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventPermision
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public string Userid { get; set; }

    public string Permession { get; set; }

    public DateTime Updatedon { get; set; }

    public DateTime Createdon { get; set; }

    public virtual AuctionEvent Event { get; set; }
}