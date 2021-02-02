using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftWall: MonoBehaviour {
    
    public Text scoreText;
    private void OnTriggerEnter(Collider other) {
        print("Sphere collided left wall"+other.gameObject.tag);
        Vector3 initPosition = new Vector3(0f,1.91f,-15.68f);
        other.gameObject.transform.position = initPosition;
        scoreText.text = "Left wall hitted.";
    }
}
