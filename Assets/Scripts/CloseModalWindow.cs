using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CloseModalWindow : MonoBehaviour
{
    private Button _closeButton;

    private void Start()
    {
        _closeButton = GetComponent<Button>();
        _closeButton.onClick.AddListener(CloseWindow);
    }

    private void OnDestroy()
    {
        _closeButton.onClick.RemoveListener(CloseWindow);
    }

    private void CloseWindow()
    {
        Destroy(_closeButton.transform.parent.GameObject());
    }
}
