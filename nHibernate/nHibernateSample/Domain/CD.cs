using System;
using System.Text;
using System.Collections.Generic;

namespace nHibernateSample.Domain
{
    public class CD
    {
        public virtual System.Guid Primarykey { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual string Name { get; set; }
    }
}