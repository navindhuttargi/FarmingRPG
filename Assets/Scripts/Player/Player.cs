using System;
using UnityEngine;

public class Player : SingletonMonobehaviour<Player>
{

    private float inputX;
    private float inputY;
    private bool carring = false;
    private bool isIdle;
    private bool isWalking;
    private bool isRunning;
    private bool isUsingToolRight;
    private bool isUsingToolLeft;
    private bool isUsingToolUp;
    private bool isUsingToolDown;
    private bool isLiftingToolRight;
    private bool isLiftingToolLeft;
    private bool isLiftingToolUp;
    private bool isLiftingToolDown;
    private bool isPickingToolRight;
    private bool isPickingToolLeft;
    private bool isPickingToolUp;
    private bool isPickingToolDown;
    private bool isSwingingToolRight;
    private bool isSwingingToolLeft;
    private bool isSwingingToolUp;
    private bool isSwingingToolDown;
    private ToolEffect toolEffect;

    private Rigidbody2D rigidbody2D;

    private PlayerDirection playerMovementDirection;

    private float movementSpeed;
    protected override void Awake()
    {
        base.Awake();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        ResetTriggerAnimation();
        PlayerMovementInput();
        PlayerWalkInput();
        EventHandler.CallMovementEvent(inputX, inputY, isWalking, isRunning, isIdle, carring, toolEffect,
                                     isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
                                     isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
                                     isPickingToolRight, isPickingToolLeft, isPickingToolUp, isPickingToolDown,
                                     isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
                                     false, false, false, false);
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 moveVector = new Vector2(inputX * movementSpeed * Time.deltaTime, inputY * movementSpeed * Time.deltaTime);
        rigidbody2D.MovePosition(rigidbody2D.position + moveVector);
    }
    private void ResetTriggerAnimation()
    {
        isUsingToolRight = false;
        isUsingToolLeft = false;
        isUsingToolUp = false;
        isUsingToolDown = false;
        isLiftingToolRight = false;
        isLiftingToolLeft = false;
        isLiftingToolUp = false;
        isLiftingToolDown = false;
        isPickingToolRight = false;
        isPickingToolLeft = false;
        isPickingToolUp = false;
        isPickingToolDown = false;
        isSwingingToolRight = false;
        isSwingingToolLeft = false;
        isSwingingToolUp = false;
        isSwingingToolDown = false;
        toolEffect = ToolEffect.nothing;
    }

    private void PlayerMovementInput()
    {
        inputY = Input.GetAxisRaw("Vertical");
        inputX = Input.GetAxisRaw("Horizontal");

        if (inputY != 0 && inputX != 0)
        {
            inputX = inputX * .71f;
            inputY = inputY * .71f;
        }

        if (inputX != 0 || inputY != 0)
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;

            if (inputX < 0)
            {
                playerMovementDirection = PlayerDirection.left;
            }
            else if (inputX > 0)
            {
                playerMovementDirection = PlayerDirection.right;
            }
            if (inputX < 0)
            {
                playerMovementDirection = PlayerDirection.down;
            }
            else if (inputY > 0)
            {
                playerMovementDirection = PlayerDirection.up;
            }
        }
        else if (inputX == 0 && inputY == 0)
        {
            isRunning = false;
            isWalking = false;
            isIdle = true;
        }
    }
    private void PlayerWalkInput()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            isRunning = false;
            isWalking = true;
            isIdle = false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            isRunning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runningSpeed;
        }
    }
}
