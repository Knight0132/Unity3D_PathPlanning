using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    public class GridVisualizer : MonoBehaviour
    {
        public GameObject groudPrefab;

        public void VisualizeGrid(int width, int length)
        {
            Vector3 position = new Vector3(width / 2f, 0, length / 2f);
            Quaternion rotation = Quaternion.Euler(90, 0, 0);
            var board = Instantiate(groudPrefab, position, rotation);
            board.transform.localScale = new Vector3(width, length, 1);
        }
		
    }
}
