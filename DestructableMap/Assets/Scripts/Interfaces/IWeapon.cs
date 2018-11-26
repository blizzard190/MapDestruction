using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon {
    Vector3 _directio { get; }
    float _tillDeath { get; }
    float _speed { get; }
    float _AOE { get; }
    int _damage { get; }
    GameObject _effect { get; }
    LayerMask _destructible { get; }

    void SetTarget();
}
