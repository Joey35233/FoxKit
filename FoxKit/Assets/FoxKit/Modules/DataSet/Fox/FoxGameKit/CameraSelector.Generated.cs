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
    public partial class CameraSelector : Entity
    {
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "";
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void __call(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetMainInstance(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetMainInstance(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void DumpActiveCamera(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Instance)]
        partial void GetRenderName(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Instance)]
        partial void GetViewportName(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Instance)]
        partial void SetMainListener(lua_State lua);
    }
}
