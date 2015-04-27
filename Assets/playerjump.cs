using UnityEngine;
using System.Collections;

public class playerjump : MonoBehaviour {
	public float longjump,walk;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
						GetComponent<Rigidbody>().velocity = Vector3.zero;
						GetComponent<Rigidbody>().AddForce (Vector3.up * longjump);
				}
		transform.position +=(Vector3.right/20);
	}
}
