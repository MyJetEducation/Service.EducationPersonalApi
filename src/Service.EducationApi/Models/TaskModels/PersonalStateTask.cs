﻿using System;

namespace Service.EducationApi.Models.TaskModels
{
	public class PersonalStateTask
	{
		public int TaskId { get; set; }

		public TimeSpan Duration { get; set; }

		public int TestScore { get; set; }

		public bool CanRetry { get; set; }
	}
}