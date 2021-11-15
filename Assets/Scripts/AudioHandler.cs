using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    private Dictionary<string, AudioSource> AudioSources = new Dictionary<string, AudioSource>();

    // Start is called before the first frame update
    void Start()
    {
        var sourceList = gameObject.GetComponents<AudioSource>();
        AudioSources = new Dictionary<string, AudioSource>
        {
            {"win", sourceList[0]},
            {"lose", sourceList[1]},
            {"walk", sourceList[2]},
            {"advance_objective", sourceList[3]}
        };
    }

    public void Play(string clip)
    {
        AudioSource source = AudioSources[clip];
        source.Play();
    }

    public void PlayOneShot(string clip)
    {
        AudioSource source = AudioSources[clip];
        source.PlayOneShot(source.clip);
    }

    public void Stop(string clip)
    {
        AudioSource source = AudioSources[clip];
        source.Stop();
    }
}
