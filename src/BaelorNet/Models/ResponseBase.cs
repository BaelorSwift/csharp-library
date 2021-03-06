﻿using Newtonsoft.Json;

namespace BaelorNet.Models
{
	public class ResponseBase<T>
		where T : class
	{
		[JsonProperty("result")]
		public T Result { get; set; }

		[JsonProperty("error")]
		public ErrorBase Error { get; set; } = null;

		[JsonProperty("success")]
		public bool Success { get; set; } = true;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}

}
