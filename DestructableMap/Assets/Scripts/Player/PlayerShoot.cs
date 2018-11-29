using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    private PlayerInput _PlayerInput;
    [SerializeField]
    private GameObject _Weapon;
    private WeaponSelect _Weapons;

	void Start () {
        _PlayerInput = GetComponent<PlayerInput>();
        _Weapons = GetComponent<WeaponSelect>();
	}
	
	void Update () {
        if (_PlayerInput.schoot())
        {
            _Weapon = _Weapons.CurrentWeapon;
            GameObject weapon = Instantiate(_Weapon) as GameObject;
            weapon.transform.position = this.gameObject.transform.position;
            weapon.GetComponent<WeaponBase>().SetTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            
            /*GameObject bullet = Instantiate(_Bullet) as GameObject;
            bullet.transform.position = this.gameObject.transform.position;
            bullet.GetComponent<WeaponBase>().SetTarget(Camera.main.ScreenToWorldPoint(Input.mousePosition));*/
        }
	}
}
