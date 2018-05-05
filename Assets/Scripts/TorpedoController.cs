using UnityEngine;
using System.Collections;

public class TorpedoController : MonoBehaviour {

    public float moveSpeed;
    public float destroyDelay;

    private float totalTime; 
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
	}
	
	// Update is called once per frame
	void Update () {
        totalTime = totalTime + Time.deltaTime;

        if (totalTime > destroyDelay) {
            Destroy(this.gameObject);
        }
	}
}
