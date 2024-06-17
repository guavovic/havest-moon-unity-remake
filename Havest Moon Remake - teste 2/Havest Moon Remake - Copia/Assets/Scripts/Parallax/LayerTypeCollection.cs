using System.Collections.Generic;
using UnityEngine;

public sealed class LayerTypeCollection : MonoBehaviour
{
    [SerializeField] private LayerType layerType;
    [SerializeField] private List<ParallaxLayer> parallaxLayers;

    public void SetLayerType(LayerType type)
    {
        layerType = type;
    }

    public void AddParallaxLayer(ParallaxLayer parallaxLayer)
    {
        if (parallaxLayers == null)
            parallaxLayers = new List<ParallaxLayer>();

        parallaxLayers.Add(parallaxLayer);
    }
}
