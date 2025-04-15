using UnityEngine;

[ExecuteAlways]
public class Revealer : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Material _revealMaterial;

    void Update()
    {
        if (_revealMaterial != null && _player != null)
        {
            _revealMaterial.SetVector("_Player_Position", _player.position);
        }
    }
}
