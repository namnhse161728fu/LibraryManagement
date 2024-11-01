﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public string StudentId { get; set; }

    public int? LibrarianId { get; set; }

    public DateTime LoanDate { get; set; }

    public virtual Librarian Librarian { get; set; }

    public virtual ICollection<LoanDetail> LoanDetail { get; set; } = new List<LoanDetail>();

    public virtual Student Student { get; set; }
}