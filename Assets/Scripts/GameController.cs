using UnityEngine;

public class GameController : MonoBehaviour {
    private static GameController instance;

    [SerializeField] private Player playerPrefab;
    [SerializeField] private Portal portalPrefab;
    [SerializeField] private Wall wallPrefab;


    private Player player1;
    // private Player player2;
    private Portal portal;
    private Wall[] walls = new Wall[10];

    public static GameController Instance {
        get {
            return instance;
        }
    }

    public void EndGame()
    {
        Debug.Log("You win!");
    }

    private void Awake()
    {
        instance = this;
    }

    private void Start() {
        this.player1 = GameObject.Instantiate<Player>(this.playerPrefab);
        // this.player2 = GameObject.Instantiate<Player>(this.playerPrefab);
        this.portal = GameObject.Instantiate<Portal>(this.portalPrefab);
        instantiateWalls();
    }

    private void instantiateWalls() {
        float x = 0f;
        float y = 0f;
        float z = 0f;
        for (int i = 0; i < 10; i++)
        {
            this.walls[i] = GameObject.Instantiate<Wall>(this.wallPrefab);
            this.walls[i].transform.position = new Vector3(x, y, z+i);
        }
    }
}
