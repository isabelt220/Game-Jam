using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private float moveSpeedPerSecond = 1f;

    private Vector3 initialPosition;

    public void ResetPlayer()
    {
        this.transform.position = this.initialPosition;
    }

    private void Start()
    {
        this.initialPosition = this.transform.position;
    }

    
    private void Move() {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeedPerSecond;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedPerSecond;

        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);
    }

    private void Update()
    {
        Move();
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Portal")
        {
            this.OnHitPortal();
        }
    }

    public void OnHitPortal() {
        Debug.Log("The player has hit the portal");
        GameController.Instance.EndGame();
    }
}
