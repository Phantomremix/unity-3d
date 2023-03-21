using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    InputMaster inputMaster;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if(inputMaster == null)
        {
            inputMaster = new InputMaster();

            inputMaster.Player.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        inputMaster.Enable();
    }

    private void OnDisable()
    {
        inputMaster.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
