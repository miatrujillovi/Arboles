using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree : MonoBehaviour
{
    public Text rootText; // Texto del nodo raíz
    public List<Text> allAnswerTexts; // Todos los textos de los nodos en orden

    public DialogueNode Root; // Nodo raíz del árbol

    private void Start()
    {
        // Crear el árbol recursivamente
        int index = 0;
        Root = CreateDialogueNode(rootText, ref index);
    }

    private DialogueNode CreateDialogueNode(Text dialogueText, ref int index)
    {
        // Crear un nuevo nodo con el texto actual
        DialogueNode node = new DialogueNode(dialogueText);

        // Para este ejemplo, asumiremos que cada nodo tiene hasta 3 respuestas (Good, Neutral, Bad)
        for (int i = 0; i < 3; i++)
        {
            index++;
            if (index < allAnswerTexts.Count && allAnswerTexts[index] != null)
            {
                // Crear recursivamente los nodos hijos
                node.AddAnswer(CreateDialogueNode(allAnswerTexts[index], ref index));
            }
        }

        return node;
    }
}
