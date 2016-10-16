using UnityEngine;
using System.Collections;

public class wafflecontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {

        foreach (Renderer r in gameObject.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
