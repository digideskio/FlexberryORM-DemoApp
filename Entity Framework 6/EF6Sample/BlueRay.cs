
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
    
public partial class BlueRay
{

    public System.Guid primaryKey { get; set; }

    public Nullable<int> Capacity { get; set; }

    public string Name { get; set; }

    public System.Guid Publisher { get; set; }



    public virtual Publisher Publisher1 { get; set; }

}

}
