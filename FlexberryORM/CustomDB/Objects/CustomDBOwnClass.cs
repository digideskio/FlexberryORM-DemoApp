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
    /// CustomDBOwnClass.
    /// </summary>
    // *** Start programmer edit section *** (CustomDBOwnClass CustomAttributes)

    // *** End programmer edit section *** (CustomDBOwnClass CustomAttributes)
    [ClassStorage("CustomDBOwn")]
    [PrimaryKeyStorage("pkey")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class CustomDBOwnClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fCustomOwnAttribute;
        
        private IIS.CDLIB.CustomDBMasterClass fCustomDBMasterClass;
        
        // *** Start programmer edit section *** (CustomDBOwnClass CustomMembers)

        // *** End programmer edit section *** (CustomDBOwnClass CustomMembers)

        
        /// <summary>
        /// CustomOwnAttribute.
        /// </summary>
        // *** Start programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute CustomAttributes)

        // *** End programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute CustomAttributes)
        [PropertyStorage("CustomOwn")]
        [StrLen(255)]
        public virtual string CustomOwnAttribute
        {
            get
            {
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Get start)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Get start)
                string result = this.fCustomOwnAttribute;
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Get end)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Set start)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Set start)
                this.fCustomOwnAttribute = value;
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Set end)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomOwnAttribute Set end)
            }
        }
        
        /// <summary>
        /// CustomDBOwnClass.
        /// </summary>
        // *** Start programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass CustomAttributes)

        // *** End programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass CustomAttributes)
        [PropertyStorage(new string[] {
                "CustomDBMaster"})]
        [NotNull()]
        public virtual IIS.CDLIB.CustomDBMasterClass CustomDBMasterClass
        {
            get
            {
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Get start)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Get start)
                IIS.CDLIB.CustomDBMasterClass result = this.fCustomDBMasterClass;
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Get end)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Set start)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Set start)
                this.fCustomDBMasterClass = value;
                // *** Start programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Set end)

                // *** End programmer edit section *** (CustomDBOwnClass.CustomDBMasterClass Set end)
            }
        }
    }
}
