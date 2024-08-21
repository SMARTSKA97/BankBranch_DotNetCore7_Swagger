﻿using System;
using System.Collections.Generic;

namespace BankAPI.DAL.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string BranchName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string State { get; set; } = null!;

    public int PinCode { get; set; }

    public string MicrCode { get; set; } = null!;

    public string IfscCode { get; set; } = null!;

    public int BankId { get; set; }

    public virtual Bank Bank { get; set; } = null!;
}
