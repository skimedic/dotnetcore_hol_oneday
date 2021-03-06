﻿#region copyright

// Copyright Information
// ==================================
// SpyStore.Hol - SpyStore.Hol.Mvc - CartRecordViewModel.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2019/10/04
// See License.txt for more information
// ==================================

#endregion

using System.ComponentModel.DataAnnotations;
using SpyStore.Hol.Models.ViewModels;
using SpyStore.Hol.Mvc.Validation;

namespace SpyStore.Hol.Mvc.Models.ViewModels
{
    public class CartRecordViewModel : CartRecordWithProductInfo
    {
        [Required,MustNotBeGreaterThan(nameof(UnitsInStock))]
        public new int Quantity { get; set; }
    }
}