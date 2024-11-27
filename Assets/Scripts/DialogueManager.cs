using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public DialogueTree DialogueTree;
    private DialogueNode currentNode;

    private void Start()
    {
        currentNode = DialogueTree.Root;
        ShowCurrentDialogue();
    }

    public void SelectAnswer(int answerIndex)
    {
        if (currentNode != null && answerIndex < currentNode.Answers.Count)
        {
            currentNode = currentNode.Answers[answerIndex];
            ShowCurrentDialogue();
        }
        else
        {
            Debug.Log("Fin del diálogo.");
        }
    }

    private void ShowCurrentDialogue()
    {
        if (currentNode != null)
        {
            Debug.Log(currentNode.DialogueText.text);
        }
    }
}
