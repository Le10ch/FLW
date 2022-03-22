using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Attack : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 1;
    public Rigidbody2D rb;

    private bool FireShildeC1;
    private bool LightningShildeC1;
    private bool WaterShildeC1;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {   
        FireShildeC1 = ButtonIsPress.FireShilde1;
        LightningShildeC1 = ButtonIsPress.LightningShilde1;
        WaterShildeC1 = ButtonIsPress.WaterShilde1;

        Enamy objj = hitInfo.GetComponent<Enamy>();

        if(objj != null)
        {
            if(gameObject.tag == "FireAttack")
            {
                if(WaterShildeC1 == true)
                {
                    ButtonIsPress.WaterShilde1 = false;
                    WaterShildeC1 = false;
                    Destroy(gameObject);
                }
                else if(FireShildeC1 == true)
                {

                    Destroy(gameObject);
                }
                else
                {
                objj.TakeDamage(damage);
                Destroy(gameObject);
                }
            }
            if(gameObject.tag == "WaterAttack")
            {
                if(LightningShildeC1 == true)
                {

                    ButtonIsPress.LightningShilde1 = false;
                    LightningShildeC1 = false;
                    Destroy(gameObject);
                }
                else if(WaterShildeC1 == true)
                {

                    Destroy(gameObject);
                }
                else
                {
                objj.TakeDamage(damage);
                Destroy(gameObject);
                }
            }
            if(gameObject.tag == "LightningAttack")
            {   
                if(FireShildeC1 == true)
                {
                    ButtonIsPress.FireShilde1 = false;
                    FireShildeC1 = false;
                    Destroy(gameObject);
                }
                else if(LightningShildeC1 == true)
                {

                    Destroy(gameObject);
                }
                else
                {
                objj.TakeDamage(damage);
                Destroy(gameObject);
                }
            }
        }

    }

}
