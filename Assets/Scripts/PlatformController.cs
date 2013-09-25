using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlatformController : MonoBehaviour {

	public Control moveLeft,
				   moveRight,
				   Jump;
	public float Gravity=9,
				 JumpStrength=20,
				 Movespeed=30;
	private CharacterController controller;
	CollisionFlags prevFlags;
	void Start()
	{
		controller = GetComponent<CharacterController>();
			if(controller == null)
		{
			Debug.LogError("No character Controller found on: " + name);
		}
	}
	void update()
	{
		Vector3 moveVec = Vector3.zero;
		
		if(moveLeft.IsActive)
		{
			moveVec.x -= Movespeed;
		}
		if(moveRight.IsActive)
		{
			moveVec.x += Movespeed;
		}
		controller.Move(moveVec * Time.deltaTime);
		//if(Jump.IsActive)
		//{
			//moveVec.y -= Gravity;
		//}
		prevFlags = controller.Move(moveVec * Time.deltaTime);
		
		//if(HideFlags.Has<CollisionFlags>(CollidedSides))
		//{
			//Debug.Log("I HIT SOMETHING..ON THE SIDE");
		//}
	}
}