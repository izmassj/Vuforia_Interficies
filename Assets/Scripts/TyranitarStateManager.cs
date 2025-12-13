using UnityEngine;
using UnityEngine.UI;

public class TyranitarStateManager : MonoBehaviour
{
    [SerializeField] Image stateImage;
    [SerializeField] Sprite[] statesImages;
    [SerializeField] Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            stateImage.sprite = statesImages[0];
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Dance"))
        {
            stateImage.sprite = statesImages[1];
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Confused"))
        {
            stateImage.sprite = statesImages[2];
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("ToSleep"))
        {
            stateImage.sprite = statesImages[3];
        }
    }
}
