using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeSoundController : MonoBehaviour
{
    private AudioSource[] _audioSourceList;
    public AudioClip[] _sounds;
    void Start()
    {
        _audioSourceList = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Ayy1Sound()
    {
        _audioSourceList[0].PlayOneShot(_sounds[0]);
    }
    public void WhooshSoundLowPitch()
    {
        _audioSourceList[0].PlayOneShot(_sounds[1]);
    }
    public void WhooshSoundHighPitch()
    {
        _audioSourceList[0].PlayOneShot(_sounds[3]);
    }
    public void GroundImpact()
    {
        _audioSourceList[0].PlayOneShot(_sounds[2]);
    }
    public void FallSound()
    {
        _audioSourceList[1].PlayOneShot(_sounds[4]);
    }

    public void ElectrocutedSound()
    {
        _audioSourceList[0].PlayOneShot(_sounds[5]);

    }
    
    
}
