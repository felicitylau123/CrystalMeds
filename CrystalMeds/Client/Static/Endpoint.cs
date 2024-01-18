﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalMeds.Client.Static
{
	public static class Endpoints
	{
		private static readonly string Prefix = "api";
		public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
		public static readonly string OrdersEndpoint = $"{Prefix}/models";
		public static readonly string PaymentsEndpoint = $"{Prefix}/colours";
		public static readonly string PrescriptionsEndpoint = $"{Prefix}/vehicles";
		public static readonly string CustomersEndpoint = $"{Prefix}/customers";
		public static readonly string PromotionsEndpoint = $"{Prefix}/bookings";
		public static readonly string ProductsEndpoint = $"{Prefix}/products";
	}
}

