﻿
namespace CarBook.Domain.Entities.Common
{
	public class BaseEntity<T>
	{
		public T Id { get; set; } = default!;
	}
}
