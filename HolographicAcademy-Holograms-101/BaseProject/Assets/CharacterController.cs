using UnityEngine;
using System.Collections;

/**
 * This script reperesetns the controller which effects our 
 * first person character used for testing. this script handles 
 * translating up/down, forward/back, and
 * left/right. the Vertical angle of sight is handled within the 
 * CharacterCameraController script attached to this objects 
 * Main Camera child.
 **/
public class CharacterController : MonoBehaviour {

    [SerializeField]
    public float tSpeed;

    private Vector3 myOriginalPosition;

	// Use this for initialization
	void Start () {
        // Turns off the cursor so we dont see it on screen
        // also locks the cursur to be in the game window
        //Cursor.lockState = CursorLockMode.Locked;

        //the original position of the character
        myOriginalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        //distance traveled forward, back
        float translation = Input.GetAxis("Vertical") * tSpeed;
        //distance strafed side to side
        float strafe = Input.GetAxis("Horizontal") * tSpeed;
        //distance traveled up/down
        float rise = Input.GetAxis("Mouse ScrollWheel") * tSpeed * 5;

        //used to stabilize the movement perportinally to the time of this call
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;
        rise *= Time.deltaTime;

        //move the player
        transform.Translate(strafe, rise, translation);

        //if we hit ESC, exit cursor lock
        if (Input.GetKeyDown("escape"))
            //Cursor.lockState = CursorLockMode.None;

        //if f is pressed, reposition and focus and position
        //the character at (0,0,0)
        if (Input.GetKeyDown("f"))
        {
            transform.position = myOriginalPosition;
            transform.rotation = Quaternion.identity;
            GetComponentInChildren<CharacterCameraController>().myMouseLook = new Vector2(0, 0);
            GetComponentInChildren<CharacterCameraController>().mySmoothV = new Vector2(0, 0);
        }
	}
}
