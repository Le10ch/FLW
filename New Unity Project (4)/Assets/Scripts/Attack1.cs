using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Attack1 : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 1;
    public Rigidbody2D rb;

    private bool FireShildeC;
    private bool LightningShildeC;
    private bool WaterShildeC;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {   
        FireShildeC = ButtonIsPress.FireShilde;
        LightningShildeC = ButtonIsPress.LightningShilde;
        WaterShildeC = ButtonIsPress.WaterShilde;

        Player objj2 = hitInfo.GetComponent<Player>();

        if (objj2 !=null)
        {
            if(gameObject.tag == "FireAttack")
            {
                if(WaterShildeC == true)
                {
                    ButtonIsPress.WaterShilde = false;
                    WaterShildeC = false;
                    Destroy(gameObject);
                }
                else if(FireShildeC == true)
                {
                    Destroy(gameObject);
                }
                else
                {
                objj2.TakeDamage1(damage);
                Destroy(gameObject);
                }
            }
            if(gameObject.tag == "WaterAttack")
            {
                if(LightningShildeC == true)
                {
                    ButtonIsPress.LightningShilde = false;
                    LightningShildeC = false;
                    Destroy(gameObject);
                }
                else if(WaterShildeC == true)
                {
                    Destroy(gameObject);
                }
                else
                {
                objj2.TakeDamage1(damage);
                Destroy(gameObject);
                }
            }
            if(gameObject.tag == "LightningAttack")
            {   
                if(FireShildeC == true)
                {
                    ButtonIsPress.FireShilde = false;
                    FireShildeC = false;
                    Destroy(gameObject);
                }
                else if(LightningShildeC == true)
                {
                    Destroy(gameObject);
                }                
                else
                {
                objj2.TakeDamage1(damage);
                Destroy(gameObject);
                }
            }

        } 

    }

}
