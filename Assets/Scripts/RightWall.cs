using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightWall : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        print("Sphere collided right wall");
        Vector3 initPosition = new Vector3(0f,1.91f,-8.68f);
        other.gameObject.transform.localPosition = initPosition;
    }
}
