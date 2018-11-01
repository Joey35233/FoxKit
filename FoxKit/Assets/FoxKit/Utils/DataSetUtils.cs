﻿namespace FoxKit.Utils
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using FoxKit.Modules.Archive;
    using FoxKit.Modules.DataSet.FoxCore;
    using FoxKit.Modules.DataSet.Importer;

    using FoxLib;

    using UnityEditor;

    using UnityEngine;
    using UnityEngine.Assertions;

    /// <summary>
    /// Helper functions for working with DataSets.
    /// </summary>
    public static class DataSetUtils
    {
        /// <summary>
        /// Get the single value in a StaticArray property with exactly one element.
        /// </summary>
        /// <typeparam name="TValue">Type of the value to get.</typeparam>
        /// <param name="property">The property whose value to get.</param>
        /// <returns>The extracted value.</returns>
        public static TValue GetStaticArrayPropertyValue<TValue>(Core.PropertyInfo property)
        {
            CheckContainerType(property, Core.ContainerType.StaticArray);

            var container = ((Core.Container<TValue>.StaticArray)property.Container).Item;
            Assert.IsTrue(
                container.Length == 1,
                $"Expected a StaticArray containing exactly one element, but found one with {container.Length} in property {property.Name}.");

            return container[0];
        }

        public static List<TValue> GetStaticArrayValues<TValue>(Core.PropertyInfo property)
        {
            CheckContainerType(property, Core.ContainerType.StaticArray);
            return ((Core.Container<TValue>.StaticArray)property.Container).Item.ToList();
        }

        public static List<TValue> GetDynamicArrayValues<TValue>(Core.PropertyInfo property)
        {
            CheckContainerType(property, Core.ContainerType.DynamicArray);
            return ((Core.Container<TValue>.DynamicArray)property.Container).Item.ToList();
        }

        public static List<TValue> GetListValues<TValue>(Core.PropertyInfo property)
        {
            CheckContainerType(property, Core.ContainerType.List);
            return ((Core.Container<TValue>.List)property.Container).Item.ToList();
        }

        public static Dictionary<string, TValue> GetStringMap<TValue>(Core.PropertyInfo property)
        {
            CheckContainerType(property, Core.ContainerType.StringMap);
            var container = (Core.Container<TValue>.StringMap)property.Container;
            return container.Item.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        public static string AssetToFoxPath(UnityEngine.Object asset)
        {
            var unityPath = AssetDatabase.GetAssetPath(asset);
            return FoxUtils.UnityPathToFoxPath(unityPath);
        }

        public static EntityLink MakeEntityLink(DataSet owningDataSet, Core.EntityLink foxEntityLink, EntityFactory.EntityInitializeFunctions.GetEntityFromAddressDelegate getEntityByAddress, Func<string, Data> getEntityByName)
        {
            var link = new EntityLink(
                foxEntityLink.PackagePath,
                foxEntityLink.ArchivePath,
                foxEntityLink.NameInArchive,
                foxEntityLink.EntityHandle);

            if (link.IsDataIdentifierEntityLink)
            {
                return link;
            }

            // Store the archivePath for convenience later.
            if (string.IsNullOrEmpty(link.ArchivePath))
            {
                link.ArchivePath = AssetDatabase.GUIDToAssetPath(owningDataSet.DataSetGuid);
            }

            // If the EntityLink references an Entity inside its own DataSet, resolve it now.
            if (Path.GetFileNameWithoutExtension(link.ArchivePath) != owningDataSet.OwningDataSetName)
            {
                return link;
            }
            else if (link.Address != 0)
            {
                link.Entity = getEntityByAddress(link.Address) as Data;
            }
            else if (!string.IsNullOrEmpty(link.NameInArchive))
            {
                link.Entity = getEntityByName(link.NameInArchive);
            }

            return link;
        }

        public static Core.EntityLink MakeEntityLink(EntityLink unityEntityLink)
        {
            if (unityEntityLink.Entity == null)
            {
                return new Core.EntityLink(string.Empty, string.Empty, string.Empty, 0);
            }

            if (unityEntityLink.IsDataIdentifierEntityLink)
            {
                Assert.IsNotNull(unityEntityLink.DataIdentifier);
                Assert.IsFalse(string.IsNullOrEmpty(unityEntityLink.DataIdentifier.Identifier));
                Assert.IsFalse(string.IsNullOrEmpty(unityEntityLink.NameInArchive));
                return new Core.EntityLink("DATA_IDENTIFIER", unityEntityLink.DataIdentifier.Identifier, unityEntityLink.NameInArchive, 0);
            }

            var dataSetAsset = AssetDatabase.LoadAssetAtPath<DataSetAsset>(AssetDatabase.GUIDToAssetPath(unityEntityLink.Entity.DataSetGuid));

            var package = AssetDatabase.LoadAssetAtPath<PackageDefinition>(AssetDatabase.GUIDToAssetPath(dataSetAsset.PackageGuid));
            var packagePath = AssetToFoxPath(package);

            // Weirdly, EntityLinks reference .fpks instead of .fpkds, so remove the 'd' at the end.
            if (!string.IsNullOrEmpty(packagePath))
            {
                packagePath = packagePath.Remove(packagePath.Length - 1);
            }

            var archivePath = AssetToFoxPath(dataSetAsset);
            var nameInArchive = unityEntityLink.Entity.Name;

            /* It's going to be kind of a pain to implement a system for getting addresses, so for now let's just pray that we only need the nameInArchive.
             * If this causes problems ingame, we'll fix it then. */
            const ulong Address = 0UL;

            return new Core.EntityLink(
                packagePath,
                archivePath,
                nameInArchive,
                Address);
        }

        /// <summary>
        /// Does the given type require conversion to a Unity type?
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool DoesTypeRequireConversion(Core.PropertyInfoType type)
        {
            switch(type)
            {
                case Core.PropertyInfoType.Path:
                    return true;
                case Core.PropertyInfoType.EntityPtr:
                    return true;
                case Core.PropertyInfoType.Vector3:
                    return true;
                case Core.PropertyInfoType.Vector4:
                    return true;
                case Core.PropertyInfoType.Quat:
                    return true;
                case Core.PropertyInfoType.Matrix3:
                    return true;
                case Core.PropertyInfoType.Matrix4:
                    return true;
                case Core.PropertyInfoType.Color:
                    return true;
                case Core.PropertyInfoType.FilePtr:
                    return true;
                case Core.PropertyInfoType.EntityHandle:
                    return true;
                case Core.PropertyInfoType.EntityLink:
                    return true;
                case Core.PropertyInfoType.WideVector3:
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Is the given type a reference type?
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsTypeReference(Core.PropertyInfoType type)
        {
            switch (type)
            {
                case Core.PropertyInfoType.FilePtr:
                    return true;
                case Core.PropertyInfoType.EntityHandle:
                    return true;
                case Core.PropertyInfoType.EntityLink:
                    return true;
                case Core.PropertyInfoType.EntityPtr:
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Asserts that a property has a container of a given type.
        /// </summary>
        /// <param name="property">The property whose type to check.</param>
        /// <param name="expectedContainerType">The expected container type.</param>
        private static void CheckContainerType(Core.PropertyInfo property, Core.ContainerType expectedContainerType)
        {
            Assert.IsTrue(
                property.ContainerType == expectedContainerType,
                $"Expected container type {expectedContainerType} but found {property.ContainerType} in property {property.Name}.");
        }
    }
}