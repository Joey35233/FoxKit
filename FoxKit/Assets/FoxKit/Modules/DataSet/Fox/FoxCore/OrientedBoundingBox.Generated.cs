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
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class OrientedBoundingBox
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Vector3 center;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 16, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Vector3 size;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Quat, 32, 1, Core.ContainerType.StaticArray, PropertyExport.EditorOnly, PropertyExport.EditorOnly, null, null)]
        private UnityEngine.Quaternion rotation;
        
    }
}
