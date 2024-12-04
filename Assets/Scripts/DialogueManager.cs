using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //Public References to Unity Editor
    public Text dialogueIF;
    public Text dialogueTXT;
    public Text levelTXT;

    //Public Variables
    public DialogueTree tree;
    public DialogueNode currentNode;
    public DialogueNode lastNode;

    //Private Variables
    int level;

    private void Start()
    {
        //Initialize DialogueTree, establishing Root
        tree = new DialogueTree("Empty Root");
        currentNode = tree.Root;
        lastNode = null;
        level = 0;
    }

    private void Update()
    {
        UpdateDialogue();
    }

    //Function to update Unity constantly on the current Level and Dialogue in currentNode
    public void UpdateDialogue()
    {
        if (currentNode != null)
        {
            levelTXT.text = "Nivel Actual: " + currentNode.level;
            dialogueTXT.text = currentNode.Dialogue;
        } else
        {
            levelTXT.text = "Nivel Actual: N/A";
            dialogueIF.text = "Dialogo Vacio";
        }
        Canvas.ForceUpdateCanvases();
    }

    //Function to fill the Dialogue in the currentNode
    public void FillDialogue()
    {
        if (currentNode != null)
        {
            currentNode.Dialogue = dialogueIF.text;
            Debug.Log("Se ha Rellenado Exitosamente con: " + currentNode.Dialogue);
        }
    }

    //Function for GoodBTN Case
    public void GoodOption()
    {
        level++;
        lastNode = currentNode;
        currentNode.goodOption = new DialogueNode("Dialogo Bueno Vacio", level, "Good");
        //Debug.Log("Valor de Root:" + tree.Root);
        currentNode = currentNode.goodOption;
        Debug.Log("Estas en: " + currentNode.identifier + " en el nivel: " + currentNode.level);
    }

    //Function for NeutralBTN Case
    public void NeutralOption()
    {
        level++;
        lastNode = currentNode;
        currentNode.neutralOption = new DialogueNode("Dialogo Neutral Vacio", level, "Neutral");
        currentNode = currentNode.neutralOption;
        Debug.Log("Estas en: " + currentNode.identifier + " en el nivel: " + currentNode.level);
    }

    //Function for BadBTN Case
    public void BadOption()
    {
        level++;
        lastNode = currentNode;
        currentNode.badOption = new DialogueNode("Dialogo Malo Vacio", level, "Bad");
        currentNode = currentNode.badOption;
        Debug.Log("Estas en: " + currentNode.identifier + " en el nivel: " + currentNode.level);
    }

    //Function to GoBack one Node
    public void GoBack()
    {
        level--;
        currentNode = lastNode;
        Debug.Log("Estas en: " + currentNode.identifier + " en el nivel: " + currentNode.level);
    }

    //Discarted Function to let the Player select which Level of the Tree they wanna go
    /*public void LevelSelect(int _levelSelected, string _identifier)
    {
        //We begin the Line from Root
        currentNode = tree.Root;

        //Using Queue to better manage the Line
        Queue<DialogueNode> queue = new Queue<DialogueNode>();
        queue.Enqueue(currentNode);

        while (queue.Count > 0)
        {
            //Extract the currentNode out of the Line
            DialogueNode currentLine = queue.Dequeue();

            //If the Node is the same level as _levelSelected and identifier matches, stop the while and match with currentNode
            if (currentLine.level == _levelSelected && currentLine.identifier == _identifier)
            {
                currentNode = currentLine;
                break;
            }

            //Add the Children in the Line
            if (currentLine.goodOption != null) queue.Enqueue(currentLine.goodOption);
            if (currentLine.neutralOption != null) queue.Enqueue(currentLine.neutralOption);
            if (currentLine.badOption != null) queue.Enqueue(currentLine.badOption);
        }

        //Update new Level
        level = _levelSelected;
    }*/
}
