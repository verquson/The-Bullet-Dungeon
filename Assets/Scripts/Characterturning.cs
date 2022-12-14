using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class Characterturning : MonoBehaviour
{
    //annetaan dataa 
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float gravityValue = -9f;
    [SerializeField] private float controllerDeadzone = 0.1f;
    [SerializeField] private float gamepadRotateSmoothing = 1000f;

    [SerializeField] private bool isGamepad;

    private CharacterController controller;
    //kerrotaan mit? inputteja halutaan tekem??n mit?kin toimintaa
    private Vector2 movement;
    private Vector2 aim;
    

    private Vector3 playervelocity;

    private PlayerControls playerControls;

    private PlayerInput playerInput;

    [HideInInspector]
    public bool canMove = true;

    //etsit??n pelaajan inputit input managerist?
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerControls = new PlayerControls();
        playerInput = GetComponent<PlayerInput>();
        GameManager.Instance.Player = this.gameObject;
        GameManager.Instance.Playercontroller = this;
    }

    //ottaa kontrollit p??lle ja pois
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }

    //ottaa alhaalla olevat s??d?t p??lle
    void Update()
    {
        HandleInput();
        HandleMovement();
        HandleRotation();
      
    }

    //s??t?? inputit
    void HandleInput()
    {
        movement = playerControls.Controls.Movement.ReadValue<Vector2>();
        aim = playerControls.Controls.Aim.ReadValue<Vector2>();
       
    }

    //s??t?? liikkumisen
    void HandleMovement()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        playervelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playervelocity * Time.deltaTime);
    }

 
    //s??t?? k??nn?n
    void HandleRotation()
    {
        if (isGamepad)
        {
            if (Mathf.Abs(aim.x) > controllerDeadzone || Mathf.Abs(aim.y) > controllerDeadzone)
            {
                Vector3 playerDirection = Vector3.right * aim.x + Vector3.forward * aim.y;
                if (playerDirection.sqrMagnitude > 0.0f)
                {
                    Quaternion newrotation = Quaternion.LookRotation(playerDirection, Vector3.up);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, newrotation, gamepadRotateSmoothing * Time.deltaTime);
                }
            }
        }
        else
        {
            Ray ray =  Camera.main.ScreenPointToRay(aim);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                Vector3 point = ray.GetPoint(rayDistance);
                LookAt(point);
            }
        }
    }

    //s??t?? t?ht??mist?
    private void LookAt(Vector3 lookPoint)
    {
        Vector3 heightCorrectedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt(heightCorrectedPoint);
    }

    //vaihtaa ohjainkontrolleihin vaihdossa
    public void OnDeviceChange (PlayerInput pi)
    {
        isGamepad = pi.currentControlScheme.Equals("Gamepad") ? true : false;
    }

   
}
