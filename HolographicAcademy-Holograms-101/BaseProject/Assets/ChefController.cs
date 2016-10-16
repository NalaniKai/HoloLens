using UnityEngine;
using System.Collections;

public class ChefController : MonoBehaviour {
    public AudioClip chefStory;
    public AudioSource chefSource;
    // Use this for initialization
    void Start () {
        
        foreach (Renderer r in gameObject.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
        chefSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public AudioSource getsound()
    {
        return chefSource;
    }
}
