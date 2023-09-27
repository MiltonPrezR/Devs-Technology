using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float horizontalMov = 0;

    [SerializeField] private float runSpeedHorizontal = 3;
    [SerializeField] private float runSpeed = 0;

    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private Animator animator;
    [SerializeField] private Joystick joystick;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (joystick.Horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            //animator.SetBool("running", true);
            animator.SetBool("isRun", true);
        }
        else if (joystick.Horizontal > 0.0f)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            //animator.SetBool("running", true);
            animator.SetBool("isRun", true);
        }
        else
        {
            //animator.SetBool("running", false);
            animator.SetBool("isRun", false);
        }

        horizontalMov = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3(horizontalMov, 0, 0) * Time.deltaTime * runSpeed;
    }
}
