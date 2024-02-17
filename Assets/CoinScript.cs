using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float moveSpeed;
    public float batas = -30;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < batas){
            Debug.Log("Koin dihapus");
            Destroy(gameObject);
        }
    }
}
