﻿using System.ComponentModel.DataAnnotations;

namespace Service.EducationApi.Models
{
	public class KeyValueList
	{
		[Required]
		public KeyValueItem[] Items { get; set; }
	}
}