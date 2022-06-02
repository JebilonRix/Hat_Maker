using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ScreenShotTaker : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakePhoto();
        }
    }
    public void TakePhoto()
    {
        ScreenShot.ScreenTextureToMaterial(_renderer, Camera.main);
    }
}