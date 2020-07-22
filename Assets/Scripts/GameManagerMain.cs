using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMain : MonoBehaviour
{
    [SerializeField]
    private float characterSpeed = 3.0f;

    public float GetCharacterSpeed()
    {
        return characterSpeed;
    }

    public void SetCharacterSpeed(float newSpeed)
    {
        characterSpeed = newSpeed;
    }
}
