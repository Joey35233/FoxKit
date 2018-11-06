//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was automatically generated.
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------
namespace FoxKit.Modules.DataSet.Fox.Sim
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
    using Sim;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class SimClothControl : SimControlElement
    {
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 72, 1, Core.ContainerType.StaticArray, PropertyExport.Never, PropertyExport.Never, typeof(Sim.SimClothControlParam), null)]
        private Sim.SimClothControlParam controlParam;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.EntityPtr, 80, 1, Core.ContainerType.DynamicArray, PropertyExport.EditorAndGame, PropertyExport.Never, typeof(Sim.SimClothControlUnit), null)]
        private List<Sim.SimClothControlUnit> clothControlUnits = new List<Sim.SimClothControlUnit>();
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Float, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Single windCoefficient;
        
        [OdinSerializeAttribute, NonSerializedAttribute, PropertyInfoAttribute(Core.PropertyInfoType.Bool, 0, 1, Core.ContainerType.StaticArray, PropertyExport.EditorAndGame, PropertyExport.EditorAndGame, null, null)]
        private System.Boolean isLoop;
        
        public override short ClassId => 72;
        
        public override ushort Version => 0;
        
        public override string Category => "Sim";
    }
}
