using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSome : MonoBehaviour
{
   public void ZeroScore()
    {
        PlayerPrefs.SetInt("Money", 0);
    }

    public void ZeroLEvels()
    {
        PlayerPrefs.SetInt("levelAt", 2);
    }
}
