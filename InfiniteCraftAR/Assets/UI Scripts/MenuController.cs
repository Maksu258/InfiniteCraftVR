using UnityEngine;
using UnityEngine.InputSystem;
public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;

    private bool isMenuOpen = false;

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        menuPanel.SetActive(isMenuOpen);
    }
}

