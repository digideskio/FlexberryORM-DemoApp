
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EF6Sample
{

using System;
    using System.Collections.Generic;
    
public partial class Master11
{

    public Master11()
    {

        this.Internal = new HashSet<Internal>();

    }


    public System.Guid primaryKey { get; set; }

    public string S0 { get; set; }

    public string S1 { get; set; }

    public string S2 { get; set; }

    public string S3 { get; set; }

    public string S4 { get; set; }

    public string S5 { get; set; }

    public string S6 { get; set; }

    public string S7 { get; set; }

    public string S8 { get; set; }

    public string S9 { get; set; }



    public virtual ICollection<Internal> Internal { get; set; }

}

}
