using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 30;
    private PlayerController playercontrollerScript;
    private float leftbound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playercontrollerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrollerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
