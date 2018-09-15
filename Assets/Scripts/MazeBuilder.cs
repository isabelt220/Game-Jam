using System.Collections.Generic;

using UnityEngine;

public class MazeBuilder : MonoBehaviour
{
    private static readonly FloorBehaviour.TileType[,] tiles = {
        //{ FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        //{ FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        //{ FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Lava }
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Lava, FloorBehaviour.TileType.Lava, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Lava, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Lava, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Lava, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal },
        { FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal, FloorBehaviour.TileType.Normal }
    };

    [SerializeField] private FloorBehaviour floorPrefab;

    private void Start()
    {
        this.BuildMaze();
    }

    private void BuildMaze() {
        for (int i = 0; i < tiles.GetLength(0); i++) {
            for (int j = 0; j < tiles.GetLength(1); j++) {
                FloorBehaviour newTile = this.InstantiateFloorTiles(tiles[i,j]);
                Vector3 newPosition = newTile.transform.position;

                newPosition.x = i;
                newPosition.z = j;

                newTile.transform.position = newPosition;
            }
        }
    }

    private FloorBehaviour InstantiateFloorTiles(FloorBehaviour.TileType type)
    {
        FloorBehaviour newTile = GameObject.Instantiate<FloorBehaviour>(this.floorPrefab, this.transform);
        newTile.Initialize(type);
        return newTile;
    }
}