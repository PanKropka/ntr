//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EresData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subjects
    {
        public Subjects()
        {
            this.Realisations = new HashSet<Realisations>();
        }
    
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public string Conspect { get; set; }
        public string url { get; set; }
        public byte[] TimeStamp { get; set; }
    
        public virtual ICollection<Realisations> Realisations { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
