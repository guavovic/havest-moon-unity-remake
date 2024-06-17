using System.Collections.Generic;
using UnityEngine;

public sealed class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private ParallaxCamera parallaxCamera;
    [SerializeField] private List<ParallaxLayer> parallaxLayers;

    private void Start()
    {
        if (Camera.main.TryGetComponent(out ParallaxCamera parallaxCamera))
        {
            this.parallaxCamera = parallaxCamera;
            this.parallaxCamera.onCameraTranslate += Move;
        }
    }

    public void AddParallaxLayer(ParallaxLayer parallaxLayer)
    {
        if (parallaxLayers == null)
            parallaxLayers = new List<ParallaxLayer>();

        parallaxLayers.Add(parallaxLayer);
    }

    private void Move(float delta)
    {
        foreach (ParallaxLayer layer in parallaxLayers)
        {
            layer.Move(delta);
        }
    }
}