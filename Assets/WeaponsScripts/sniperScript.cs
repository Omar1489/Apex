using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperScript : MonoBehaviour
{
    private Animation anim;
    public float damage = 85f;
    public float fireRate = 1f;
    public float ammo = 6f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    private float nextTimeToFire = 0f;
    public int maxAmmo = 150;
    private int currentAmmo = 0;
    public float reloadTime = 2.3f;
    private bool isReloading = false;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
 

        currentAmmo = maxAmmo;

    }
    void OnEnable()
    {
        isReloading = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isReloading)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }

    }

    void Fire()
    {
        muzzleFlash.Play();
        currentAmmo -= 1;
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            enemyCapsule target = hit.transform.GetComponent<enemyCapsule>();
            if (target != null)
            {
                target.takeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * 30);
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;


    }

}
