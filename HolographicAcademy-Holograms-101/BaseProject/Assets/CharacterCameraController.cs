using UnityEngine;
using System.Collections;

/**
 * This script handles the angle of our first person
 * character controllers view. It adjusts the vertical 
 * angle of view of the camera and the horizontal 
 * angle of view of the character by mouse position
 * */
public class CharacterCameraController : MonoBehaviour {

    public Vector2 myMouseLook;
    public Vector2 mySmoothV;
    public float mySensitivity = 5.0f;
    public float mySmoothing = 2.0f;

    GameObject myCharacter;

    // Use this for initialization
    void Start () {
        //reference for the parent character
        myCharacter = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        //get the rotation of the mouse
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"),
            Input.GetAxisRaw("Mouse Y"));

        //scale our mouse vector with smooting and our sensitivity
        md = Vector2.Scale(md, new Vector2(mySensitivity + mySmoothing,
            mySensitivity + mySmoothing));

        //lerp between our mouse position and current position
        mySmoothV.x = Mathf.Lerp(mySmoothV.x, md.x, 1f / mySmoothing);
        mySmoothV.y = Mathf.Lerp(mySmoothV.y, md.y, 1f / mySmoothing);
        myMouseLook += mySmoothV;

        //rotate the camera vertically, character horizontally
        transform.localRotation = 
            Quaternion.AngleAxis(-myMouseLook.y, Vector3.right);
        myCharacter.transform.localRotation = 
            Quaternion.AngleAxis(myMouseLook.x, myCharacter.transform.up);
    }
}
