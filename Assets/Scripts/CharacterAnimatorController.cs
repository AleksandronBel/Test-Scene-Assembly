using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private int _currentState = 1; 

    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Alpha1)) SetAnimation(0); // Yoga
        if (Input.GetKeyDown(KeyCode.Alpha2)) SetAnimation(1); // Idle
        if (Input.GetKeyDown(KeyCode.Alpha3)) SetAnimation(2); // Applaud
    }

    public void SetAnimation(int state)
    {
        _currentState = state;
        _animator.SetInteger("AnimationState", _currentState);
    }
}
