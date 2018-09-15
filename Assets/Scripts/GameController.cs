using UnityEngine;

public class GameController : MonoBehaviour {
    private static GameController instance;

    [SerializeField] private Player playerPrefab;

    private Player player1;
    // private Player player2;

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
    }
}
