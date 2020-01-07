using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody EnemyRb;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        // Selecteerd de rigidbody van enemy
        EnemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(lookDirection * speed);
        
        // Enemy destroyen wanneer hij lager dan -10 valt (van het platform af)
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
