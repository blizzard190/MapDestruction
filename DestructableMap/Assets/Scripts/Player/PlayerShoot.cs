using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    private PlayerInput _PlayerInput;
    [SerializeField]
    private GameObject _Bullet;

	void Start () {
        _PlayerInput = GetComponent<PlayerInput>();
	}
	
	void Update () {
        if (_PlayerInput.schoot())
        {
            GameObject bullet = Instantiate(_Bullet) as GameObject;
            bullet.transform.position = this.gameObject.transform.position;
            bullet.GetComponent<Bullet>().SetTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
	}
}
