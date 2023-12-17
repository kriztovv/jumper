using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpike : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -6;
    public bool gameRunning = true;
    public LogicScript yourScript;

    // Start is called before the first frame update
    void Start()
    {
        yourScript = GameObject.FindWithTag("Logic")?.GetComponent<LogicScript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        gameRunning = yourScript.GameRunning;
        if (gameRunning)
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
        

    }
}
