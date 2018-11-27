using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour, IWeapon {

    [SerializeField]
    private float AOE;
    public LayerMask des;
    public float timer;
    public float speed;
    private Vector3 dir;

    public virtual float _AOE
    {
        get
        {
            return AOE;
        }
    }

    public virtual int _damage
    {
        get
        {
            return 1;
        }
    }

    public LayerMask _destructible
    {
        get
        {
           return des;
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
            return speed;
        }
    }

    public Vector3 _direction
    {
        get
        {
            return dir;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Envirment"))
        {

            Collider2D[] objToDamage = Physics2D.OverlapCircleAll(transform.position, AOE, _destructible);
            for (int i = 0; i < objToDamage.Length; i++)
            {
                objToDamage[i].GetComponent<Destructable>().health -= _damage;
            }
           
            Destroy(gameObject);
        }
    }

    public virtual void SetTarget(Vector3 target)
    {
        dir = (target - transform.position).normalized;
        dir.z = -0.1328125f;
    }
}
