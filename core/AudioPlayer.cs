using System;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageTakenClip;
    [SerializeField][Range(0f, 1f)] float damageTakenVolume = 1f;

    static AudioPlayer instance; //Static persist through all classes and methods. It will always be the same instance of the object;

    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        // This is used when not using a static instance of the singleton to find the object list of the same object if it exists
        // int instanceCount = FindObjectsByType(GetType(), FindObjectsSortMode.None).Length;
        // if (instanceCount > 1)
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayShootingClip()
    {
        PlayClip(shootingClip, shootingVolume);
    }

    public void PlayDamageTakenClip()
    {
        PlayClip(damageTakenClip, damageTakenVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        Vector3 cameraPos = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(clip, cameraPos, volume);

    }

}
