using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungScript : MonoBehaviour
{
    public float terbang;
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // gameObject.name = "Ubh namaa";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            myRigidbody.velocity = Vector2.up * terbang;
        }
    }
}
