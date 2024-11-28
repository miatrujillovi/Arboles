using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueNode
{
    //Variables for the Base Node
    public string Dialogue { get; set; } //string for the Dialogue
    public DialogueNode goodOption { get; set; } //Reference to the next Node of goodOption
    public DialogueNode neutralOption { get; set; } //Reference to the next Node of neutralOption
    public DialogueNode badOption { get; set; } //Reference to the next Node of badOption
    public int level { get; set; } //int of the Level in Which the Node is currently
    public string identifier { get; set; } //string of the Identifier of the Node to know which one it is (Good, Neutral or Bad)

    //Constructor of the Node
    public DialogueNode(string _dialogue, int _level, string _identifier)
    {
        Dialogue = _dialogue;
        level = _level;
        identifier = _identifier;
    }
}
