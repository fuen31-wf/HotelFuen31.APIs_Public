﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class Order
{
    public int Id { get; set; }

    public string Phone { get; set; }

    public int Status { get; set; }

    public DateTime OrderTime { get; set; }

    public string MerchantTradeNo { get; set; }

    public int? RtnCode { get; set; }

    public string RtnMsg { get; set; }

    public string TradeNo { get; set; }

    public int? TradeAmt { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string PaymentType { get; set; }

    public string PaymentTypeChargeFee { get; set; }

    public string TradeDate { get; set; }

    public int? SimulatePaid { get; set; }

    public string CheckMacValue { get; set; }

    public virtual ICollection<RoomBooking> RoomBookings { get; set; } = new List<RoomBooking>();
}