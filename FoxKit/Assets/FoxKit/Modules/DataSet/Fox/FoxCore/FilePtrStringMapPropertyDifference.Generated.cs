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
    public partial class FilePtrStringMapPropertyDifference : PropertyDifference
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.FilePtr, 72, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, UnityEngine.Object> originalValues = new Dictionary<string, UnityEngine.Object>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.FilePtr, 120, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, UnityEngine.Object> values = new Dictionary<string, UnityEngine.Object>();
        
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "";
    }
}
