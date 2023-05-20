using UnityEngine;

public class GameManageAlien : MonoBehaviour
{
    #region Singleton class: GameManage

    public static GameManageAlien Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    Camera cam;

    public SpacePhysx ball;
    public Trajectory trajectory;
    [SerializeField] float pushForce = 4f;

    bool isDragging = false;
    bool isDragged = false;

    Vector2 startPoint;
    Vector2 endPoint;
    Vector2 direction;
    Vector2 force;
    float distance;

    void Start()
    {
        cam = Camera.main;
        ball.DesactivateRb();
    }

    void Update()
    {
        if (!isDragged && Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            OnDragStart();
        }
        if (isDragging)
        {
            OnDrag();
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            OnDragEnd();
        }
        else
        {
            force = Vector2.zero;
        }
    }

    // Drag
    void OnDragStart()
    {
        ball.DesactivateRb();
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);

        trajectory.Show();
    }

    void OnDrag()
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startPoint, endPoint);
        direction = (startPoint - endPoint).normalized;
        force = direction * distance * pushForce;

        Debug.DrawLine(startPoint, endPoint);

        trajectory.UpdateDots(ball.pos, force);
    }

    void OnDragEnd()
    {
        ball.ActivateRb();

        ball.Push(force);

        trajectory.Hide();
    }
}
