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
    using ICSSoft.STORMNET.KeyGen;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// D.
    /// </summary>
    // *** Start programmer edit section *** (D CustomAttributes)

    // *** End programmer edit section *** (D CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("D_E", new string[] {
            "Name"})]
    [View("FULLD_E", new string[] {
            "*"})]
    public class D : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private string fS1;
        
        private string fS2;
        
        private string fS3;
        
        private string fS4;
        
        private string fS5;
        
        // *** Start programmer edit section *** (D CustomMembers)
        /// <summary>
        /// Прототипизация
        /// </summary>
        /// <param name="withDetails"></param>
        public virtual void Prototyping2(bool withDetails)
        {

            //__PrototypeKey = __PrimaryKey;
            KeyGenerator.Generate(this, null);
            this.SetStatus(ObjectStatus.Created);
            this.SetLoadingState(LoadingState.NotLoaded);
            this.SetLoadedProperties(new string[0]);
            InitDataCopy();
            if (withDetails)
            {
                string[] properties = Information.GetAllPropertyNames(GetType());
                foreach (string property in properties)
                {
                    Type proptype = Information.GetPropertyType(GetType(), property);
                    if (proptype.IsSubclassOf(typeof(DetailArray)))
                    {
                        foreach (D detobj in (DetailArray)Information.GetPropValueByName(this, property))
                            detobj.Prototyping2(withDetails);
                    }
                }
            }
        }

        // *** End programmer edit section *** (D CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (D.Name CustomAttributes)

        // *** End programmer edit section *** (D.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (D.Name Get start)

                // *** End programmer edit section *** (D.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (D.Name Get end)

                // *** End programmer edit section *** (D.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.Name Set start)

                // *** End programmer edit section *** (D.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (D.Name Set end)

                // *** End programmer edit section *** (D.Name Set end)
            }
        }
        
        /// <summary>
        /// S1.
        /// </summary>
        // *** Start programmer edit section *** (D.S1 CustomAttributes)

        // *** End programmer edit section *** (D.S1 CustomAttributes)
        [StrLen(255)]
        public virtual string S1
        {
            get
            {
                // *** Start programmer edit section *** (D.S1 Get start)

                // *** End programmer edit section *** (D.S1 Get start)
                string result = this.fS1;
                // *** Start programmer edit section *** (D.S1 Get end)

                // *** End programmer edit section *** (D.S1 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.S1 Set start)

                // *** End programmer edit section *** (D.S1 Set start)
                this.fS1 = value;
                // *** Start programmer edit section *** (D.S1 Set end)

                // *** End programmer edit section *** (D.S1 Set end)
            }
        }
        
        /// <summary>
        /// S2.
        /// </summary>
        // *** Start programmer edit section *** (D.S2 CustomAttributes)

        // *** End programmer edit section *** (D.S2 CustomAttributes)
        [StrLen(255)]
        public virtual string S2
        {
            get
            {
                // *** Start programmer edit section *** (D.S2 Get start)

                // *** End programmer edit section *** (D.S2 Get start)
                string result = this.fS2;
                // *** Start programmer edit section *** (D.S2 Get end)

                // *** End programmer edit section *** (D.S2 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.S2 Set start)

                // *** End programmer edit section *** (D.S2 Set start)
                this.fS2 = value;
                // *** Start programmer edit section *** (D.S2 Set end)

                // *** End programmer edit section *** (D.S2 Set end)
            }
        }
        
        /// <summary>
        /// S3.
        /// </summary>
        // *** Start programmer edit section *** (D.S3 CustomAttributes)

        // *** End programmer edit section *** (D.S3 CustomAttributes)
        [StrLen(255)]
        public virtual string S3
        {
            get
            {
                // *** Start programmer edit section *** (D.S3 Get start)

                // *** End programmer edit section *** (D.S3 Get start)
                string result = this.fS3;
                // *** Start programmer edit section *** (D.S3 Get end)

                // *** End programmer edit section *** (D.S3 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.S3 Set start)

                // *** End programmer edit section *** (D.S3 Set start)
                this.fS3 = value;
                // *** Start programmer edit section *** (D.S3 Set end)

                // *** End programmer edit section *** (D.S3 Set end)
            }
        }
        
        /// <summary>
        /// S4.
        /// </summary>
        // *** Start programmer edit section *** (D.S4 CustomAttributes)

        // *** End programmer edit section *** (D.S4 CustomAttributes)
        [StrLen(255)]
        public virtual string S4
        {
            get
            {
                // *** Start programmer edit section *** (D.S4 Get start)

                // *** End programmer edit section *** (D.S4 Get start)
                string result = this.fS4;
                // *** Start programmer edit section *** (D.S4 Get end)

                // *** End programmer edit section *** (D.S4 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.S4 Set start)

                // *** End programmer edit section *** (D.S4 Set start)
                this.fS4 = value;
                // *** Start programmer edit section *** (D.S4 Set end)

                // *** End programmer edit section *** (D.S4 Set end)
            }
        }
        
        /// <summary>
        /// S5.
        /// </summary>
        // *** Start programmer edit section *** (D.S5 CustomAttributes)

        // *** End programmer edit section *** (D.S5 CustomAttributes)
        [StrLen(255)]
        public virtual string S5
        {
            get
            {
                // *** Start programmer edit section *** (D.S5 Get start)

                // *** End programmer edit section *** (D.S5 Get start)
                string result = this.fS5;
                // *** Start programmer edit section *** (D.S5 Get end)

                // *** End programmer edit section *** (D.S5 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (D.S5 Set start)

                // *** End programmer edit section *** (D.S5 Set start)
                this.fS5 = value;
                // *** Start programmer edit section *** (D.S5 Set end)

                // *** End programmer edit section *** (D.S5 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "D_E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View D_E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("D_E", typeof(IIS.CDLIB.D));
                }
            }
            
            /// <summary>
            /// "FULLD_E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FULLD_E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FULLD_E", typeof(IIS.CDLIB.D));
                }
            }
        }
    }
}
