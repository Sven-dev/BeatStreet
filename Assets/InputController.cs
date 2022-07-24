using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
 
 public class InputController : MonoBehaviour
{
    // this is the class associated with the action map
    private Inputs controls = null;

    [SerializeField] private UnityEvent OnDirectionRight;
    [SerializeField] private UnityEvent OnDirectionLeft;
    [SerializeField] private UnityEvent OnDirectionUp;
    [SerializeField] private UnityEvent OnDirectionDown;
    [Space]
    [SerializeField] private UnityEvent OnDirectionDownRight;
    [SerializeField] private UnityEvent OnDirectionDownLeft;
    [SerializeField] private UnityEvent OnDirectionUpRight;
    [SerializeField] private UnityEvent OnDirectionUpLeft;
    [Space]
    [SerializeField] private UnityEvent OnPunch;
    [SerializeField] private UnityEvent OnKick;

    private Vector2 StickDelta = Vector2.zero;

    private void Awake()
    {
        controls = new Inputs();
    }

    private void Start()
    {
        // setup event handlers
        controls.Player.Punch.started += Punch;   // key down event
        controls.Player.Kick.started += Kick;   // key down event
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        Vector2 stick = controls.Player.LeftStick.ReadValue<Vector2>();
        if (stick != StickDelta)
        {
            ReadStick(stick);
        }

        StickDelta = stick;
    }

    private void ReadStick(Vector2 stick)
    {
        if (stick == new Vector2(1, 0))
        {
            print("DirectionRight");
            OnDirectionRight.Invoke();
        }
        else if (stick == new Vector2(-1, 0))
        {
            print("DirectionLeft");
            OnDirectionLeft.Invoke();
        }
        else if (stick == new Vector2(0, 1))
        {
            print("DirectionUp");
            OnDirectionUp.Invoke();
        }
        else if (stick == new Vector2(0, -1))
        {
            print("DirectionDown");
            OnDirectionDown.Invoke();
        }
        else if (stick == new Vector2(0.707107f, -0.707107f))
        {
            print("DirectionDownRight");
            OnDirectionDownRight.Invoke();
        }
        else if (stick == new Vector2(-0.707107f, -0.707107f))
        {
            print("DirectionDownLeft");
            OnDirectionDownLeft.Invoke();
        }
        else if (stick == new Vector2(0.707107f, 0.707107f))
        {
            print("DirectionUpright");
            OnDirectionUpRight.Invoke();
        }
        else if (stick == new Vector2(-0.707107f, 0.707107f))
        {
            print("DirectionUpleft");
            OnDirectionUpLeft.Invoke();
        }
    }

    private void Punch(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        print("Punch");
        OnPunch.Invoke();
    }

    private void Kick(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        print("Kick");
        OnKick.Invoke();
    }
}