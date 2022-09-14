using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives;
    public GameObject[] hearts;
    public static bool playGame = true;
    public static bool damage = false;
    public Image gOver, gWin;
    // Start is called before the first frame update
    void Start()
    {
        lives = hearts.Length;
        gOver.enabled = false;
        gWin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playGame)
        {
            gOver.enabled = true;
        } else
        {
            if (damage)
            {
                Damage();
            }
            if (GameObject.Find("Enemy(Clone)") == null)
            {
                gWin.enabled = true;
            }
        }
    }

    void Damage()
    {
        lives--;
        Destroy(hearts[lives].gameObject);
        damage = false;
    }
}
