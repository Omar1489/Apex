using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadelauncherScript : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        ;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("firing", true);
            anim.SetBool("walking", false);
            anim.SetBool("reloading", false);
            Fire();
            
        }
        else if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("RRRRRRRRRRRRRR");
            anim.SetBool("firing", false);
            anim.SetBool("walking", false);
            anim.SetBool("reloading", true);
            Reload();

        }
        else
        {
            anim.SetBool("firing", false);
            anim.SetBool("walking", true);
            anim.SetBool("reloading", false);
        }
    }

    void Fire()
    {
       
        anim.Play("fire");
    }
    void Reload()
    {
        //anim["reload"].speed = 2.0f;
        //anim.Play("reload");
    }

}
