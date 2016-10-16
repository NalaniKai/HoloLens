using UnityEngine;
using System.Collections;

public class KittenController : MonoBehaviour
{
    GameObject myNurse;
    // Use this for initialization
    void Start()
    {
        //look through heirarchy for gameobject called waffle
        myNurse= GameObject.Find("Charakter_Nurse_1");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnSelect()
    {
        foreach (Renderer r in myNurse.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = true;
        }
        //AudioSource sound = myNurse.GetComponent<ChefController>().getsound();
        //sound.Play();
        //Invoke("GoodBye", 26);


    }
    void GoodBye()
    {
        foreach (Renderer r in myNurse.transform.GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
    }
}