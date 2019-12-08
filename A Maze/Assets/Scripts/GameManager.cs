using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public bool gameOver = false;
    public bool finished = false;
    private Rigidbody playerRb;
    public bool isGameActive;
    private GameManager gameManager;
    public TextMeshProUGUI finishedText;
    public Button restartButton;
    public Button restartButton2;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            GameOver();
            gameOver = true;
        }
        if (collision.gameObject.CompareTag("Finish Line"))
        {
            Debug.Log("Finished");
            Finished();
            finished = true;
        }
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }
    public void Finished()
    {
        restartButton2.gameObject.SetActive(true);
        finishedText.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
