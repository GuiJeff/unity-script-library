using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    public static ScenePersist instance;
    public ScenePersist GetInstance()
    {
        return instance;
    }
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("Scene Destroyed");
            return;
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log("Scene Preserved");
            instance = this;
        }

    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
