using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSspawner : MonoBehaviour
{
    public GameObject spike;
    public float spawnRate = 3;
    private float timer = 0;
    public float randomNumber;
    public float random;
    public bool gameRunning = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        LogicScript yourScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


        if (yourScript.GameRunning)
        {
                    randomNumber = Random.Range(0f, 1f);
        random = Random.Range(0f, 3f);



        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnSpike();
            timer = randomNumber;
        }

        if (random >= 1.5)
        {
            var pos = transform.position;
            pos.x = 1.5f;
            transform.position = pos;
        }
        else
        {
            var pos = transform.position;
            pos.x = -1.5f;
            transform.position = pos;
        }
        }


    }


        void spawnSpike()
    {
 
        Instantiate(spike, transform.position, transform.rotation);
    }
}
