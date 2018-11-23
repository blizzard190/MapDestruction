using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Vector3 _target;
    private float _tillDeath;
    private Vector3 _direction;

    public float speed;
    public GameObject effect;

	void Start () {
        _tillDeath = 12f;
	}

    public void SetTarget(Vector3 target)
    {
        _direction = (target - transform.position).normalized;
    }

	void Update () {
        transform.position += _direction * speed * Time.deltaTime;
        _tillDeath -= Time.deltaTime;
        if(_tillDeath <= 0)
        {
            Destroy(gameObject);
        }
	}
}
