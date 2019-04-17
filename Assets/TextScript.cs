using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextScript : MonoBehaviour
{
    public TextMesh textObject;
    private float playedTime;

    // Start is called before the first frame update
    void Start()
    {
        //textObject = GameObject.Find("Text").GetComponent<TextMesh>();
        playedTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        playedTime += Time.deltaTime;
        if (playedTime >= 28.0f && playedTime <= 31f)
        {
            textObject.text = "Press SPACE to Jump";

        }
        else if(playedTime >= 32.5f)
        { Destroy(textObject);
            //GameObject.Find("Text").GetComponent<TextMesh>(); 
        }
    }
}
