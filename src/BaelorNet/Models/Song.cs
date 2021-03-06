﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BaelorNet.Models
{
	public class Song
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("length")]
		public TimeSpan Length { get; set; }

		[JsonProperty("writers")]
		public string[] Writers { get; set; }

		[JsonProperty("producers")]
		public string[] Producers { get; set; }

		[JsonProperty("album")]
		public Album Album { get; set; }

		[JsonProperty("lyrics")]
		public IEnumerable<Lyric> Lyrics { get; set; }
	}

}
