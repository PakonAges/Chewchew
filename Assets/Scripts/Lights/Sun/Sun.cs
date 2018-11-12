using UnityEngine;

public class Sun : MonoBehaviour {

    public float RotationSpeed = 30f;
	
	void Update () {
        transform.Rotate(Vector3.right, RotationSpeed * Time.deltaTime);
	}
}
