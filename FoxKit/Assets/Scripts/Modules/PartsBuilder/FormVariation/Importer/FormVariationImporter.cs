namespace FoxKit.Modules.PartsBuilder.FormVariation.Importer
{
    using System;
    using System.IO;
    using UnityEditor.Experimental.AssetImporters;
    using FoxKit.Core;
    using FoxKit.Modules.PartsBuilder.FormVariation;

    /// <summary>
    /// ScriptedImporter to handle importing fv2 files.
    /// </summary>
    [ScriptedImporter(1, "fv2")]
    public class FormVariationImporter : ScriptedImporter
    {
        /// <summary>
        /// Hash manager for names.
        /// </summary>
        private StrCode32HashManager nameHashManager;

        /// <summary>
        /// Hash manager for file names.
        /// </summary>
        private StrCode64HashManager fileNameHashManager;

        /// <summary>
        /// Import a .fv2 file.
        /// </summary>
        /// <param name="ctx"></param>
        public override void OnImportAsset(AssetImportContext ctx)
        {
            InitializeDictionaries();

            FoxLib.FormVariation.FormVariation formVariation = null;

            using (var reader = new BinaryReader(new FileStream(ctx.assetPath, FileMode.Open)))
            {
                Action<int> skipBytes = numberOfBytes => SkipBytes(reader, numberOfBytes);
                Action<long> moveStream = bytePos => MoveStream(reader, bytePos);
                var readFunctions = new FoxLib.FormVariation.ReadFunctions(reader.ReadUInt16, reader.ReadUInt32, reader.ReadUInt64, reader.ReadByte, skipBytes, moveStream);
                formVariation = FoxLib.FormVariation.Read(readFunctions);
            }

            var formVariationSet = UnityEngine.ScriptableObject.CreateInstance<FormVariation>();

            formVariationSet = FormVariation.MakeFoxKitFormVariation(formVariation, nameHashManager, fileNameHashManager);

            ctx.AddObjectToAsset("fv2", formVariationSet);
            ctx.SetMainObject(formVariationSet);
        }

        /// <summary>
        /// Skip reading a number of bytes.
        /// </summary>
        /// <param name="reader">The BinaryReader to use.</param>
        /// <param name="numberOfBytes">The number of bytes to skip.</param>
        private static void SkipBytes(BinaryReader reader, long numberOfBytes)
        {
            reader.BaseStream.Position += numberOfBytes;
        }

        /// <summary>
        /// Move stream to a given position in bytes.
        /// </summary>
        /// <param name="reader">The BinaryReader to use.</param>
        /// <param name="bytePos">The byte number to move the stream position to.</param>
        private static void MoveStream(BinaryReader reader, long bytePos)
        {
            reader.BaseStream.Position = bytePos;
        }

        /// <summary>
        /// Initialize hash dictionaries.
        /// </summary>
        private void InitializeDictionaries()
        {
            this.nameHashManager = new StrCode32HashManager();
            this.fileNameHashManager = new StrCode64HashManager();

            this.nameHashManager.LoadDictionary(FormVariationPreferences.Instance.NameDictionary);
            this.fileNameHashManager.LoadDictionary(FormVariationPreferences.Instance.FileDictionary);
        }
    }
}