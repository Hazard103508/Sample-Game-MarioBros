using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Map map;
    // Start is called before the first frame update
    void Start()
    {
        this.map.Load();
        //playerFollower.Set_Map(this.map);
        //
        //var lstGems = this.map.Tiles.Where(x => x.type == TileType.Gem).Select(x => (Gem)x).ToList();
        //lstGems.ForEach(x => x.Collected.AddListener(() => counter++));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
