using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    NewBehaviourScript inputMaster;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        inputMaster = GetComponent<NewBehaviourScript>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }
    private void Update()
    {
        inputMaster.HandleAllInputs();
    }
    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }
}
