using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameButton;
    [SerializeField]
    private GameObject menuButton;
    [SerializeField]
    private GameObject dogInFront;
    [SerializeField]
    private AnimStart animStart;
    [SerializeField]
    private GameObject dogInTarget;
    [SerializeField]
    private GameObject healthBar;
    [SerializeField]
    private GameObject energyBar;
    public void Start()
    {
        menuButton.SetActive(true);
        gameButton.SetActive(false);
        dogInFront.SetActive(true);
        animStart.Start();
        dogInTarget.SetActive(false);
        healthBar.SetActive(false);
        energyBar.SetActive(false);
        //PlayGame();
    }
   public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        gameButton.SetActive(true);
        menuButton.SetActive(false);
        dogInFront.SetActive(false);
        dogInTarget.SetActive(true);
        healthBar.SetActive(true);
        energyBar.SetActive(true);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
