using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Variables for Unity Editor
    public Text dialogTXT;
    public Text goodTXT, neutralTXT, BadTXT;

    //Variables for the Nodes and Tree
    public DialogueNode currentNode;
    public DialogueManager dialogueManager;

    //Function that establishes currentNode as Root and their Dialogs in their respective TXT
    public void Initilizations()
    {
        currentNode = dialogueManager.tree.Root;
        TXTAssigment();
    }

    //Function for Good Option
    public void SelectedGood()
    {
        if (currentNode.goodOption != null)
        {
            currentNode = currentNode.goodOption;
            TXTAssigment();
        } else
        {
            FinishGame();
        }
    }

    //Function for Neutral Option
    public void SelectedNeutral()
    {
        if (currentNode.neutralOption != null)
        {
            currentNode = currentNode.neutralOption;
            TXTAssigment();
        } else
        {
            FinishGame();
        }
    }

    //Function for Bad Option
    public void SelectedBad()
    {
        if (currentNode.badOption != null)
        {
            currentNode.badOption = currentNode.badOption;
            TXTAssigment();
        } else
        {
            FinishGame();
        }
    }

    //Function that changes TXT according to the currentNode
    public void TXTAssigment()
    {
        dialogTXT.text = currentNode.Dialogue;
        goodTXT.text = currentNode.goodOption.Dialogue;
        neutralTXT.text = currentNode.neutralOption.Dialogue;
        BadTXT.text = currentNode.badOption.Dialogue;
    }

    public void FinishGame()
    {
        dialogTXT.text = "Advertencia: Fin del Juego";
    }
}
