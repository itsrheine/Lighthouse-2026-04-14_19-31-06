using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    public GameObject startPanel;
    public CarController carController;

    public LightingManager  lightingManager;

    private bool gameStarted = false; // 👈 MUST be here (outside Update)

    void Start ()
    {
        if (carController != null)
        carController.canDrive = true;

        lightingManager.SetMorning();
    }
    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;

            Debug.Log("Space pressed");

            if (startPanel != null)
                startPanel.SetActive(false);

            if (carController != null)
            {
                carController.canDrive = true;
                Debug.Log("Car can now drive");
            }
        }
    }
}