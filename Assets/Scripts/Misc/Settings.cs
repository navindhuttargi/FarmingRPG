﻿using UnityEngine;

public static class Settings 
{
    public static float runningSpeed = 5.333f;
    public static float walkingSpeed = 2.666f;

    public static int xInput;
    public static int yInput;
    public static int isWalking; 
    public static int isRunning;
    public static int isIdle;
    public static int carring;
    public static int toolEffect;
    public static int isUsingToolRight; 
    public static int isUsingToolLeft; 
    public static int isUsingToolUp; 
    public static int isUsingToolDown;
    public static int isLiftingToolRight; 
    public static int isLiftingToolLeft; 
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isPickingRight; 
    public static int isPickingLeft; 
    public static int isPickingUp; 
    public static int isPickingDown;
    public static int isSwingingToolRight;
    public static int isSwingingToolLeft; 
    public static int isSwingingToolUp; 
    public static int isSwingingToolDown;

    public static int idleRight;
    public static int idleLeft;
    public static int idleUp;
    public static int idleDown;

    static Settings()
    {
        xInput=Animator.StringToHash("xInput");
        yInput = Animator.StringToHash("yInput");
        isWalking = Animator.StringToHash("isWalking");
        isRunning = Animator.StringToHash("isRunning");
        isIdle= Animator.StringToHash("isIdle");
        carring = Animator.StringToHash("carring");
        toolEffect = Animator.StringToHash("toolEffect");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isUsingToolUp = Animator.StringToHash("isUsingToolUp");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingLeft = Animator.StringToHash("isPickingLeft");
        isPickingUp = Animator.StringToHash("isPickingUp");
        isPickingDown = Animator.StringToHash("isPickingDown");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");

        idleRight = Animator.StringToHash("idleRight");
        idleLeft = Animator.StringToHash("idleLeft");
        idleUp = Animator.StringToHash("idleUp");
        idleDown = Animator.StringToHash("idleDown");
    }
}
