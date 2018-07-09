﻿namespace FoxKit.Modules.DataSet.Ui
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FoxKit.Modules.DataSet.Exporter;
    using FoxKit.Modules.DataSet.FoxCore;
    using FoxKit.Utils;

    using FoxLib;

    using UnityEditor;

    using UnityEngine;
    using UnityEngine.UI;

    /// <inheritdoc />
    /// <summary>
    /// TODO: Figure out.
    /// </summary>
    [Serializable]
    public class UiGraphEntry : Data
    {
        /// <summary>
        /// TODO: Figure out.
        /// </summary>
        [SerializeField, Modules.DataSet.Property("UI")]
        private List<UnityEngine.Object> files = new List<UnityEngine.Object>();

        /// <summary>
        /// TODO: Figure out.
        /// </summary>
        [SerializeField, Modules.DataSet.Property("UI")]
        private List<UnityEngine.Object> rawFiles = new List<UnityEngine.Object>();

        /// <summary>
        /// TODO: Figure out.
        /// </summary>
        [SerializeField, HideInInspector]
        private List<string> filesPaths = new List<string>();

        /// <summary>
        /// TODO: Figure out.
        /// </summary>
        [SerializeField, HideInInspector]
        private List<string> rawFilesPaths = new List<string>();

        /// <inheritdoc />
        public override Texture2D Icon => EditorGUIUtility.ObjectContent(null, typeof(LayoutElement)).image as Texture2D;

        /// <inheritdoc />
        public override short ClassId => 96;

        /// <inheritdoc />
        public override ushort Version => 1;

        /// <inheritdoc />
        public override void OnAssetsImported(FoxKit.Core.AssetPostprocessor.TryGetAssetDelegate tryGetAsset)
        {
            base.OnAssetsImported(tryGetAsset);

            foreach (var path in this.filesPaths)
            {
                UnityEngine.Object file = null;
                tryGetAsset(path, out file);
                this.files.Add(file);
            }

            foreach (var path in this.rawFilesPaths)
            {
                UnityEngine.Object file = null;
                tryGetAsset(path, out file);
                this.rawFiles.Add(file);
            }
        }

        /// <inheritdoc />
        public override List<Core.PropertyInfo> MakeWritableStaticProperties(Func<Entity, ulong> getEntityAddress, Func<EntityLink, Core.EntityLink> convertEntityLink)
        {
            var parentProperties = base.MakeWritableStaticProperties(getEntityAddress, convertEntityLink);
            parentProperties.Add(PropertyInfoFactory.MakeDynamicArrayProperty(
                "files",
                Core.PropertyInfoType.FilePtr,
                (from file in this.files
                 select DataSetUtils.UnityPathToFoxPath(AssetDatabase.GetAssetPath(file)) as object).ToArray()));
            parentProperties.Add(PropertyInfoFactory.MakeDynamicArrayProperty(
                "rawFiles",
                Core.PropertyInfoType.FilePtr,
                (from file in this.rawFiles
                 select DataSetUtils.UnityPathToFoxPath(AssetDatabase.GetAssetPath(file)) as object).ToArray()));
            return parentProperties;
        }

        /// <inheritdoc />
        protected override void ReadProperty(Core.PropertyInfo propertyData, Importer.EntityFactory.EntityInitializeFunctions initFunctions)
        {
            base.ReadProperty(propertyData, initFunctions);

            switch (propertyData.Name)
            {
                case "files":
                    {
                        var filePtrList = DataSetUtils.GetDynamicArrayValues<string>(propertyData);
                        this.files = new List<UnityEngine.Object>(filePtrList.Count);
                        this.filesPaths = new List<string>(filePtrList.Count);

                        foreach (var filePtr in filePtrList)
                        {
                            var path = DataSetUtils.ExtractFilePath(filePtr);
                            this.filesPaths.Add(path);
                        }
                        break;
                    }
                case "rawFiles":
                    {
                        var filePtrList = DataSetUtils.GetDynamicArrayValues<string>(propertyData);
                        this.rawFiles = new List<UnityEngine.Object>(filePtrList.Count);
                        this.rawFilesPaths = new List<string>(filePtrList.Count);

                        foreach (var filePtr in filePtrList)
                        {
                            var path = DataSetUtils.ExtractFilePath(filePtr);
                            this.rawFilesPaths.Add(path);
                        }
                        break;
                    }
            }
        }
    }
}