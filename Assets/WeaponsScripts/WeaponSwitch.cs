using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    private string primary = "Rifle";
    private string secondary = "GrenadeLauncher";
    private bool holdingprimary = false;
    private bool holdingweapon = true;
    private int maxPrimaryAmmoCapacity = 150;
    private int TotalPrimaryAmmo = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("test");
            holdingprimary = true;
            SelectWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            holdingprimary = false;
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        foreach(Transform weapon in transform)
        {
            if (!holdingweapon)
            {
                return;
            }
            if(holdingprimary & weapon.gameObject.tag == primary)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                if (!holdingprimary & weapon.gameObject.tag == secondary)
                {
                    weapon.gameObject.SetActive(true);
                }
                else
                {
                    weapon.gameObject.SetActive(false);
                }
            }

        }
    }
}
