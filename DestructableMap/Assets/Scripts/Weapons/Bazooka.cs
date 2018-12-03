using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : WeaponBase {

    void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
