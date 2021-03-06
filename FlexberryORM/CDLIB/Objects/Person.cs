﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.CDLIB
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET.Business;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Person.
    /// </summary>
    // *** Start programmer edit section *** (Person CustomAttributes)

    // *** End programmer edit section *** (Person CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Person_E", new string[] {
            "FirstName",
            "LastName",
            "FullName"})]
    public class Person : ICSSoft.STORMNET.DataObject
    {
        
        private string fFirstName;
        
        private string fLastName;
        
        // *** Start programmer edit section *** (Person CustomMembers)

        // *** End programmer edit section *** (Person CustomMembers)

        
        /// <summary>
        /// FirstName.
        /// </summary>
        // *** Start programmer edit section *** (Person.FirstName CustomAttributes)

        // *** End programmer edit section *** (Person.FirstName CustomAttributes)
        [StrLen(255)]
        public virtual string FirstName
        {
            get
            {
                // *** Start programmer edit section *** (Person.FirstName Get start)

                // *** End programmer edit section *** (Person.FirstName Get start)
                string result = this.fFirstName;
                // *** Start programmer edit section *** (Person.FirstName Get end)

                // *** End programmer edit section *** (Person.FirstName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.FirstName Set start)

                // *** End programmer edit section *** (Person.FirstName Set start)
                this.fFirstName = value;
                // *** Start programmer edit section *** (Person.FirstName Set end)

                // *** End programmer edit section *** (Person.FirstName Set end)
            }
        }
        
        /// <summary>
        /// LastName.
        /// </summary>
        // *** Start programmer edit section *** (Person.LastName CustomAttributes)

        // *** End programmer edit section *** (Person.LastName CustomAttributes)
        [StrLen(255)]
        public virtual string LastName
        {
            get
            {
                // *** Start programmer edit section *** (Person.LastName Get start)

                // *** End programmer edit section *** (Person.LastName Get start)
                string result = this.fLastName;
                // *** Start programmer edit section *** (Person.LastName Get end)

                // *** End programmer edit section *** (Person.LastName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Person.LastName Set start)

                // *** End programmer edit section *** (Person.LastName Set start)
                this.fLastName = value;
                // *** Start programmer edit section *** (Person.LastName Set end)

                // *** End programmer edit section *** (Person.LastName Set end)
            }
        }
        
        /// <summary>
        /// FullName.
        /// </summary>
        // *** Start programmer edit section *** (Person.FullName CustomAttributes)

        // *** End programmer edit section *** (Person.FullName CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(SQLDataService), "isnull(@FirstName@,\'\') + \' \' + isnull(@LastName@,\'\')")]
        public virtual string FullName
        {
            get
            {
                // *** Start programmer edit section *** (Person.FullName Get)
                return string.Format("{0} {1}", fFirstName, fLastName);
                // *** End programmer edit section *** (Person.FullName Get)
            }
            set
            {
                // *** Start programmer edit section *** (Person.FullName Set)

                // *** End programmer edit section *** (Person.FullName Set)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Person_E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Person_E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Person_E", typeof(IIS.CDLIB.Person));
                }
            }
        }
    }
}
