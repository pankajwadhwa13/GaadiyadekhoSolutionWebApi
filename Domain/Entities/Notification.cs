﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Notification
{
    public int Id { get; set; }

    public bool? Isreard { get; set; }

    public string Notificationcode { get; set; }

    public string UserroleId { get; set; }

    public string Userid { get; set; }

    public virtual AspNetUser1 User { get; set; }

    public virtual AspNetRole1 Userrole { get; set; }
}