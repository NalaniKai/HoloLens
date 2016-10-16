using UnityEngine;
using System.Collections;

public class CakeController : MonoBehaviour {
    GameObject myChef;
    // Use this for initialization
    void Start () {
        //look through heirarchy for gameobject called waffle
        myChef = GameObject.Find("Charakter_Chef");
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelect()
    {
        foreach (Renderer r in myChef.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
        AudioSource sound = myChef.GetComponent<ChefController>().getsound();
        sound.Play();
        Invoke("GoodBye", 26);


    }
    void GoodBye()
    {
        foreach (Renderer r in myChef.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
    }
}
