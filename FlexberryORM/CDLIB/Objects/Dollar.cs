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
    
    
    // *** Start programmer edit section *** (Using statements)
    using ICSSoft.STORMNET.Business;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Native dollar implementation. You can use dollars in your system as corresponding type, but not simply decimal.
    /// </summary>
    // *** Start programmer edit section *** (Dollar CustomAttributes)

    // There is StoreInstancesInType attribute which defines a resolution to storage type. SQLDataService and descendants will use decimals for values of type Dollar.
    // You can add this attribute by hand or you can set corresponding property of Dollar class on a diagram in Flexberry.
    // Attention! You need to add adequate implicit conversions to and from storage type.
    // *** End programmer edit section *** (Dollar CustomAttributes)
    [ICSSoft.STORMNET.StoreInstancesInType(typeof(SQLDataService), typeof(decimal))]
    public class Dollar
    {
        
        // *** Start programmer edit section *** (Dollar CustomMembers)
        public class ParameterOutOfRangeException:Exception
		{
			public ParameterOutOfRangeException(){}
		}

		private int fDollars;
		private int fCents;
        
        /// <summary>
        /// Just constructs a new dollar representation
        /// </summary>
        /// <param name="Dollars"></param>
        /// <param name="Cents"></param>
        public Dollar(int Dollars, int Cents)
		{
			fDollars = 0;
			fCents = 0;
            this.Dollars = Dollars;
            this.Cents = Cents;
		}

        /// <summary>
        /// An integer part of dollar
        /// </summary>
		public int Dollars 
		{
			get{return fDollars;}
			set 
			{
				if (value>=0) 
					fDollars = value; 
			}
		}
        /// <summary>
        /// A fractial part of dollar
        /// </summary>
		public int Cents
		{
			get {return fCents;}
			set
			{
				if (value>=0 && value<100)
					fCents = value;
				else
					throw new ParameterOutOfRangeException();
			}
		}


        /// <summary>
        /// Attention! You MUST realise such conversion for proper working of DataService
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator decimal(Dollar value)
		{
			return (decimal)value.Dollars+((decimal)value.Cents)/100;
		}

        /// <summary>
        /// Attention! You MUST realise such conversion for proper working of DataService
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static implicit operator Dollar(decimal value)
		{
            return new Dollar((int)value, (int)((value - (int)value) * 100));
		}

        /// <summary>
        /// Parse string representation 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Dollar Parse(string value)
		{
            string[] tmpval = value.Replace("$", "").Replace("¢", "").Split('.');
            tmpval[0] = tmpval[0] == "" ? "0" : tmpval[0];
            return new Dollar(int.Parse(tmpval[0]), int.Parse(tmpval[1]));
		}

        /// <summary>
        /// Return fullstring representation of dollars in good-looking human readable form
        /// </summary>
        /// <returns></returns>
		public override string ToString()
		{
			return fDollars==0 ? string.Format(".{0:00}¢", Cents) : string.Format("${0}.{1:00}", Dollars, Cents) ;
		}

        // *** End programmer edit section *** (Dollar CustomMembers)

    }
}
