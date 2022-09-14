using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 2.5f;
    private float timer = 0.25f;
    private int enemies = 1;
    public GameObject Enemy;
    public GameObject EnemyClone;
    public GameObject Projectile;
    public GameObject ProjectileClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            movement();
            fireProjectile();
            EnemiesCount();
        }
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * -1 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }

    void fireProjectile()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ProjectileClone = Instantiate(Projectile, new Vector3(transform.position.x, transform.position.y + 0.8f), transform.rotation) as GameObject;
            Destroy(ProjectileClone, 3);
            timer = 0.25f;
        }
    }

    void EnemiesCount()
    {
        if (enemies < 10)
        {
            EnemyClone = Instantiate(Enemy, new Vector3(Random.Range(-3, 3), Random.Range(2, 5)), Enemy.transform.rotation) as GameObject;
            enemies++;
        }
    }
}
