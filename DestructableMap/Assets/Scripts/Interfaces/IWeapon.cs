using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon {
    Vector3 _direction { get; }
    float _speed { get; }
    float _AOE { get; }
    int _damage { get; }
    GameObject _effect { get; }
    LayerMask _destructible { get; }

    void SetTarget(Vector3 target);
    void OnTriggerEnter2D(Collider2D other);
}
