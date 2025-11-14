using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        trailEffect.Play();
    }
    private void OnCollisionExit2D(Collision2D other)
    {
         trailEffect.Stop();
    }
}
