using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    InputAction moveAction;

    [HideInInspector] public Vector2 moveVector;

    void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    public void GetInput()
    {
        moveVector = moveAction.ReadValue<Vector2>();
    }

    void Update()
    {
        GetInput();
    }
}

