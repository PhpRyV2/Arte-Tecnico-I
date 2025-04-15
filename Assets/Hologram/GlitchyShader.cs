using System.Collections;
using UnityEngine;

public class GlitchyShader : MonoBehaviour
{
    [SerializeField] private Vector3 _timeValues;
    private Material _hologram;
    private void Awake()
    {
        _hologram = GetComponent<Renderer>().material;
    }
    private void Start()
    {
        StartCoroutine(Glitch());
    }

    private IEnumerator Glitch()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(Random.Range(_timeValues.x, _timeValues.y));
            _hologram.SetFloat("_GlitchEnable",1);
            yield return new WaitForSecondsRealtime(Random.Range(_timeValues.x, _timeValues.z));
            _hologram.SetFloat("_GlitchEnable", 0);
        }
    }
}
