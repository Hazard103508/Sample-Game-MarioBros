using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject[] prefabs;
    private Dictionary<int, GameObject> dicPrefab;

    #region Properties
    /// <summary>
    /// Tamaño del mapa
    /// </summary>
    public Rect Rectangle { get; private set; }
    #endregion


    private void Start()
    {
        dicPrefab = new Dictionary<int, GameObject>();
        Array.ForEach(prefabs, p => dicPrefab.Add(Convert.ToInt32(p.name), p));
    }
    public void Load()
    {
        var asset = Resources.Load<TextAsset>("Level_1_1");
        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<MapData>(asset.text);

        Load_Layer(data.layers[0]);

        this.Rectangle = new Rect(0, 0, data.layers[0].width, data.layers[0].height);
    }

    private void Load_Layer(MapData.Layer layer)
    {
        for (int i = 0; i < layer.data.Count; i++)
        {
            int id = layer.data[i];
            if (id != 0)
            {
                int x = i % layer.width;
                int y = i / layer.width;

                if (id != 0)
                {
                    if (dicPrefab.ContainsKey(id)) // BORRAR
                    {
                        var _prefab = dicPrefab[id];
                        var go = Instantiate(_prefab, this.transform);
                        go.transform.localPosition = new Vector3(x, -y, 0);
                    }
                }
            }
        }
    }
}
