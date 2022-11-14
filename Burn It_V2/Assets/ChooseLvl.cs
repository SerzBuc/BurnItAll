using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLvl : MonoBehaviour
{
    public int lvl;
    public Text lvlText;

    private void Start()
    {
        lvlText.text = lvl.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Level_" + lvl.ToString());
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene(0);
    }
}

