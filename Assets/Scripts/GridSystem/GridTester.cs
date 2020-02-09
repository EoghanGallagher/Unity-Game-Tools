
using UnityEngine;
using CodeMonkey.Utils;

public class GridTester : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private float cellSize;
    [SerializeField] private Vector3 origin;

    private Grid grid;


    private void Start() 
    {
        grid = new Grid( width, height, cellSize, origin );
    }

    private void Update() 
    {
        if( Input.GetMouseButtonDown( 0 ) )
        {
            grid.SetValue( UtilsClass.GetMouseWorldPosition(), 98 );
        }
    

        if( Input.GetMouseButtonDown( 1 ) )
        {
            Debug.Log( grid.GetValue( UtilsClass.GetMouseWorldPosition() ) );
        }
    }
}
