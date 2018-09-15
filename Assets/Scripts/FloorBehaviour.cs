using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehaviour : MonoBehaviour {
    public enum TileType {
        Normal, Lava
    }

    [SerializeField] GameObject normalFloorTile;
    [SerializeField] GameObject lavaFloorTile;

    public TileType currentType { get; private set; }

    public void Initialize(TileType initialType) {
        this.currentType = initialType;

        this.ReloadTileView();
    }

    public void SwitchFloorTiles () {
        switch (this.currentType)
        {
            case TileType.Normal:
                this.currentType = TileType.Lava;
                break;
            case TileType.Lava:
                this.currentType = TileType.Normal;
                break;
        }

        this.ReloadTileView();
    }

    private void ReloadTileView() {
        this.normalFloorTile.SetActive(false);
        this.lavaFloorTile.SetActive(false);

        switch (this.currentType)
        {
            case TileType.Normal:
                this.normalFloorTile.SetActive(true);
                break;
            case TileType.Lava:
                this.lavaFloorTile.SetActive(true);
                break;
        }
    }


}
