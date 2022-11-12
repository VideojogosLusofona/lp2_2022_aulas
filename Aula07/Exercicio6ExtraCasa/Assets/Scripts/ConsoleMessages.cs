using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    // Reference to the event master
    private EventMaster em;

    // Awake is called one time at the beginning
    private void Awake()
    {
        // Get reference to the event master
        em = GetComponent<EventMaster>();
    }

    public void Start()
    {
        // Add listener
        em.KeyPress.AddListener(ShowConsoleMessage);
    }

    // Show in the console which key was pressed
    public void ShowConsoleMessage(char key)
    {
        Debug.Log($"{key} was pressed");
    }
}