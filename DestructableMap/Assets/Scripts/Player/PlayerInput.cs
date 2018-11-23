using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    public bool schoot()
    {
        return Input.GetMouseButtonDown(0);
    }
}
