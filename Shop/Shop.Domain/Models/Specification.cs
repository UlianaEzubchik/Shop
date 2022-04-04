using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Models
{
    public class Specification
    {
        public int Id { get; set; }
        public string OperatingSystem { get; set; }

        public string ScreenDiagonal { get; set; }
        public string RAM { get; set; }

        public string PersistentMemory { get; set; }

        public string QtySIM { get; set; }

        public string MainCamera { get; set; }
        public string FrontCamera { get; set; }

        public int ProductId { get; set; }

        public Product Products { get; set; }
    }
}
