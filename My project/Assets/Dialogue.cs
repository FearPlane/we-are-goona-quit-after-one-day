using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro library for advanced text rendering
using UnityEngine.InputSystem; // new input system

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent; // The UI text object in the scene (dialogue box)
    public string[] lines;                // Array of dialogue lines (each element is one sentence)
    public float textSpeed;               // Delay between typing each character (typing speed)

    private int index;                    // Keeps track of which dialogue line is currently displayed

    // Called once when the object is created
    void Start()
    {
        textComponent.text = string.Empty; // Clear text box when dialogue starts
        StartDialogue();                   // Begin the dialogue system
    }

    // Called once every frame
    void Update()
    {
        // If the player clicks the left mouse button
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // If the current line is fully displayed
            if (textComponent.text == lines[index])
            {
                NextLine(); // Move to the next line
            }
            else
            {
                // If text is still typing, instantly complete it
                StopAllCoroutines();             // Stop the typing animation
                textComponent.text = lines[index]; // Show the whole line immediately
            }
        }
    }

    // Starts the dialogue from the first line
    void StartDialogue()
    {
        index = 0;                  // Reset to the first line
        StartCoroutine(TypeLine()); // Begin typing out the first line
    }

    // Coroutine that types each letter one by one
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) // Go through each character in the current line
        {
            textComponent.text += c;                    // Add the character to the text box
            yield return new WaitForSeconds(textSpeed); // Wait a bit before adding the next character
        }
    }

    // Loads the next line of dialogue
    void NextLine()
    {
        // If there are more lines left
        if (index < lines.Length - 1)
        {
            index++;                          // Go to the next line
            textComponent.text = string.Empty; // Clear the text box
            StartCoroutine(TypeLine());       // Start typing the new line
        }
        else
        {
            // If we’re out of lines, hide the dialogue box
            gameObject.SetActive(false);
        }
    }
}
