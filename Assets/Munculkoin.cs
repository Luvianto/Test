using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munculkoin : MonoBehaviour
{
    public GameObject coin;
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }else{
           spawnCoin();
        }
    }

    void spawnCoin(){
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(coin, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
        timer = 0;
    }
}
