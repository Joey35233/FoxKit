﻿using UnityEditor;

namespace FoxKit.Modules.Terrain.Editor
{
    using System.Collections.Generic;
    using System.Linq;

    using FoxKit.Utils;

    using UnityEngine;
    using UnityEngine.Assertions;

    [CanEditMultipleObjects]
    [CustomEditor(typeof(TerrainAsset))]
    public class TerrainAssetEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            GUI.enabled = true;

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Stitch terrain tiles"))
            {
                var asset = this.target as TerrainAsset;
                var path = EditorUtility.SaveFilePanelInProject(
                    "Save terrain atlas",
                    asset.name + "_atlas",
                    "asset",
                    "Enter a file name to save the terrain atlas to.");
                if (string.IsNullOrEmpty(path))
                {
                    return;
                }

                var tiles = this.GetTerrainTiles();
                var atlas = StitchTerrainTiles((int)(asset.Width - 1), (int)(asset.Height - 1), tiles);

                AssetDatabase.CreateAsset(atlas, path);
                AssetDatabase.Refresh();

                asset.SetHeightmapAtlas(atlas);
            }

            EditorGUILayout.EndHorizontal();

            this.DrawDefaultInspector();
        }

        private static Texture2D StitchTerrainTiles(int atlasWidth, int atlasHeight, IEnumerable<TerrainTileAsset> tiles)
        {
            var atlas = new Texture2D(atlasWidth, atlasHeight, TextureFormat.RGBAFloat, false);
            var heightmaps = from tile in tiles
                             select tile.Heightmap;

            foreach (var heightmap in heightmaps)
            {
                var xIndex = int.Parse(heightmap.name.Substring(5, 3)) - 101;
                var yIndex = int.Parse(heightmap.name.Substring(9, 3)) - 101;

                // FIXME
                // Currently, htre heightmaps come in rotated, so unrotate them.
                var heightmapPixels = heightmap.GetPixels();
                var rotatedHeightmap = new Color[heightmap.width * heightmap.height];
                for (var i = 0; i < heightmap.width; ++i)
                {
                    for (var j = 0; j < heightmap.height; ++j)
                    {
                        rotatedHeightmap[i * heightmap.width + j] = heightmapPixels[(heightmap.width - j - 1) * heightmap.width + i];
                    }
                }

                atlas.SetPixels(
                    atlasWidth - ((xIndex + 1) * heightmap.width),
                    yIndex * heightmap.height,
                    heightmap.width,
                    heightmap.height,
                    rotatedHeightmap);
            }

            return atlas;
        }

        private IEnumerable<TerrainTileAsset> GetTerrainTiles()
        {
            var asset = this.target as TerrainAsset;
            Assert.IsNotNull(asset);
            
            var baseName = asset.name.Substring(0, 4);
            return from tile in UnityFileUtils.GetAllAssetsOfType<TerrainTileAsset>()
                   where tile.name.StartsWith(baseName)
                   select tile;
        }
    }
}