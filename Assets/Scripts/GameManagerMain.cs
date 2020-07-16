using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMain : MonoBehaviour
{
    float characterSpeed = 3.0f;

    public float getCharacterSpeed()
    {
        return characterSpeed;
    }

    public void setCharacterSpeed(float newSpeed)
    {
        characterSpeed = newSpeed;
    }
}
