using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float playerSpeed = 3f;

    [Header("Audio Source")]
    [SerializeField]
    private AudioSource playerFalling;

    private bool isPlaying = false;
    private Vector2 move;
    private bool toPause;

    private void Awake()
    {
        InputManager.Controls.Player.Move.performed += ctx => SetMovement(ctx.ReadValue<Vector2>());
        InputManager.Controls.Player.Pause.performed += ctx => toPause = true;

        InputManager.Controls.Player.Move.canceled += ctx => ResetMovement();
        InputManager.Controls.Player.Pause.canceled += ctx => toPause = false;
    }

    private void SetMovement(Vector2 movement) => move = movement;

    private void ResetMovement() => move = Vector2.zero;

    void Start()
    {
        playerSpeed = GameManager.instance.doofusDiary.diaryData.player_data.speed;
    }

    void Update()
    {

        transform.Translate(new Vector3(move.x, 0f, move.y) * Time.deltaTime * playerSpeed);

    }
}