using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adds item to game object menu
[CreateAssetMenu(menuName = ("State"))]
public class State : ScriptableObject
{
  // The text are field will set the size of the text field within the details panel 10 min lines shown and 14 is point it will start scrolling
  [TextArea(10, 14)] [SerializeField] string storyText;

  // Array of possible next states
  [SerializeField] State[] NextStates;

  public string GetStateStory()
  {
    return storyText;
  }

  public State[] GetNextStates()
  {
    return NextStates;
  }
}
