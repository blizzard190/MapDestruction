using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    
    private float _tillDeath;
    private Vector3 _direction;

    public float speed;
    //public GameObject effect;
    public float AOE;
    public LayerMask Destructible;
    public int damage;

	void Start () {
        _tillDeath = 12f;
	}

    public void SetTarget(Vector3 target)
    {
        _direction = (target - transform.position).normalized;
        _direction.z = -0.1328125f;
    }

	void Update () {
        transform.position += _direction * speed * Time.deltaTime;
        _tillDeath -= Time.deltaTime;
        if(_tillDeath <= 0)
        {
            Debug.Log(_tillDeath);
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Envirment"))
        {
            Collider2D[] objToDamage = Physics2D.OverlapCircleAll(transform.position, AOE, Destructible);
            for(int i = 0; i < objToDamage.Length; i++)
            {
                objToDamage[i].GetComponent<Destructable>().health -= damage;
            }
            //Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AOE);
    }
}
