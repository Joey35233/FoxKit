//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.Ph
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
    using Ph;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class PhPolyhedronShapeParam : PhShapeParam
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 112, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<UnityEngine.Vector3> verts = new List<UnityEngine.Vector3>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 128, 1, Core.ContainerType.DynamicArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<System.UInt32> polys = new List<System.UInt32>();
        
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "Ph";
    }
}
