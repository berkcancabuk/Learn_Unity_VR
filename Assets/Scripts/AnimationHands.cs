using UnityEngine;
using UnityEngine.InputSystem;
public class AnimationHands : MonoBehaviour
{
  public InputActionProperty pinchAnimationAction;
  public InputActionProperty gripAnimationAction;

  public Animator anim;
  void Start()
  {
    anim = GetComponent<Animator>();
  }

  void Update()
  {
    float triggerValue = pinchAnimationAction.action.ReadValue<float>();
    print(triggerValue);
    
    anim.SetFloat("Trigger",triggerValue);
    float gripValue = gripAnimationAction.action.ReadValue<float>();
    
    print(gripValue);
    anim.SetFloat("Grip",gripValue);
  }
}
