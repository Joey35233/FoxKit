//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.FoxCore
{
    using System;
    using System.Collections.Generic;
    using FoxKit.Modules.DataSet.Fox.FoxCore;
    using FoxKit.Modules.Lua;
    using FoxLib;
    using static KopiLua.Lua;
    using OdinSerializer;
    using UnityEngine;
    using DataSetFile2 = DataSetFile2;
    using TppGameKit = FoxKit.Modules.DataSet.Fox.TppGameKit;
    using FoxCore;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class BucketCollector : Entity
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 48, 1, Core.ContainerType.StringMap, PropertyExport.Never, PropertyExport.Never, typeof(FoxCore.Bucket), null)]
        private Dictionary<string, FoxCore.Bucket> buckets = new Dictionary<string, FoxCore.Bucket>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 96, 1, Core.ContainerType.StaticArray, PropertyExport.Never, PropertyExport.Never, typeof(FoxCore.Bucket), null)]
        private FoxCore.Bucket mainBucket;
        
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "";
    }
}
