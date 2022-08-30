using UnityEngine;
using System.Collections;

public class example : MonoBehaviour
{
   
    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
       
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }
        controller.Move(moveDirection * Time.deltaTime);
    }
}
