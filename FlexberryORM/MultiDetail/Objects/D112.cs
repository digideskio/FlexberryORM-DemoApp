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
    /// D112.
    /// </summary>
    // *** Start programmer edit section *** (D112 CustomAttributes)

    // *** End programmer edit section *** (D112 CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored(false)]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class D112 : IIS.CDLIB.D
    {
        
        private IIS.CDLIB.D11 fD11;
        
        // *** Start programmer edit section *** (D112 CustomMembers)

        // *** End programmer edit section *** (D112 CustomMembers)

        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.CDLIB.D11.
        /// </summary>
        // *** Start programmer edit section *** (D112.D11 CustomAttributes)

        // *** End programmer edit section *** (D112.D11 CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "D11"})]
        public virtual IIS.CDLIB.D11 D11
        {
            get
            {
                // *** Start programmer edit section *** (D112.D11 Get start)

                // *** End programmer edit section *** (D112.D11 Get start)
                IIS.CDLIB.D11 result = this.fD11;
                // *** Start programmer edit section *** (D112.D11 Get end)

                // *** End programmer edit section *** (D112.D11 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D112.D11 Set start)

                // *** End programmer edit section *** (D112.D11 Set start)
                this.fD11 = value;
                // *** Start programmer edit section *** (D112.D11 Set end)

                // *** End programmer edit section *** (D112.D11 Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of D112.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfD112 CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfD112 CustomAttributes)
    public class DetailArrayOfD112 : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.CDLIB.DetailArrayOfD112 members)

        // *** End programmer edit section *** (IIS.CDLIB.DetailArrayOfD112 members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type D112 by index.
        /// </summary>
        /// <summary>
        /// Adds object with type D112.
        /// </summary>
        public DetailArrayOfD112(IIS.CDLIB.D11 fD11) : 
                base(typeof(D112), ((ICSSoft.STORMNET.DataObject)(fD11)))
        {
        }
        
        public IIS.CDLIB.D112 this[int index]
        {
            get
            {
                return ((IIS.CDLIB.D112)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.CDLIB.D112 dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
