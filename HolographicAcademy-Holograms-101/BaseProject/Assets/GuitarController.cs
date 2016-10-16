using UnityEngine;
using System.Collections;

public class GuitarController : MonoBehaviour {
    GameObject myWoman;
    // Use this for initialization
    void Start () {
        myWoman = GameObject.Find("Charakter_Woman");
    }
    void OnSelect()
    {
        foreach (Renderer r in myWoman.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
        AudioSource sound = myWoman.GetComponent<WomanController>().getsound();
        sound.Play();
        Invoke("GoodBye", 24);


    }
    void GoodBye()
    {
        foreach (Renderer r in myWoman.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
