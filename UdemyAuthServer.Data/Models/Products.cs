using System;
using System.Collections.Generic;

namespace UdemyAuthServer.Data.Models;

public partial class Products
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Stock { get; set; }

    public decimal Price { get; set; }

    public string UserId { get; set; } = null!;
}
