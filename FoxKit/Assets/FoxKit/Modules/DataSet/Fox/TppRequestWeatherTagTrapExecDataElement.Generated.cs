//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox
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
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class TppRequestWeatherTagTrapExecDataElement : GeoTrapModuleCallbackDataElement
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.String, 64, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.String tagName = string.Empty;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt8, 76, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Byte priority;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 72, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single interpTime;
        
        public override short ClassId => 44;
        
        public override ushort Version => 0;
        
        public override string Category => "";
    }
}
