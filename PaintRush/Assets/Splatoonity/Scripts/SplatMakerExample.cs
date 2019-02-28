using UnityEngine;
using System.Collections;

public class SplatMakerExample : MonoBehaviour {
	
	Vector4 channelMask = new Vector4(1,0,0,0);

	int splatsX = 1;
	int splatsY = 1;

	public float splatScale = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// Get how many splats are in the splat atlas
		splatsX = SplatManagerSystem.instance.splatsX;
		splatsY = SplatManagerSystem.instance.splatsY;

		if( Input.GetKeyDown (KeyCode.Alpha1) ){
			channelMask = new Vector4(1,0,0,0);
		}
		
		if( Input.GetKeyDown (KeyCode.Alpha2) ){
			channelMask = new Vector4(0,1,0,0);
		}
		
		if( Input.GetKeyDown (KeyCode.Alpha3) ){
			channelMask = new Vector4(0,0,1,0);
		}
		
		if( Input.GetKeyDown (KeyCode.Alpha4) ){
			channelMask = new Vector4(0,0,0,1);
		}
			
		// Cast a ray from the camera to the mouse pointer and draw a splat there.
		// This just picks a rendom scale and bias for a 4x4 splat atlas
		// You could use a larger atlas of splat textures and pick a scale and offset for the specific splat you want to use
		if (Input.GetMouseButton (0)) {
			

			}
		}
	
	}

