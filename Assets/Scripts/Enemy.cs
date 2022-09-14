using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float timer = 2.5f;
    public GameObject eProjectile;
    public GameObject eProjectileClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireEnemyProjectile();
    }

    void fireEnemyProjectile()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            eProjectileClone = Instantiate(eProjectile, new Vector3(transform.position.x, transform.position.y - 0.8f), transform.rotation) as GameObject;
            Destroy(eProjectileClone, 2.5f);
            timer = 2.5f;
        }
    }
}
