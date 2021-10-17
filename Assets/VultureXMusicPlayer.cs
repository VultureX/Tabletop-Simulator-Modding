using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureXMusicPlayer : MonoBehaviour
{
    public Vector2 vec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        //myAudioSource.mute = true;

        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "VultureXMusicPlayer")
                {
                    Debug.Log("My object is clicked by mouse");
                   
                    if (myAudioSource != null)
                    {
                        myAudioSource.mute = !myAudioSource.mute;
                        Debug.Log("AudioSource");
                    }
                }
            }
        }
    }
}
