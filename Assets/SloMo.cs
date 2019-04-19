using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class SloMo : MonoBehaviour
{
    public float playedTime;

    Vignette vignette = null;

    private PostProcessVolume volume;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        playedTime = 0.0f;
        volume = gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out vignette);
    }
    

    // Update is called once per frame
    void Update()
    {
        playedTime += Time.deltaTime;
        
        if (playedTime >= 14f && playedTime <= 17f)
        {
            vignette.enabled.value = true;
            vignette.intensity.value = 1f;
            vignette.smoothness.value = 1f;
            vignette.roundness.value = 1f;
        }
        else { vignette.enabled.value = false; }

    }
}
