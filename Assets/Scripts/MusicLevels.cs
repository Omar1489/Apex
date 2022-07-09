using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicLevels : MonoBehaviour
{

    public Dropdown musicDrop;
    // Start is called before the first frame update
    void Start()
    {
         musicDrop.onValueChanged.AddListener(delegate
        {
            musicDropValueChangedHappened(musicDrop);
        });
    }
    public void musicDropValueChangedHappened(Dropdown sender)
    {
        Debug.Log(musicDrop.options[musicDrop.value].text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
