using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool isLeft;
    public LogicScript logic;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    var pos = transform.position;
    pos.x = -1;
    transform.position = pos;
    isLeft = true;
    }

    void Update()
   {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logic.GameRunning)
        {
    if (Input.GetMouseButtonDown(0))
    {

        if (isLeft == true)
        {
            var pos = transform.position;
            pos.x = 1;
            transform.position = pos;
            isLeft = false;
        }

        else
        {
            var pos = transform.position;
            pos.x = -1;
            transform.position = pos;
            isLeft = true;
            
        }
        }



    }


   }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
   




    // Update is called once per frame
}
