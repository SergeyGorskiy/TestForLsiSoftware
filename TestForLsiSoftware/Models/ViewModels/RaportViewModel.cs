using System;
using System.Collections.Generic;

namespace TestForLsiSoftware.Models.ViewModels
{
    public class RaportViewModel
    {
        public IEnumerable<Raport> Raports { get; set; }

        public IEnumerable<string> Locals { get; set; }

        public DateTime DateTimeOfCreate { get; set; } = DateTime.Now;
    }
}