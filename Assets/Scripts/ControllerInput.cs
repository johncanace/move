using UnityEngine;
using System.Collections;

public class ControllerInput : MonoBehaviour {
    
    public bool Activated
    {
        get { return activated; }
    }
    public bool Deactivated
    {
        get { return activated; }
    }
    
    public bool IsActive
    {
        get { return isActive; }
    }
    protected bool isActive = false;
    protected bool activated = false;
    protected bool deactivated = false;
	
}
        