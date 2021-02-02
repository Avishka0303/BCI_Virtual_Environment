using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour{

    public float speed = 1f;
    
    // Update is called once per frame
    void Update() {
        if (Input.GetKey("a")) {    //move object to left
            Vector3 vect = new Vector3(-speed * Time.deltaTime, 0f, 0f);
            transform.localPosition += transform.localRotation * vect;
        }else if (Input.GetKey("d")) {    //move object to right side
            Vector3 vect = new Vector3(speed * Time.deltaTime, 0f, 0f);
            transform.localPosition += transform.localRotation * vect;
        }else if (Input.GetKey("w")) {    //move object to forward
            Vector3 vect = new Vector3(0f, 0f, speed * Time.deltaTime);
            transform.localPosition += transform.localRotation * vect;
        }else if (Input.GetKey("s")) {
            Vector3 vect = new Vector3(0f, 0f, -speed * Time.deltaTime);
            transform.localPosition += transform.localRotation * vect;
        }
    }

    private void OnTriggerEnter(Collider other){
        print("Sphere collided");
    }
}
