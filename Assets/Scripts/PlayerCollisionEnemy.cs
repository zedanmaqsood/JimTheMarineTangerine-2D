using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionEnemy : MonoBehaviour
{
    int lives = 0;
    [SerializeField] GameObject gameOverMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GoodGuys" || collision.gameObject.tag == "GoodBullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            if (lives < 1)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
    }
}
