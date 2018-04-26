﻿using FoxKit.Modules.DataSet.Importer;
using FoxTool.Fox;
using FoxTool.Fox.Types.Values;
using FoxKit.Utils;
using FoxKit.Modules.DataSet.GameCore;
using FoxKit.Utils.UI.StringMap;
using System;
using FoxKit.Modules.DataSet.FoxCore;
using System.Collections.Generic;

namespace FoxKit.Modules.DataSet.Ui
{
    [Serializable]
    public class UiGraphEntry : Data
    {
        public List<UnityEngine.Object> Files;
        public List<UnityEngine.Object> RawFiles;

        protected override void ReadProperty(FoxProperty propertyData, EntityFactory.GetEntityFromAddressDelegate getEntity)
        {
            base.ReadProperty(propertyData, getEntity);

            if (propertyData.Name == "files")
            {
                var filePtrList = DataSetUtils.GetDynamicArrayValues<FoxFilePtr>(propertyData);
                Files = new List<UnityEngine.Object>(filePtrList.Count);

                foreach (var filePtr in filePtrList)
                {
                    UnityEngine.Object file;
                    var fileFound = DataSetUtils.TryGetFile(filePtr, out file);
                    Files.Add(file);
                }
            }
            else if (propertyData.Name == "rawFiles")
            {
                var filePtrList = DataSetUtils.GetDynamicArrayValues<FoxFilePtr>(propertyData);
                RawFiles = new List<UnityEngine.Object>(filePtrList.Count);

                foreach (var filePtr in filePtrList)
                {
                    UnityEngine.Object file;
                    var fileFound = DataSetUtils.TryGetFile(filePtr, out file);
                    RawFiles.Add(file);
                }
            }
        }
    }
}