using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungScript : MonoBehaviour
{
    public float terbang;
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool hidup = true;
    public float timer = 0;
    public bool gameStart = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 2){
            myRigidbody.gravityScale = 3;
            gameStart = true;
        }else{
            timer = timer + Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space) && hidup && gameStart){
            myRigidbody.velocity = Vector2.up * terbang;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameover();
        hidup = false;
    }
}
