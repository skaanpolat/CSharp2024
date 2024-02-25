﻿using System;
namespace KodlamaIOCCC.Entities;

public class Course
{

	public int Id { get; set; }
	public int InstructorId { get; set; }
	public int CategoryId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public int Price { get; set; }

}

