
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
    
public partial class Publisher
{

    public Publisher()
    {

        this.BlueRay = new HashSet<BlueRay>();

        this.CD = new HashSet<CD>();

        this.CDDA = new HashSet<CDDA>();

        this.CDDD = new HashSet<CDDD>();

        this.DVD = new HashSet<DVD>();

    }


    public System.Guid primaryKey { get; set; }

    public string Name { get; set; }

    public System.Guid Country { get; set; }



    public virtual ICollection<BlueRay> BlueRay { get; set; }

    public virtual ICollection<CD> CD { get; set; }

    public virtual ICollection<CDDA> CDDA { get; set; }

    public virtual ICollection<CDDD> CDDD { get; set; }

    public virtual Country Country1 { get; set; }

    public virtual ICollection<DVD> DVD { get; set; }

}

}
