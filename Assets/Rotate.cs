using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float tumble;
	
	void Start() {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
