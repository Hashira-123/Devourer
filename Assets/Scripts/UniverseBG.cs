using System;
using UnityEngine;

public class UniverseBG : MonoBehaviour
{
    // Ссылки на объекты сцены
    [SerializeField] private Camera mainCamera = null;
    [SerializeField] private GameObject space = null;

    // Радиус возможного обзора камеры
    private float _spaceCircleRadius = 0;

    // Исходные размеры объекта фона
    private float _backgroundOriginalSizeX = 0;
    private float _backgroundOriginalSizeY = 0;

    // Направление движения
    private Vector3 _moveVector;


    // Вспомогательные переменные

    private float _halfScreenWidth = 0;

    void Start()
    {
        // Стартовое направление движения
        _moveVector = new Vector3(0, 1.5f, 0);
        // Используется для определения направления поворота
        _halfScreenWidth = Screen.width / 2f;

        // Исходные размеры фона
        SpriteRenderer sr = space.GetComponent<SpriteRenderer>();
        var originalSize = sr.size;
        _backgroundOriginalSizeX = originalSize.x;
        _backgroundOriginalSizeY = originalSize.y;

        // Высота камеры равна ортографическому размеру
        float orthographicSize = mainCamera.orthographicSize;
        // Ширина камеры равна ортографическому размеру, помноженному на соотношение сторон
        float screenAspect = (float)Screen.width / (float)Screen.height;
        // Радиус окружности, описывающей камеру
        _spaceCircleRadius = Mathf.Sqrt(orthographicSize * screenAspect * orthographicSize * screenAspect +
                                        orthographicSize * orthographicSize);

        // Конечный размер фона должен позволять сдвинуться на один базовый размер фона в любом направлении + перекрыть радиус камеры также во всех направлениях
        sr.size = new Vector2(_spaceCircleRadius * 2 + _backgroundOriginalSizeX * 2,
            _spaceCircleRadius * 2 + _backgroundOriginalSizeY * 2);
    }

    void Update()
    {


        // Сдвигаем фон в противоположном движению направлении
        space.transform.Translate(-_moveVector.x * Time.deltaTime, -_moveVector.y * Time.deltaTime, 0);

        // При достижении фоном сдвига равного исходному размеру фона в каком-либо направлении, возвращаем его в исходную точно по этому направлению
        if (space.transform.position.x >= _backgroundOriginalSizeX)
        {
            space.transform.Translate(-_backgroundOriginalSizeX, 0, 0);
        }

        if (space.transform.position.x <= -_backgroundOriginalSizeX)
        {
            space.transform.Translate(_backgroundOriginalSizeX, 0, 0);
        }

        if (space.transform.position.y >= _backgroundOriginalSizeY)
        {
            space.transform.Translate(0, -_backgroundOriginalSizeY, 0);
        }

        if (space.transform.position.y <= -_backgroundOriginalSizeY)
        {
            space.transform.Translate(0, _backgroundOriginalSizeY, 0);
        }
    }
}