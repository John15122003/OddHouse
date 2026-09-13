using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickedTransitiion : MonoBehaviour
{
    public string Entrance;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(Entrance);
    }
}
