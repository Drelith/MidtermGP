using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCon : MonoBehaviour
{
    private CharacterController charControl;
    public float rotateSpeed = 125;
    public Animator animator;

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        rotation = rotation * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);


        float moveDir = Input.GetAxis("Vertical");
        moveDir = moveDir * moveSpeed * Time.deltaTime;
        Vector3 moveOffset = transform.forward;
        moveOffset = moveOffset * moveDir;
        charControl.Move(moveOffset);
        animator.SetFloat("MoveSpeed", Input.GetAxis("Vertical"));
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
