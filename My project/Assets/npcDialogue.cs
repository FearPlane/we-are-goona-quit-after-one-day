using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class npcDialogue : MonoBehaviour
{
    public bool canChat = false;
    public GameObject canvas;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private bool chatStarted = false;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
    }



    // Update is called once per frame
    void Update()
    {
        if (canChat)
        {
            if (Input.GetKey(KeyCode.F) && chatStarted == false)
            {
                canChat = false;
                canvas.SetActive(true);
                StartDialogue();
                this.GetComponent<SphereCollider>().enabled = false;
                chatStarted = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && chatStarted)
        {
            if (textComponent.text == lines[index])
            {
               NextLine();
            }
            else
            {
               StopAllCoroutines();
               textComponent.text = lines[index];
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canChat = true;
        }
        else
        {
            canChat = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canChat=false;
    }



    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            canvas.SetActive(false);
        }
    }
}



//Remove the dialogue script component from the dialogue box (that you followed doing the tutorial) and apply this script component (the script above) to your NPC.
//Create a SphearColider and place it in front of your NPC and set this as a trigger.
//Apply the canvas gameobject, the TMPro text field gameobject into the the new variable gameobjects field on your NPC.
