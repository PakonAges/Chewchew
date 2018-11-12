using UnityEngine;

public class Movement : MonoBehaviour {

    public float MoveForceMultiplier;

	void Update () {
        transform.GetComponent<Rigidbody>().AddForce(Vector3.right * MoveForceMultiplier);
	}
}
