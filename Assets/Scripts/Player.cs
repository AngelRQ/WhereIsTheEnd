using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Animator animator;
    public int life = 2;
    public float jumpForce;
    private bool isGrounded;
    public Rigidbody2D rigidbody2D;
    public GameObject lifesPanel;
    public Text tiempo;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     animator.SetBool("isJumping", true);
        //     rigidbody2D.AddForce(new Vector2(0, jumpForce));
        // }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("estaSaltando");
            Jump();
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision) {
    //     if(collision.gameObject.tag == "Piso")
    //     {
    //         animator.SetBool("isJumping", false);
    //     }
    // }

    private void Jump()
    {
        animator.SetBool("isJumping", true);
        rigidbody2D.AddForce(Vector2.up * jumpForce);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.name == "Detector suelo")
        {
            isGrounded = true;
            animator.SetBool("isJumping", false);
        }

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.name == "Detector suelo") isGrounded = false;
    }




    public void Death()
    {
        float contador = 0;

        if (life <= 1)
        {
            SceneManager.LoadScene("Perdida");

            tiempo.text = "" + contador.ToString("f1");
            life = 2;


            for (int i = 0; i < lifesPanel.transform.childCount; i++)
            {
                lifesPanel.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

    }

    public void Hit()
    {
        if (life >= 1)
        {
            lifesPanel.transform.GetChild(life).gameObject.SetActive(false);
            life -= 1;
        }
        else
        {
            Death();
        }
    }




}
