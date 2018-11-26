using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour, IWeapon {

    public virtual float _AOE
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual int _damage
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual LayerMask _destructible
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual Vector3 _directio
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual GameObject _effect
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual float _speed
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual float _tillDeath
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public virtual void SetTarget()
    {
        throw new NotImplementedException();
    }
}
