using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("General")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileLifeTime = 5f;
    [SerializeField] float baseFiringRate = 0.2f;

    [Header("AI")]
    [SerializeField] float firingRateVariance = 0f;
    [SerializeField] float minimumFiringRate = 0.1f;
    [SerializeField] bool useAI;
    [HideInInspector] public bool isFiring = false;
    
    Coroutine firingCoroutine;
    AudioPlayer audioPlayer;

    void Awake()
    {
        audioPlayer = FindAnyObjectByType<AudioPlayer>();
    }
    void Start()
    {
        if (useAI)
        {
            isFiring = true;
        }
    }

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (isFiring && firingCoroutine == null)
        {
            //Coroutines can be stored as variables, makin it easier to be called in other methods
            firingCoroutine = StartCoroutine(FireContinuously());
        }
        else if (!isFiring && firingCoroutine != null)
        {
            //Stops all corutinines, not recomended if only one corutine must be affected
            //StopAllCoroutines();
            StopCoroutine(firingCoroutine);
            firingCoroutine = null;
        }
    }

    float RandomFireTime()
    {
        float randomFiringRate = UnityEngine.Random.Range(baseFiringRate - firingRateVariance,
                                                   baseFiringRate + firingRateVariance);
        return Mathf.Clamp(randomFiringRate, minimumFiringRate, float.MaxValue);

    }

    IEnumerator FireContinuously()
    {
        while (true)
        {
            GameObject instance = Instantiate(projectilePrefab,
                                              transform.position,
                                              Quaternion.identity);
            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = transform.up * projectileSpeed;
            }
            Destroy(instance, projectileLifeTime);

            audioPlayer.PlayShootingClip();

            yield return new WaitForSeconds(RandomFireTime());
        }
    }
}
