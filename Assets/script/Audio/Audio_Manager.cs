using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    [SerializeField] AudioSource source3;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip goal;
    public bool isGoal = false;
    void Start()
    {
        source1.PlayOneShot(clip1);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoal)
        {
            if(source3.isPlaying == false)
            {
                source1.mute = true;
                source2.mute = true;
                source3.PlayOneShot(goal);
            }

        }
        else
        {
            if (TIME_MANAGER.is_revtime == true)
            {
                if (source2.isPlaying == false)
                {
                    source1.mute = true;
                    source2.PlayOneShot(clip2);
                }
            }
            else
            {
                if (source2.isPlaying == true)
                {
                    source2.Stop();
                    source1.mute = false;
                }
            }
        }
      
    }

}
