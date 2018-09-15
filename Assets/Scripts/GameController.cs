using UnityEngine;

public class GameController : MonoBehaviour {
    private static GameController instance;

    [SerializeField] private Player playerPrefab;
    [SerializeField] private Portal portalPrefab;
    [SerializeField] private Wall wallPrefab;


    private Player player1;
    // private Player player2;
    private Portal portal;
    private Wall[] walls = new Wall[1000];

    public static GameController Instance {
        get {
            return instance;
        }
    }

    public void EndGame()
    {
        // TODO: 
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
        Debug.Log("instantiating walls");
        float x = -1f;
        float y = 0f;
        float z = 0f;
        for (int i = 0; i < 40; i++)
        {
            this.walls[i] = GameObject.Instantiate<Wall>(this.wallPrefab);
            if(i < 100)
                this.walls[i].transform.position = new Vector3(x, y, z+=1);
            else if(i < 200)
                this.walls[i].transform.position = new Vector3(x+=1, y, z);
            else if (i < 300)
                this.walls[i].transform.position = new Vector3(x, y, z-=1);
            else if (i < 400)
                this.walls[i].transform.position = new Vector3(x-=1, y, z);
        }
    }


}
