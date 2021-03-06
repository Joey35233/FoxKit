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
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class TransformData : Data
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityHandle, 120, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorOnly, null, null)]
        private FoxKit.Modules.DataSet.Fox.FoxCore.Entity parent;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 128, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FoxCore.TransformEntity), null)]
        private FoxCore.TransformEntity transform;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 136, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FoxCore.ShearTransformEntity), null)]
        private FoxCore.ShearTransformEntity shearTransform;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 144, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, typeof(FoxCore.PivotTransformEntity), null)]
        private FoxCore.PivotTransformEntity pivotTransform;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityHandle, 152, 1, Core.ContainerType.List, PropertyExport.Never, PropertyExport.Never, null, null)]
        private List<FoxKit.Modules.DataSet.Fox.FoxCore.Entity> children = new List<FoxKit.Modules.DataSet.Fox.FoxCore.Entity>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 184, 1, Core.ContainerType.StaticArray, PropertyExport.Never, PropertyExport.Never, null, typeof(TransformData_Flags))]
        private TransformData_Flags flags;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean inheritTransform;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean visibility;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean selection;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Matrix4, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.Never, null, null)]
        private UnityEngine.Matrix4x4 worldMatrix;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Matrix4, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.Never, null, null)]
        private UnityEngine.Matrix4x4 worldTransform;
        
        public override short ClassId => 0;
        
        public override ushort Version => 4;
        
        public override string Category => "";
        
        [ExposeMethodToLua(MethodStaticity.Instance)]
        partial void GetChildren(lua_State lua);
    }
}
