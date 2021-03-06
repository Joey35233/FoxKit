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
    using static KopiLua.Lua;
    using OdinSerializer;
    using UnityEngine;
    using DataSetFile2 = DataSetFile2;
    using TppGameKit = FoxKit.Modules.DataSet.Fox.TppGameKit;
    
    [SerializableAttribute, ExposeClassToLuaAttribute]
    public partial class Pad : Entity
    {
        public override short ClassId => 0;
        
        public override ushort Version => 0;
        
        public override string Category => "";
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterButtonAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterButtonAssignAsNoButton(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetAssignedButtonNumber(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterStickAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterStickAssignAsNoStick(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterStickAxisReverse(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterTriggerAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterTriggerAssignAsNoTrigger(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void DeleteButtonAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void DeleteStickAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void DeleteTriggerAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearButtonAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearStickAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearTriggerAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonStatus(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonPress(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonRelease(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonPressDuration(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonReleaseDuration(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonLastPressDuration(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonLastReleaseDuration(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetStickAxis(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetStickDir(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetStickTilt(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetTrigger(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetFullMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetButtonMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetStickAxisMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetStickMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetTriggerMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetPhysicalButtonMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetCameraDirection(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonLongPress(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetButtonPressCountAsKeyRepeat(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearButtonPressLog(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetDeviceType(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetMainPadIndex(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetMainPadIndex(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterAxisAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterAxisAssignAsNoAxis(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void RegisterAxisReverse(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void DeleteAxisAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void ClearAxisAssign(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void GetAxis(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void SetAxisMask(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void CalculateStickForce(lua_State lua);
        
        [ExposeMethodToLua(MethodStaticity.Static)]
        static partial void CalculateStickDirection(lua_State lua);
    }
}
