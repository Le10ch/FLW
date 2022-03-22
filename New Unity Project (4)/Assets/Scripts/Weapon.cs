using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint1;
    public Transform firePoint2;
    public GameObject Attack;
    public GameObject Attack1;
    public GameObject Attack2;
    
    public float fireRate = 1f;
    public float nextFire = 0f;

    public void Shoot()
    {
        {   
            nextFire = Time.time + fireRate;
            Instantiate(Attack, firePoint.position,firePoint.rotation);
        }
    }
    public void Shoot1()
    {
        {   
            nextFire = Time.time + fireRate;
            Instantiate(Attack1, firePoint1.position,firePoint1.rotation);
        }
    }
    public void Shoot2()
    {
        {   
            nextFire = Time.time + fireRate;
            Instantiate(Attack2, firePoint2.position,firePoint2.rotation);
        }
    }
}
