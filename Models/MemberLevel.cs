﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class MemberLevel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int LowerSpending { get; set; }

    public int LowerOrders { get; set; }

    public string Comment { get; set; }

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}