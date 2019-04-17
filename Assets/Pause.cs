using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class Pause : MonoBehaviour
{
    public bool IsPaused;
    public float playedTime;

   // Start is called before the first frame update
    void Start()
    {
        //pd = brute.GetComponent<PlayableDirector>();
        IsPaused = false;
        playedTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        playedTime += Time.deltaTime;
        //playable.GetGraph().GetRootPlayable(0).GetTime(). 
        if (playedTime >= 29.16f)
        {
            IsPaused = true;    
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsPaused)
        {
            IsPaused = false;
        }
        
        if (IsPaused) { Time.timeScale = 0; }
        else if (!IsPaused) { Time.timeScale = 1; }
    }
}

