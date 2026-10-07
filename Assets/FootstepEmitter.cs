using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepEmitter : MonoBehaviour
{
    public AudioClip[] footstepSound = default;

    public void PlayFootstepSound(AudioSource source)
    {
        source.PlayOneShot(footstepSound[Random.Range(0, footstepSound.Length)]);
    }
}
