using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CodeMonkey.Utils;

public class GameHandle : MonoBehaviour
{
    [SerializeField]
    private ControlBar energyBar;
    [SerializeField]
    private ControlBar healthBar;
    [SerializeField]
    private AnimControl animControl;
    [SerializeField]
    private overMenu gameOverMenu;
    [SerializeField]
    private MainMenu mainMenu;
    public float health, energy;
    public float healthIndex, energyIndex;
    public float step;

    // Start is called before the first frame update
    private void Start()
    {
        health = 1f;
        energy = 1f;
        healthBar.SetSize(health);
        energyBar.SetSize(energy);
        healthIndex = 0;
        energyIndex = 0;
        step = .001f;
        /*FunctionPeriodic.Create(() => {
            if (health > 0)
            {
                health -= .01f;
                controlBar.SetSize(health);
            }
        }, .10f);*/

    }

    void Update()
    {
        progress();
        checkBar();
    }

    
    void Awake()
    {
       
    }
    public void checkBar()
    {
        if (health == 0 || energy==0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            health = 0;
            energy = 0;
            animControl.gameOver();
            gameOverMenu.gameOver();
        }
    }
    public void startOver()
    {
        gameOverMenu.Start();
        Start();
        mainMenu.Start();
    }

    public void updateHealth(float h)
    {
        healthIndex = h * step;
    }

    public void updateEnergy(float e)
    {
        energyIndex = e * step;
    }

    public void progress()
    {
        /*
        if (healthIndex == 1)
        {
            if (health < 1f) health += .001f;
        } else if (healthIndex == 0)
        {
            if (health > 0) health -= .001f;
        }

        healthBar.SetSize(health);

        if (energyIndex == 1)
        {
            if (energy < 1f) energy += .001f;
        }
        else if (energyIndex == 0)
        {
            if (energy > 0) energy -= .001f;
        }
        */
        health += healthIndex;
        if (health > 1f) health = 1f;
        if (health < 0) health = 0;

        energy += energyIndex;
        if (energy > 1f) energy = 1f;
        if (energy < 0) energy = 0;

        energyBar.SetSize(energy);
        healthBar.SetSize(health);
    }

}
