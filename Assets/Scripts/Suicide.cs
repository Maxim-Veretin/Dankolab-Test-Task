using UnityEngine;
using UnityEngine.UI;

public class Suicide : MonoBehaviour
{
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(KillYourself);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(KillYourself);
    }

    public void KillYourself()
    {
        Destroy(gameObject);
    }
}
