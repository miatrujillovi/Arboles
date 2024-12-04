using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Variables for Unity Editor
    public Text dialogTXT;
    public Text goodTXT, neutralTXT, BadTXT;
    public Button goodBTN, neutralBTN, badBTN;

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
            Debug.Log("El Dialogo del Nodo es: " + currentNode.Dialogue);
            TXTAssigment();
        } 
        else
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
            Debug.Log("El Dialogo del Nodo es: " + currentNode.Dialogue);
            TXTAssigment();
        } 
        else
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
            Debug.Log("El Dialogo del Nodo es: " + currentNode.Dialogue);
            TXTAssigment();
        } 
        else
        {
            FinishGame();
        }
    }

    //Function that changes TXT according to the currentNode
    public void TXTAssigment()
    {
        dialogTXT.text = currentNode.Dialogue;

        //Good Option
        if (currentNode.goodOption != null)
        {
            goodBTN.interactable = true;
            goodTXT.text = currentNode.goodOption.Dialogue;
        }
        else
        {
            goodBTN.interactable = false;
            goodTXT.text = "";
        }

        //Neutral Option
        if (currentNode.neutralOption != null)
        {
            neutralBTN.interactable = true;
            neutralTXT.text = currentNode.neutralOption.Dialogue;
        }
        else
        {
            neutralBTN.interactable = false;
            neutralTXT.text = "";
        }

        //Bad Option
        if (currentNode.badOption != null)
        {
            badBTN.interactable = true;
            BadTXT.text = currentNode.badOption.Dialogue;
        } 
        else
        {
            badBTN.interactable = false;
            BadTXT.text = "";
        }
    }

    public void FinishGame()
    {
        dialogTXT.text = "Advertencia: Fin del Juego";
        goodBTN.interactable = false;
        neutralBTN.interactable = false;
        badBTN.interactable = false;
    }
}
