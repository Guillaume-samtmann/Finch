using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    public AudioClip[] musiques;
    private AudioSource musicSource;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        PlayRamdomSong();
    }

    void PlayRamdomSong()
    {
        if (musiques.Length > 0)
        {
            int indexMusique = Random.Range(0, musiques.Length);
            musicSource.clip = musiques[indexMusique];
            musicSource.Play();
        }
    }
}
