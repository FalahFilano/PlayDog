using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameMenu;
    [SerializeField]
    private GameObject menuOver;
    // Start is called before the first frame update
    public void Start()
    {
        menuOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameMenu.SetActive(false);
        menuOver.SetActive(true);
    }
}
