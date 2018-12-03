using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public bool shoot()
    {
        return Input.GetMouseButtonDown(0);
    }
    
    public bool WeaponSwitchUp()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    public bool WeaponSwitchDown()
    {
        return Input.GetKeyDown(KeyCode.Q);
    }
}
