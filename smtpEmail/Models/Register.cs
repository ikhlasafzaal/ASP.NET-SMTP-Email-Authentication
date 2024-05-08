using System;
using System.Collections.Generic;

namespace smtpEmail.Models
{
    public partial class Register
    {
        public int Rid { get; set; }
        public string? Rname { get; set; }
        public string? Runame { get; set; }
        public string? Remail { get; set; }
        public string? Rpass { get; set; }
    }
}
