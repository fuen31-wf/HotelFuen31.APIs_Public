﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class JobQueue
{
    public long Id { get; set; }

    public long JobId { get; set; }

    public string Queue { get; set; }

    public DateTime? FetchedAt { get; set; }
}