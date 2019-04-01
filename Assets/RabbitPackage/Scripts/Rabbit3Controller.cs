using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit3Controller : MonoBehaviour
{

    float speed = 4;
    float rotSpeed = 80;
    float gravity = 8;


    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindWithTag("Carrot_Rabit").GetComponentInChildren<Animator>();
        animator = GameObject.FindWithTag("Eating_Rabit").GetComponent<Animator>();
        controller = GameObject.FindWithTag("Eating_Rabit").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveDir = new Vector3(0, 0, 1);
            moveDir *= speed;

           // animator.SetBool("jack", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            moveDir = new Vector3(0,0,0);
            moveDir *= speed;
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
