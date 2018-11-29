using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour {

    public GameObject CurrentWeapon;

    private int _weapon = 0;
    private PlayerInput _playerInput;
    public List<GameObject> _Weapons;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        CurrentWeapon = _Weapons[_weapon];
    }

    void Update () {
        if (_playerInput.WeaponSwitchUp())
        {
            _weapon++;
            WeaponSwitch();
        }
        if (_playerInput.WeaponSwitchDown())
        {
            _weapon--;
            WeaponSwitch();
        }
	}

    private void WeaponSwitch()
    {
        if(_weapon == _Weapons.Count)
        {
            _weapon = 0;
            CurrentWeapon = _Weapons[_weapon];
        }
        else
        {
            CurrentWeapon = _Weapons[_weapon];
        }
    }
}
