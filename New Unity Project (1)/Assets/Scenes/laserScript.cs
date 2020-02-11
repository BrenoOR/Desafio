using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public float laserSpeed = 15f;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * laserSpeed;
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log(hit.name);
        enemyLife enemy = hit.GetComponent<enemyLife>();
        if (enemy != null)
        {
            enemy.Dano(40);
        }
        Destroy(gameObject);
    }

}
