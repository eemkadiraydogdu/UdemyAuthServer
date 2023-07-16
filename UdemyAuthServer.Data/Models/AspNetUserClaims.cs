﻿using System;
using System.Collections.Generic;

namespace UdemyAuthServer.Data.Models;

public partial class AspNetUserClaims
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual AspNetUsers User { get; set; } = null!;
}
