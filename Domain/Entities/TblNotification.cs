﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TblNotification
{
    public int Id { get; set; }

    public string EventCode { get; set; }

    public string EventDetail { get; set; }

    public DateTime? DateTime { get; set; }

    public string CreatedById { get; set; }

    public string ReadStatus { get; set; }

    public string NotificationStatus { get; set; }

    public string ReadStatusSuperAdmin { get; set; }
}