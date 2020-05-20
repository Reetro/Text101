using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
  // SerializeField exposes this to the details panel
  [SerializeField] Text TextComponent;
  [SerializeField] State StartingState;

  State CurrentState;
  
  // Start is called before the first frame update
  void Start()
  {
    CurrentState = StartingState;
    TextComponent.text = CurrentState.GetStateStory();
  }

  // Update is called once per frame
  void Update()
  {
    ManageState();
  }

  private void ManageState()
  {
    var NextStates = CurrentState.GetNextStates();

    for (int index = 0; index < NextStates.Length; index++)
    {
      if (Input.GetKeyDown(KeyCode.Alpha1 + index))
      {
        CurrentState = NextStates[index];
      }
    }

    TextComponent.text = CurrentState.GetStateStory();
  }
}
