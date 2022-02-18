using System;

namespace TestForLsiSoftware.Models
{
    public class Raport
    {
        public long RaportId { get; set; }

        public string Name { get; set; }

        public DateTime DateTimeOfCreate { get; set; }

        public string Creator { get; set; }

        public string Local { get; set; }

    }
}
