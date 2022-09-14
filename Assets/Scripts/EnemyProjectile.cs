using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private float eProjSpeed = -3.0f;
    public GameObject eProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, eProjSpeed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(eProjectile);
            if (GameManager.lives > 0)
            {
                collision.gameObject.transform.position = new Vector3(0, -4.17f, 0);
                GameManager.damage = true;
            } else
            {
                Destroy(collision.gameObject);
                GameManager.playGame = false;
            }
            
        }
    }
}
