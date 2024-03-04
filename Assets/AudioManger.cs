
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    [Header("Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Sounds")]
    public AudioClip click;
    public AudioClip music;

    
    private void Start()
    {
        musicSource.clip = music;
        musicSource.Play();
    }

    public void PlaySFX()
    {
        SFXSource.clip = click;
        SFXSource.Play();
    }
}
