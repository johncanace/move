using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{

    public float MoveSpeed = 5f;
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBack = KeyCode.S;
    private float trueSpeed
    {
        get { return MoveSpeed * Time.deltaTime; }
    }
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {   
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * trueSpeed);

        }
	}
}
