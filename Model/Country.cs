using System;
using System.Collections.Generic;

namespace FinalDraft.Model
{
    public partial class Country
    {
        public int Pincode { get; set; }
        public string? District { get; set; }
        public string StateName { get; set; } = null!;
    }
}
