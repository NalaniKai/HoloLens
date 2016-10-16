using UnityEngine;
using System.Collections;

public class WomanController : MonoBehaviour {
    public AudioClip womanStory;
    public AudioSource womanSource;
    // Use this for initialization
    void Start () {
        foreach (Renderer r in gameObject.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
        womanSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioSource getsound()
    {
        return womanSource;
    }
}
