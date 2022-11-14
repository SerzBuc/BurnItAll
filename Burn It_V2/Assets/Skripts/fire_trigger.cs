using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fire_trigger : MonoBehaviour
{
    public Finish finish;
    [SerializeField] TNT tnt;
    public PlayerMove playerMove;
    [SerializeField] GameMnager gameMnager;
    public Transform[] gus_points;
    public int currentPoint ;
    public float def_speed;
    public bool pause = false;
    

    private void Start()
    {
        gameMnager = FindObjectOfType<GameMnager>();
        currentPoint = 0;
        tnt = FindObjectOfType<TNT>();
    }

    private void Update()
    {
        if (finish.fire_move == true)
        {
            playerMove.enabled = false;
            transform.position = Vector3.MoveTowards(transform.position, gus_points[currentPoint].position, def_speed);
            if (Vector3.Distance(transform.position, gus_points[currentPoint].position) < 0.2f)
            {
                currentPoint++;
                if(currentPoint >= gus_points.Length)
                {
                    currentPoint = 0;
                    Pause();
                   
                }
            }
        }
    }

    public void Pause()
    {
        gameMnager.PauseWinStart();
        def_speed = 0;
       
    }

}
