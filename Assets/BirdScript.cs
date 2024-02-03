using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        // Jelaskan bagaimana cara mengubah atribut dalam game object
        // gameObject.name = "Bob Birdington";
    }

    // Update is called once per frame
    void Update()
    {
        // hubungkan Rigidbody
        // myRigidbody.velocity = Vector2.up * 10;

        // Ubah velocity Rigidbody setiap kali user menekan space
        if(Input.GetKeyDown(KeyCode.Space) == true){
            myRigidbody.velocity = Vector2.up * flapStrength;

            //rotate
            transform.Rotate(new Vector3(0, 0, 45));
        }

        if(transform.localEulerAngles.z != 0){
            transform.Rotate(new Vector3(0, 0, -15));
        }
    }
}
