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

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// D313.
    /// </summary>
    // *** Start programmer edit section *** (D313 CustomAttributes)

    // *** End programmer edit section *** (D313 CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored(false)]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class D313 : IIS.CDLIB.D
    {
        
        private IIS.CDLIB.D31 fD31;
        
        // *** Start programmer edit section *** (D313 CustomMembers)

        // *** End programmer edit section *** (D313 CustomMembers)

        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.CDLIB.D31.
        /// </summary>
        // *** Start programmer edit section *** (D313.D31 CustomAttributes)

        // *** End programmer edit section *** (D313.D31 CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "D31"})]
        public virtual IIS.CDLIB.D31 D31
        {
            get
            {
                // *** Start programmer edit section *** (D313.D31 Get start)

                // *** End programmer edit section *** (D313.D31 Get start)
                IIS.CDLIB.D31 result = this.fD31;
                // *** Start programmer edit section *** (D313.D31 Get end)

                // *** End programmer edit section *** (D313.D31 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D313.D31 Set start)

                // *** End programmer edit section *** (D313.D31 Set start)
                this.fD31 = value;
                // *** Start programmer edit section *** (D313.D31 Set end)

                // *** End programmer edit section *** (D313.D31 Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of D313.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfD313 CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfD313 CustomAttributes)
    public class DetailArrayOfD313 : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.CDLIB.DetailArrayOfD313 members)

        // *** End programmer edit section *** (IIS.CDLIB.DetailArrayOfD313 members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type D313 by index.
        /// </summary>
        /// <summary>
        /// Adds object with type D313.
        /// </summary>
        public DetailArrayOfD313(IIS.CDLIB.D31 fD31) : 
                base(typeof(D313), ((ICSSoft.STORMNET.DataObject)(fD31)))
        {
        }
        
        public IIS.CDLIB.D313 this[int index]
        {
            get
            {
                return ((IIS.CDLIB.D313)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.CDLIB.D313 dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
