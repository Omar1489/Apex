using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    bool paused = false;
    public AudioSource pauseAudio;


    // Start is called before the first frame update
    void Start()
    {
        pauseAudio.Stop();
        if (AudioListener.volume > 0f)
        {
            pauseAudio.ignoreListenerPause = true;
        }

    }



public void Escape()
    {
        paused = !paused;
        if (paused == true)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (AudioListener.volume <= 0f)
        {
            paused = true;
            pauseAudio.Play();
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            paused = true;
            AudioListener.pause = true;
            pauseAudio.Play();
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void Resume()
    {
        if (AudioListener.volume <= 0f)
        {
            paused = false;
            pauseAudio.Stop();
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            paused = false;
            pauseAudio.Stop();
            AudioListener.pause = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

    }
    public void Restart()
    {
        AudioListener.pause = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Playground");
    }

    public void MainMenu()
    {
        AudioListener.pause = false;
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Escape();

        }
    }
}
