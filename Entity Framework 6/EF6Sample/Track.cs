
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
    
public partial class Track
{

    public System.Guid primaryKey { get; set; }

    public string Name { get; set; }

    public Nullable<int> Length { get; set; }

    public System.Guid Author { get; set; }

    public Nullable<System.Guid> Singer { get; set; }

    public System.Guid CDDA { get; set; }



    public virtual CDDA CDDA1 { get; set; }

    public virtual Person Person { get; set; }

    public virtual Person Person1 { get; set; }

}

}
