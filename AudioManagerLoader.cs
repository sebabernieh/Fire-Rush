using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerLoader : MonoBehaviour
{
    public AudioManger theAM;

    private void Awake()
    {
        if(AudioManger.instance == null)
        {
            Instantiate(theAM);
        }
    }

}
