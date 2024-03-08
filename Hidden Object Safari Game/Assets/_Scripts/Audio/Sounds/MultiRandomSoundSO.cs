using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Scriptable Object for storing multiple sound clips and playing a random one when the play method is called.
/// </summary>
public class MultiRandomSoundSO : ScriptableObject
{
    [SerializeField] private SoundSO[] sounds;

    public void PlayRandomSFX()
    {
        
    }
}
