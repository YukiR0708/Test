using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    private AudioSource audioSound;
    public List<AudioClip> soundPrefabs = new List<AudioClip>();

    void Start()
    {
        audioSound = gameObject.AddComponent<AudioSource>();

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSound.PlayOneShot(soundPrefabs[0]);

        }   else if(other.gameObject.tag == "Wall")
        {
            audioSound.PlayOneShot(soundPrefabs[1]);

        }
    }
}
