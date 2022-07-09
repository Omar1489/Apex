using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectsLevels : MonoBehaviour
{
    public Dropdown effectsDrop;
    // Start is called before the first frame update
    void Start()
    {
        effectsDrop.onValueChanged.AddListener(delegate
        {
            effectsDropValueChangedHappened(effectsDrop);
        });
    }
    public void effectsDropValueChangedHappened(Dropdown sender)
    {
        Debug.Log(effectsDrop.options[effectsDrop.value].text);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
