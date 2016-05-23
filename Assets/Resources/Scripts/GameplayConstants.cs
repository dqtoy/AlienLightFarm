﻿using UnityEngine;
using System.Collections;

public class GameplayConstants {

    public const float AlienFullLiveTime = 10f;
    public const float AlienMaxWaitTime = 3f;
    public const float AlienMinWaitTime = 1f;
    public const float AlienNormalSpeed = 20f;
    public const float AlienHungrySpeed = 40f;

    public const int AlienStartBorningCount = 3;


    // Скорость появления алиенов
    public const float AlienBornTime = 2f;
    public const float AlienBorningDelay = 1.1f;



    public static float[] FountainButtonReloadTime = { 2f, 5f, 16f };
    public static int[] FountainTresholdI = {1,8,12};
    public const float WallButtonReloadTime = 1f;
    public const float SafeCupolButtonReloadTime = 1f;



    public const float FountainMaxLife = 210f;
    public const float FountainMinLife = 20f;

    public const float FountainGrowCoef = 1.5f;
    public const float FountainRecoveryCoef = 3f;

    public const float WallLifeTime = 7f;
    public const float SafeCupolLifeTime = 7f;

    public const float BlackHoleClosedSpeed = 1f;

    public const float AlienCoefRateFountain = 3f;
    // public const float FountainCoefRestitution = 8f;

    public const int MaxAgro = 100;
    public const float AgroCoef = 3f;
    public const float RecoveryAgroCoef = 4f;


    public const int FountainTreshold = 0;
    public const int WallTreshold = 90;
    public const int SafeCupolTreshold = 10;
    public const int BlackHoleTreshold = 25;
    public const int PusherTreshold = 15;

    public const int PusherRange = 3;
    public const float PusherExpansionSpeed = 5f;

    public const float ExpulsionAlienSpeed = 7f;

    public const float LentaReloadTime = 3f;
}