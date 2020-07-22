using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private GameManagerMain gm;

    private float speed;

    private void Awake()
    {
        GameObject gameManager = GameObject.FindWithTag("GameManager");
        if(gameManager != null)
            gm = gameManager.GetComponent<GameManagerMain>();
    }

    private void Update() {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) 
        {
            speed = gm.GetCharacterSpeed();
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            speed = gm.GetCharacterSpeed();
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            speed = gm.GetCharacterSpeed();
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            speed = gm.GetCharacterSpeed();
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
    }
}
