using UnityEngine;

using UnityEngine;

public class TimeSlowdown : MonoBehaviour
{
    [Header("Slowdown Settings")]
    public float slowdownFactor = 0.5f; // Factor by which time will be slowed down
    public float slowdownDuration = 2f; // Duration of the slowdown in seconds
    public float cooldownDuration = 5f; // Duration of the cooldown in seconds
    [SerializeField]private  GameObject greenClock;
    [SerializeField]private GameObject redClock;

    private bool isSlowingDown = false;
    private bool isCooldown = false;
    private float slowdownTimer = 0f;
    private float cooldownTimer = 0f;

    void Update()
    {
        // Detect space bar press and check if cooldown is not active
        if (Input.GetKeyDown(KeyCode.Space) && !isSlowingDown && !isCooldown)
        {
            StartSlowdown();
        }

        // If we are in slowdown mode, update the timer
        if (isSlowingDown)
        {
            slowdownTimer += Time.unscaledDeltaTime;
            if (slowdownTimer >= slowdownDuration)
            {
                EndSlowdown();
                StartCooldown();
            }
        }

        // If we are in cooldown mode, update the timer
        if (isCooldown)
        {
            cooldownTimer += Time.unscaledDeltaTime;
            if (cooldownTimer >= cooldownDuration)
            {
                EndCooldown();
            }
        }
    }

    void StartSlowdown()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f; // Adjust fixedDeltaTime to maintain physics accuracy
        isSlowingDown = true;
        slowdownTimer = 0f;
        redClock.SetActive(true);
        greenClock.SetActive(false);
    }

    void EndSlowdown()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f; // Reset fixedDeltaTime to default
        isSlowingDown = false;
    }

    void StartCooldown()
    {
        isCooldown = true;
        cooldownTimer = 0f;
    }

    void EndCooldown()
    {
        isCooldown = false;
        redClock.SetActive(false);
        greenClock.SetActive(true);
    }
}
