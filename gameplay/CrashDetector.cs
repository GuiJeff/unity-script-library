using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
  [SerializeField] float loadDelay = 0.5f;
  [SerializeField] ParticleSystem crashEffect;
  [SerializeField] AudioClip crashSFX;
  bool hasCrashed = false;

  void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Ground" && !hasCrashed)
    {
      hasCrashed = true;
      FindAnyObjectByType<PlayerController>().DisableControls();
      crashEffect.Play();
      GetComponent<AudioSource>().PlayOneShot(crashSFX);
      Invoke("ReloadScene", loadDelay);
    }
  }

  void ReloadScene()
  {
    SceneManager.LoadScene(0);
  }
}
