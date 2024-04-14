using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CallModalWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject _modalWindow;
    
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(CreateWindow);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(CreateWindow);
    }

    private void CreateWindow()
    {
        Instantiate(_modalWindow, _button.transform.parent.GameObject().transform);
    }
}
