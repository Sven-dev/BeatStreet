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

    private Direction CurrentDirection = Direction.None;

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
        //Get the x and y values from the stick
        Vector2 stick = controls.Player.LeftStick.ReadValue<Vector2>();

        //Round the values to 1 decimal
        stick.x = Mathf.Round(stick.x * 10.0f) * 0.1f;
        stick.y = Mathf.Round(stick.y * 10.0f) * 0.1f;

        if (stick == Vector2.zero)
        {
            CurrentDirection = Direction.None;
            return;
        }

        float angle = Mathf.Atan2(stick.y, stick.x) * Mathf.Rad2Deg;
        Direction direction = ReadStick(angle);

        //If the value is different from the last value, check if a new input is being triggered
        if (direction != CurrentDirection)
        {
            NewDirection(direction);
            CurrentDirection = direction;
        }      
    }

    private Direction ReadStick(float angle)
    {      
        if (angle > -22.5f && angle < 22.5f)
        {
            //Right
            return Direction.Right;
        }

        else if (angle > 22.5f && angle < 67.5f)
        {
            //Up-right
            return Direction.UpRight;
        }
        else if (angle > 67.5f && angle < 112.5f)
        {
            //Up
            return Direction.Up;
        }
        else if (angle > 112.5f && angle < 157.5f)
        {
            //Up-left
            return Direction.UpLeft;
        }

        else if (angle < -22.5f && angle > -67.5f)
        {
            //Down-right
            return Direction.DownRight;
        }
        else if (angle < -67.5f && angle > -112.5f)
        {
            //Down
            return Direction.Down;
        }
        else if (angle < -112.5f && angle > -157.5f)
        {
            //Down-left
            return Direction.DownLeft;
        }

        else if (angle > 157.5f && angle <= 180f || angle < -157.5f && angle >= 180f)
        {
            //Left
            return Direction.Left;
        }

        return Direction.None;
    }

    private void NewDirection(Direction direction)
    {
        switch (direction)
        {
            case Direction.Right:
                OnDirectionRight.Invoke();
                break;
            case Direction.UpRight:
                OnDirectionUpRight.Invoke();
                break;
            case Direction.Up:
                OnDirectionUp.Invoke();
                break;
            case Direction.UpLeft:
                OnDirectionUpLeft.Invoke();
                break;
            case Direction.DownRight:
                OnDirectionDownRight.Invoke();
                break;
            case Direction.Down:
                OnDirectionDown.Invoke();
                break;
            case Direction.DownLeft:
                OnDirectionDownLeft.Invoke();
                break;
            case Direction.Left:
                OnDirectionLeft.Invoke();
                break;
        }
    }

    private void Punch(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnPunch.Invoke();
    }

    private void Kick(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnKick.Invoke();
    }
}

public enum Direction
{
    None,
    Right,
    UpRight,
    Up,
    UpLeft,
    DownRight,
    Down,
    DownLeft,
    Left
}