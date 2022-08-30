using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class Characterturning : MonoBehaviour
{
    [Serializefield] private float playerspeed = 5f;
    [Serializefield] private float gravityvalue = -9f
    [Serializefield] private float controllerdeadzone = 0.1f;
    [Serializefield] private float gamepadrotatesmoothing = 1000f;

    [Serializefield] private bool isGamepad

    private CharacterController controller;

    private vector2 movement;
    private vector2 aim;

    private vector3 playervelocity;

    private PlayerControls playerControls;

    private PlayerInput playerInput;

    private void Awake()
    {
        controller = Getcomponent<CharacterController>();
        playerControls = new PlayerControls();
        playerInput = GetComponent<playerInput>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }

  
    void Update()
    {
        HandleInput();
        HandleMovement();
        HandleRotation();
    }
    void HandleInput()
    {
        movement = playerControls.Controls.Movement.ReadValue<Vector2>();
        aim = playerControls.Controls.Aim.ReadValue<Vector2>();
    }
    void HandleMovement()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y);
        controller.Move(move * Time.delTime * playerspeed);

        playervelocity.y += gravityvalue * Time.deltatime;
        controller.Move(playervelocity * Time.deltaTime);
    }
    void HandleRotation()
    {

    }




}
