using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class CineMachineCallbackDirector : MonoBehaviour
{
    public PlayableDirector director;

    void OnEnable()
    {
        director.paused += OnPlayableDirectorPaused;
    }

    void OnPlayableDirectorPaused(PlayableDirector aDirector)
    {
        if (director == aDirector)
            Debug.Log("PlayableDirector named " + aDirector.name + " is now paused.");
    }

    void OnDisable()
    {
        director.paused -= OnPlayableDirectorPaused;
    }
}

