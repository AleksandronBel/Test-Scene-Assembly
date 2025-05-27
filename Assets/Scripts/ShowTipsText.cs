using TMPro;
using UnityEngine;

public class ShowTipsText : MonoBehaviour
{
    [SerializeField] private TMP_Text _tipsText;

    private void OnTriggerEnter(Collider other)
    {
        _tipsText.gameObject.SetActive(other.TryGetComponent(out PlayerMovement player));
    }

    private void OnTriggerExit(Collider other)
    {
        _tipsText.gameObject.SetActive(!other.TryGetComponent(out PlayerMovement player));
    }
}
