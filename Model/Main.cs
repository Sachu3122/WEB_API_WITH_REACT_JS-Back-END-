using System;
using System.Collections.Generic;

namespace FinalDraft.Model
{
    public partial class Main
    {
        public int Id { get; set; }
        public DateTime InspectionDate { get; set; }
        public DateTime FirstId { get; set; }
        public DateTime AdditionalId { get; set; }
        public string? DoorCard { get; set; }
        public string? Describe { get; set; }
        public long? PhoneNum { get; set; }
        public string? PrimaryPhoneIs { get; set; }
        public string? LocationCon { get; set; }
        public string? Equipment { get; set; }
        public string? InspectionComments { get; set; }
        public string? Country { get; set; }
        public string States { get; set; } = null!;
        public string City { get; set; } = null!;
        public int Postal { get; set; }
        public string? CrctAdd { get; set; }
        public string? AddrsExplaination { get; set; }
        public string? GeoCode { get; set; }
        public string? PropertyPhoto { get; set; }
        public int? Mapcode { get; set; }
    }
}
