using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamelauncherscript : MonoBehaviour
{
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animation>();
        ;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    void Fire()
    {

        anim.Play("fire");
    }
    void Reload()
    {
        anim["reload"].speed = 2.0f;
        anim.Play("reload");
    }
}
