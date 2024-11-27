using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueNode
{
    public Text DialogueText; // Referencia al componente Text
    public List<DialogueNode> Answers; // Lista de conexiones (hijos)

    // Constructor para inicializar el nodo
    public DialogueNode(Text dialogueText)
    {
        DialogueText = dialogueText;
        Answers = new List<DialogueNode>(); // Inicializar la lista vacía
    }

    // Método para agregar una respuesta (nodo hijo)
    public void AddAnswer(DialogueNode answer)
    {
        Answers.Add(answer);
    }
}
