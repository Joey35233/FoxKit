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
    using KopiLua;
    using OdinSerializer;
    using UnityEngine;
    using DataSetFile2 = DataSetFile2;
    using TppGameKit = FoxKit.Modules.DataSet.Fox.TppGameKit;
    using FoxCore;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class EntityLinkStringMapPropertyDifference : PropertyDifference
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 72, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, FoxKit.Modules.DataSet.FoxCore.EntityLink> originalValues = new Dictionary<string, FoxKit.Modules.DataSet.FoxCore.EntityLink>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 120, 1, Core.ContainerType.StringMap, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private Dictionary<string, FoxKit.Modules.DataSet.FoxCore.EntityLink> values = new Dictionary<string, FoxKit.Modules.DataSet.FoxCore.EntityLink>();
        
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "";
    }
}
