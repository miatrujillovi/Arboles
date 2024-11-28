using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree
{
    public DialogueNode Root {  get; private set; } //Define Root in the Tree

    //Constructor of DialogueTree
    public DialogueTree(string _initialRoot)
    {
        Root = new DialogueNode(_initialRoot, 0, "Root");
    }
}
