﻿namespace CDADMTEST
{
    using System;

    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;

    using IIS.CDLIB;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    /// <summary>
    /// Flexberry ORM Samples Logic placed here.
    /// </summary>
    internal class OrmSample
    {
        /// <summary>
        /// Instance of <see cref="IDataService"/> for persistence operations.
        /// </summary>
        private readonly IDataService dataService;

        /// <summary>
        /// DataService being resolved by <see cref="DataServiceProvider.DataService"/>.
        /// </summary>
        public OrmSample()
        {
            dataService = DataServiceProvider.DataService;
        }

        /// <summary>
        /// Logic with custom DataService instance.
        /// </summary>
        /// <param name="ds">DataService for this instance.</param>
        public OrmSample(IDataService ds)
        {
            dataService = ds;
        }

        /// <summary>
        /// Return primary key some object by specified type.
        /// </summary>
        /// <param name="dataObjectType">Type of data object.</param>
        /// <returns>Primary key.</returns>
        internal object GetSomeObjectPrimaryKey(Type dataObjectType)
        {
            View dataObjectView = new View(dataObjectType, View.ReadType.OnlyThatObject);
            LoadingCustomizationStruct lcs = LoadingCustomizationStruct.GetSimpleStruct(dataObjectType, dataObjectView);
            lcs.ReturnTop = 1;
            DataObject[] dataObjects = dataService.LoadObjects(lcs);
            if (dataObjects.Length > 0)
            {
                return dataObjects[0].__PrimaryKey;
            }

            throw new Exception(string.Format("Could not find any objects specified type: {0} in database: {0}.", dataObjectType.FullName));
        }

        /// <summary>
        /// The gen details.
        /// </summary>
        /// <param name="dobj">
        /// The dobj.
        /// </param>
        /// <param name="QtyInEach">
        /// The qty in each.
        /// </param>
        internal void GenDetails(D dobj, int QtyInEach)
        {
            RandomStringGenerator rsg = new RandomStringGenerator();
            dobj.Name = rsg.Generate(200);
            dobj.S1 = rsg.Generate(200);
            dobj.S2 = rsg.Generate(200);
            dobj.S3 = rsg.Generate(200);
            dobj.S4 = rsg.Generate(200);
            dobj.S5 = rsg.Generate(200);

            string[] detprops = Information.GetPropertyNamesByType(dobj.GetType(), typeof(DetailArray));
            for (int i = 0; i < detprops.Length; i++)
            {
                DetailArray detarr = (DetailArray)Information.GetPropValueByName(dobj, detprops[i]);
                Type dettypetocreate = Information.GetCompatibleTypesForDetailProperty(dobj.GetType(), detprops[i])[0];
                for (int j = 0; j < QtyInEach; j++)
                {
                    D newobj = (D)Activator.CreateInstance(dettypetocreate);
                    GenDetails(newobj, QtyInEach);
                    detarr.AddObject(newobj);
                }
            }
        }


        /// <summary>
        /// The check details qty.
        /// </summary>
        /// <param name="dobj">
        /// The dobj.
        /// </param>
        /// <param name="QtyInEach">
        /// The qty in each.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        internal void CheckDetailsQty(D dobj, int QtyInEach)
        {
            string[] detprops = Information.GetPropertyNamesByType(dobj.GetType(), typeof(DetailArray));
            for (int i = 0; i < detprops.Length; i++)
            {
                DetailArray detarr = (DetailArray)Information.GetPropValueByName(dobj, detprops[i]);
                if (detarr.Count != QtyInEach) 
                    throw new Exception(string.Format("Missing reading of {0}!", detprops[i]));

                for (int j = 0; j < detarr.Count; j++)
                {
                    D obj = (D)detarr.ItemByIndex(j);
                    CheckDetailsQty(obj, QtyInEach);
                }
            }

        }

        /// <summary>
        /// Creates fake master objects for multimaster sample
        /// </summary>
        /// <param name="QtyInEach"></param>
        /// <returns></returns>
        internal ICSSoft.STORMNET.DataObject[] CreateMasterXXs(int QtyInEach)
        {
            List<ICSSoft.STORMNET.DataObject> objstoupdlist = new List<ICSSoft.STORMNET.DataObject>();

            for (int i = 1; i < 13; i++)
            {
                Type mastertype = Information.GetPropertyType(typeof(Internal), string.Format("Master{0:00}", i));
                objstoupdlist.AddRange(CreateMasterXXObject(mastertype, QtyInEach));
            }

            for (int i = 1; i < 4; i++)
            {
                Type mastertype = Type.GetType(string.Format("IIS.CDLIB.MasterDerived{0:00}, MultiMaster(Objects), Version=1.0.0.1, Culture=neutral, PublicKeyToken=d9aab9804d43c217", i));
                objstoupdlist.AddRange(CreateMasterXXObject(mastertype, QtyInEach));
            }

            ICSSoft.STORMNET.DataObject[] objstoupd = objstoupdlist.ToArray();

            return objstoupd;
        }

        /// <summary>
        /// Create desired quantity of master objects of selected type
        /// </summary>
        /// <param name="MasterType"></param>
        /// <param name="QtyInEach"></param>
        /// <returns></returns>
        internal MasterBase[] CreateMasterXXObject(Type MasterType, int QtyInEach)
        {
            MasterBase[] result = new MasterBase[QtyInEach];
            RandomStringGenerator rsg = new RandomStringGenerator();

            for (int i = 0; i < QtyInEach; i++)
            {
                MasterBase masterbase = (MasterBase)Activator.CreateInstance(MasterType);
                for (int j = 0; j < 10; j++)
                {
                    Information.SetPropValueByName(masterbase, string.Format("S{0}", j), rsg.Generate(200));
                }

                result[i] = masterbase;
            }
            return result;
        }

        /// <summary>
        /// Load fake masters into a masters cache
        /// </summary>
        /// <returns></returns>
        internal Dictionary<string, MasterBase[]> LoadMasters()
        {
            Dictionary<string, MasterBase[]> result = new Dictionary<string, MasterBase[]>();
            LoadingCustomizationStruct lcs = new LoadingCustomizationStruct(null);
            lcs.View = new View(new ViewAttribute("someview", new string[] {"S0" }), typeof(MasterBase));
            lcs.LoadingTypes = new Type[]{typeof(Master01), typeof(Master02), typeof(Master03), typeof(Master04), typeof(Master05), typeof(Master06), 
                                          typeof(Master07), typeof(Master08), typeof(Master09), typeof(Master10), typeof(Master11), typeof(Master12),
                                          typeof(MasterDerived01), typeof(MasterDerived02), typeof(MasterDerived03)};
            IEnumerable<ICSSoft.STORMNET.DataObject> dobjs = dataService.LoadObjects(lcs);

            var querygroupbytype = from MasterBase dobj in dobjs
                        group dobj by dobj.GetType().Name;

            foreach (var objgroup in querygroupbytype)
            {
                result.Add(objgroup.Key, objgroup.ToArray<MasterBase>());
            }
            return result;
            
        }

        Random random = new Random();

        internal MasterBase GetRandomMaster(Dictionary<string, MasterBase[]> mastercache, string mastertypename)
        {
            return mastercache[mastertypename][random.Next(0, 99)];
        }

    }

    /// <summary>
    /// Random string generator
    /// </summary>
    internal class RandomStringGenerator
    {
        List<char> _characters;
        Random random = new Random();
        public RandomStringGenerator()
        {
            _characters = new List<char>();
            // Fill character list with A-Z.
            for (int i = 65; i <= 90; i++)
            {
                _characters.Add((char)i);
            }
            // Fill character list with a-z.
            for (int i = 97; i <= 122; i++)
            {
                _characters.Add((char)i);
            }
            // Fill character list with 0-9.
            for (int i = 48; i <= 57; i++)
            {
                _characters.Add((char)i);
            }
        }

        /// <summary>
        /// Generate random string
        /// </summary>
        /// <param name="lenght">number of symbols</param>
        /// <returns>random string</returns>
        public string Generate(int lenght)
        {            
            StringBuilder buffer = new StringBuilder(lenght);
            for (int i = 0; i < lenght; i++)
            {
                int randomNumber = random.Next(0, _characters.Count);
                char randomChar = _characters[randomNumber];
                buffer.Append(randomChar);
            }
            return buffer.ToString();
        }
    }
}
