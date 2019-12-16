using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    [SerializeField]
    private GameObject foodTray;
    [SerializeField]
    private GameObject bathTub;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        foodTray.SetActive(false);
        bathTub.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver()
    {
        anim.Play("Sleep", -1, 0f);
    }

    public void animate(string action)
    {
        GameObject obj = null;
        switch(action)
        {
            case "Eat":
                obj = foodTray;
                break;
            case "Bath":
                obj = bathTub;
                break;
            default:
                obj = null;
                break;
        }

        anim.Play(action, -1, 0f);
        disableObject();
        if (obj != null)
        {
            obj.SetActive(true);
        }
    }
   
    private void disableObject()
    {
        foodTray.SetActive(false);
        bathTub.SetActive(false);
    }
}
