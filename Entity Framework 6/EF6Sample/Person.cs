
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
    
public partial class Person
{

    public Person()
    {

        this.Track = new HashSet<Track>();

        this.Track1 = new HashSet<Track>();

    }


    public System.Guid primaryKey { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }



    public virtual ICollection<Track> Track { get; set; }

    public virtual ICollection<Track> Track1 { get; set; }

}

}
