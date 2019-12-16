using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStart : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    public void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Play", -1, 0f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
