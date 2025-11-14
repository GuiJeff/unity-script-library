using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float paddingLeft;
    [SerializeField] float paddingRight;
    [SerializeField] float paddingTop;
    [SerializeField] float paddingBottom;
    Vector2 rawInput;
    Vector2 minBounds;
    Vector2 maxBounds;

    Shooter shooter;

    void Awake()
    {
        shooter = GetComponent<Shooter>();
    }

    void Start()
    {
        InitBounds();
    }
    void Update()
    {
        Move();

    }

    //Initialize Boundaries variables
    void InitBounds()
    {
        Camera mainCamera = Camera.main;
        //Bounds start from bottom left (0,0)
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0)); //ViewportToWorldPoint expects a Vector3 so a
                                                                        //new Vector2 is used to ignore the Z axis
                                                                        //Bounds end at top right (1,1)
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));

    }

    private void Move()
    {
        Vector2 delta = rawInput * moveSpeed * Time.deltaTime; //Makes movemente frame independent
        Vector2 newPos = new Vector2();
        //Keep the movement inside the boundaries with padding for better visual
        newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);//Clamp limits the value to be
                                                                                                                      // kept between two values range (value, minimal, max)
        newPos.y = Mathf.Clamp(transform.position.y + delta.y, minBounds.y + paddingBottom, maxBounds.y - paddingTop);

        transform.position = newPos;
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        //Debug.Log(rawInput);
    }

    void OnFire(InputValue value)
    {
        if (shooter != null)
        {
            shooter.isFiring = value.isPressed;
        }
    }
}
