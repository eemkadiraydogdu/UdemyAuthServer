using System;
using System.Collections.Generic;

namespace UdemyAuthServer.Data.Models;

public partial class UserRefreshTokens
{
    public string UserId { get; set; } = null!;

    public string? Code { get; set; }

    public DateTime Expiration { get; set; }
}
