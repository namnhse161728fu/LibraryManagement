﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public int? CategoryId { get; set; }

    public DateOnly? PublishedDate { get; set; }

    public int? Quantity { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();
}