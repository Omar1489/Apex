using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Back()
    {
        SceneManager.LoadScene("Options");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
