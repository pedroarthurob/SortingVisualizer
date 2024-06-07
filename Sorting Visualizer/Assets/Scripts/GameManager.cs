using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int[] array;
    private (int value, Vector2 position)[] workArray;
    [SerializeField]
    private Bar barPrefab;

    [SerializeField]
    private GameObject barSpawner;

    private SortAlgorithm sortAlgorithm;
    private BubbleSort bubbleSort;
    private CountingSort countingSort;
    private InsertionSort insertionSort;
    private MergeSort mergeSort;
    private QuickSort quickSort;
    private SelectionSort selectionSort;

    private void Start()
    {
        sortAlgorithm = new SortAlgorithm();
        bubbleSort;
        private CountingSort countingSort;
        private InsertionSort insertionSort;
        private MergeSort mergeSort;
        private QuickSort quickSort;
        private SelectionSort selectionSort;
        SetUpNewArray(100);
    }

    private void DistributeBars()
    {

        Camera mainCamera = Camera.main;
        float maxCameraHeight = (mainCamera.orthographicSize * 2f)-1f;

        Transform initialPositionTransform = barSpawner.transform.GetChild(0);
        Transform finalPositionTransform = barSpawner.transform.GetChild(1);

        Vector2 initialPosition = initialPositionTransform.position;
        Vector2 finalPosition = finalPositionTransform.position;

        float totalWidth = finalPosition.x - initialPosition.x;
        int numberOfBars = array.Length;
        float spaceBetweenBars = 0.1f; // Espaço entre as barras
        float totalSpaceBetweenBars = (numberOfBars - 1) * spaceBetweenBars;
        float availableWidthForBars = totalWidth - totalSpaceBetweenBars;

        float barWidth = availableWidthForBars / numberOfBars;

        if (barWidth < 0.01f) barWidth = 0.01f; // Tamanho mínimo das barras

        int maxArrayValue = Mathf.Max(array);
        int minArrayValue = Mathf.Min(array);

        float minBarHeight = 0.1f * maxCameraHeight;

        workArray = new (int value, Vector2 position)[array.Length];

        for (int i = 0; i < numberOfBars; i++)
        {
            Bar newBar = Instantiate(barPrefab, barSpawner.transform);
            float xPos = initialPosition.x + i * (barWidth + spaceBetweenBars);
            newBar.transform.position = new Vector2(xPos, initialPosition.y);

            float normalizedValue = Mathf.InverseLerp(minArrayValue, maxArrayValue, array[i]);
            float barHeight = Mathf.Max(normalizedValue * maxCameraHeight, minBarHeight);

            newBar.UpdateWidth(barWidth);
            newBar.UpdateHeight(barHeight);
            workArray[i] = (array[i], newBar.transform.position);
        }
    }

    public void CreateNewArray(int tamanho)
    {
        array = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            array[i] = Random.Range(1,tamanho);
        }
    }   

    public void SetUpNewArray(int tamanho)
    {
        CreateNewArray(tamanho);
        DistributeBars();
    }

    public void BubbleSort()
    {

    }

    public void CountingSort()
    {

    }

    public void InsertionSort()
    {

    }

    public void MergeSort()
    {

    }
    
    public void QuickSort() 
    {
    
    }

    public void SelectionSort() 
    {

    }


}

