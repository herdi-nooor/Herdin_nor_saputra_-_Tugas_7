using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _bgmAudioSource;
    public bool isAudioEnabled = false;
    private static AudioManager _instance;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {   
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        _bgmAudioSource = gameObject.AddComponent<AudioSource>();
    }

    private void Start()
    {
        int indexAudio = Random.Range(0, 4);
        _bgmAudioSource.clip = Resources.Load<AudioClip>($"Audio/BGM/BGM_0{indexAudio}");
    }

    public void PlayBgm()
    {
        if (isAudioEnabled)
        {
            _bgmAudioSource.Play();
        }
    }
}
