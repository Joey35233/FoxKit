//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.Graphx
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
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class GraphxSpatialGraphData : TransformData
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 304, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorOnly, typeof(Graphx.GraphxSpatialGraphDataNode), null)]
        private List<Graphx.GraphxSpatialGraphDataNode> nodes = new List<Graphx.GraphxSpatialGraphDataNode>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 320, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorOnly, typeof(Graphx.GraphxSpatialGraphDataEdge), null)]
        private List<Graphx.GraphxSpatialGraphDataEdge> edges = new List<Graphx.GraphxSpatialGraphDataEdge>();
        
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "Graphx";
        
        [ExposeMethodToLua(MethodStaticity.Instance)]
        partial void GetGraphNode(lua_State lua);
    }
}
