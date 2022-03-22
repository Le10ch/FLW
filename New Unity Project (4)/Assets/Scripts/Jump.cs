using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{   
    Rigidbody2D rb;
    public bool ReadyJump, ReadyGround;
    public int ForceJump;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {   
        if(ReadyJump && ReadyGround)
        {
            anim.SetBool("IsAreaCasting",true);
            rb.AddForce(new Vector2(0 , ForceJump));
            ReadyJump = false;
            ReadyGround = false;
        }
        else
        {
            anim.SetBool("IsAreaCasting",false);
        }
    }

    public void JumpPlayer()
    {
        ReadyJump = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ReadyGround = true;
        }
        else
        {   
            ReadyGround = false;
        }
    }
}
