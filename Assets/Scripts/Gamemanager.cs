using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private GameObject startGameCanvas;
    [SerializeField] private GameObject gameoverCanvas;
    [SerializeField] private GameObject pipeSpawner;
    [SerializeField] private Player player;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        startGameCanvas.SetActive(false);
        pipeSpawner.SetActive(true);
        player.GetComponent<Rigidbody>().useGravity = true;
    }

    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
