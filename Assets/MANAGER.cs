using System.Collections.Generic;
using UnityEngine;

public class MANAGER : MonoBehaviour
{
    public static MANAGER Instance { get; set; }
    public List<AudioClip> sounds = new List<AudioClip>();
    [SerializeField] private AudioSource m_AudioSource;
    private void Awake()
    {
        Instance = this;
    }
    public void PlaySound(int index)
    {
        m_AudioSource.clip = sounds[index];
        m_AudioSource.Play();
    }
}
