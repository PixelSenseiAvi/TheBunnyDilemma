using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Pause : MonoBehaviour
{
    public bool IsPaused;
    public float playedTime;
    private int count;

    public float slowdownFactor = 0.05f;
    public float slowdownLength = 2f;


    // Start is called before the first frame update
    void Start()
    {
        //pd = brute.GetComponent<PlayableDirector>();
        IsPaused = false;
        playedTime = 0.0f;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        playedTime += Time.deltaTime;
        //playable.GetGraph().GetRootPlayable(0).GetTime(). 

        //implement a better solution
        if (playedTime >= 14f && playedTime <= 17f)
        {
            Time.timeScale = 0.005f;
            //Time.fixedDeltaTime = Time.timeScale * .02f;
        }
        //tried to ease-out but implement a better solution
        else if (playedTime > 17f && playedTime <= 18f)
        {
            if (Time.timeScale < 1f)
            { Time.timeScale += 0.005f; }
            if (playedTime > 17.4f && Time.timeScale != 1f)
            {
                Time.timeScale = 1f;
            }
        }
        //same as above
        //else if (playedTime >= 29.45f && playedTime <= 30.55f)
        //{
        //    Time.timeScale = 0.005f;
        //} else if (playedTime > 30.55f && Time.timeScale != 1f)
        //{
        //    Time.timeScale = 1f;
        //}


        if (playedTime >= 29.0f && playedTime <= 31.4f)
        {
            count++;

            if (count == 1)
            { IsPaused = true; }

        }

        if (Input.GetKeyDown(KeyCode.Space) && IsPaused)
        {
            IsPaused = false;
        }
        
        if (IsPaused) { Time.timeScale = 0; }
        else if (!IsPaused) { Time.timeScale = 1; }
    }
}

