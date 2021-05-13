using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Sounds : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sound_Play()
    {
        m_MyAudioSource.Play();
    }

    public void Sound_Stop()
    {
        m_MyAudioSource.Stop();
    }


}
