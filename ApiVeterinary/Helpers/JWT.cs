using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Helpers;

public class JWT
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public double DurationMinutes { get; set; }
}
