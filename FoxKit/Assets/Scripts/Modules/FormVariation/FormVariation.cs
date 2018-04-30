﻿namespace FoxKit.Modules.PartsBuilder.FormVariation
{
    using System.Linq;
    using UnityEngine;
    using FoxKit.Core;

    /// <summary>
    /// A set of form variation options used by the FoxEngine. 
    /// </summary>
    [CreateAssetMenu(fileName = "New Form Variation", menuName = "FoxKit/Part Builder/Form Variation")]
    public class FormVariation : ScriptableObject
    {
        public HiddenMeshGroup[] HiddenMeshGroups;
        public ShownMeshGroup[] ShownMeshGroups;
        public TextureSwap[] TextureSwaps;
        public BoneAttachment[] BoneAttachments;
        public CNPAttachment[] CNPAttachments;

        /// <summary>
        /// Makes a FoxKit FormVariation from a FoxLib FormVariation.
        /// </summary>
        /// <param name="formVariation">The FoxLib FormVariation to convert.</param>
        /// <param name="nameHashManager">An StrCode32 hash manager used for hashing and unhashing names.</param>
        /// <param name="fileHashManager">An StrCode64 hash manager used for hashing and unhashing file names.</param>
        /// <returns>The FoxKit FormVariation.</returns>
        public static FormVariation MakeFoxKitFormVariation(FoxLib.FormVariation.FormVariation formVariation, StrCode32HashManager nameHashManager, StrCode64HashManager fileHashManager)
        {
            var hiddenMeshGroups = (from hiddenMeshGroup in formVariation.HiddenMeshGroups select HiddenMeshGroup.MakeFoxKitHiddenMeshGroup(hiddenMeshGroup, nameHashManager)).ToArray();

            var shownMeshGroups = (from shownMeshGroup in formVariation.ShownMeshGroups select ShownMeshGroup.MakeFoxKitShownMeshGroup(shownMeshGroup, nameHashManager)).ToArray();

            var textureSwaps = (from textureSwap in formVariation.TextureSwaps select TextureSwap.MakeFoxKitTextureSwap(textureSwap, nameHashManager, fileHashManager)).ToArray();

            var boneAttachments = (from boneAttachment in formVariation.BoneAttachments select BoneAttachment.MakeFoxKitBoneAttachment(boneAttachment, fileHashManager)).ToArray();

            var CNPAttachments = (from cNPAttachment in formVariation.CNPAttachments select CNPAttachment.MakeFoxKitCNPAttachment(cNPAttachment, nameHashManager, fileHashManager)).ToArray();

            var newFormVariation = CreateInstance<FormVariation>();

            newFormVariation.HiddenMeshGroups = hiddenMeshGroups;
            newFormVariation.ShownMeshGroups = shownMeshGroups;
            newFormVariation.TextureSwaps = textureSwaps;
            newFormVariation.BoneAttachments = boneAttachments;
            newFormVariation.CNPAttachments = CNPAttachments;

            return newFormVariation;
        }

        /// <summary>
        /// Makes a FoxLib FormVariation from a FoxKit FormVariation.
        /// </summary>
        /// <param name="formVariation">The FoxKit FormVariation to convert.</param>
        /// <param name="nameHashManager">An StrCode32 hash manager used for hashing and unhashing names.</param>
        /// <param name="fileHashManager">An StrCode64 hash manager used for hashing and unhashing file names.</param>
        /// <returns>The FoxLib FormVariation.</returns>
        public static FoxLib.FormVariation.FormVariation MakeFoxLibFormVariation(FormVariation formVariation, StrCode32HashManager nameHashManager, StrCode64HashManager fileHashManager)
        {
            var hiddenMeshGroups = (from hiddenMeshGroup in formVariation.HiddenMeshGroups select HiddenMeshGroup.MakeFoxLibHiddenMeshGroup(hiddenMeshGroup, nameHashManager)).ToArray();

            var shownMeshGroups = (from shownMeshGroup in formVariation.ShownMeshGroups select ShownMeshGroup.MakeFoxLibShownMeshGroup(shownMeshGroup, nameHashManager)).ToArray();

            var textureSwaps = (from textureSwap in formVariation.TextureSwaps select TextureSwap.MakeFoxLibTextureSwap(textureSwap, nameHashManager, fileHashManager)).ToArray();

            var boneAttachments = (from boneAttachment in formVariation.BoneAttachments select BoneAttachment.MakeFoxLibBoneAttachment(boneAttachment, fileHashManager)).ToArray();

            var CNPAttachments = (from cNPAttachment in formVariation.CNPAttachments select CNPAttachment.MakeFoxLibCNPAttachment(cNPAttachment, nameHashManager, fileHashManager)).ToArray();

            return new FoxLib.FormVariation.FormVariation(hiddenMeshGroups, shownMeshGroups, textureSwaps, CNPAttachments, boneAttachments);
        }
    }
}