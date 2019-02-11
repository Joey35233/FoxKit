//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.FoxGameKit
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
    public partial class DecalArray : TransformData
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 304, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private FoxKit.Modules.DataSet.FoxCore.EntityLink material;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 344, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, typeof(DecalArray_ProjectionMode))]
        private DecalArray_ProjectionMode projectionMode;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 348, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single nearClipScale;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 352, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, typeof(DecalArray_ProjectionTarget))]
        private DecalArray_ProjectionTarget projectionTarget;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 356, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single repeatU;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 360, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single repeatV;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 364, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single transparency;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 368, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, typeof(DecalArray_PolygonDataSource))]
        private DecalArray_PolygonDataSource polygonDataSource;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 372, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, typeof(DecalArray_DrawRejectionLevel))]
        private DecalArray_DrawRejectionLevel drawRejectionLevel;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 376, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single drawRejectionDegree;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 380, 1, Core.ContainerType.StaticArray, PropertyExport.Never, PropertyExport.Never, null, null)]
        private System.UInt32 decalFlags;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 384, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<UnityEngine.Vector3> scales = new List<UnityEngine.Vector3>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Quat, 400, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<UnityEngine.Quaternion> rotations = new List<UnityEngine.Quaternion>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Vector3, 416, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<UnityEngine.Vector3> translations = new List<UnityEngine.Vector3>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityLink, 432, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<FoxKit.Modules.DataSet.FoxCore.EntityLink> targets = new List<FoxKit.Modules.DataSet.FoxCore.EntityLink>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 448, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<System.UInt32> targetIndices = new List<System.UInt32>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.UInt32, 464, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<System.UInt32> targetStartIndices = new List<System.UInt32>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Int32, 480, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private List<System.Int32> renderingPriorities = new List<System.Int32>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isDisableAlbedo;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isPreserveAspect;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isWrap;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean showObject;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isVisibleGeom;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isSSDecal;
        
        public override short ClassId => 448;
        
        public override ushort Version => 1;
        
        public override string Category => "Decal";
    }
}
