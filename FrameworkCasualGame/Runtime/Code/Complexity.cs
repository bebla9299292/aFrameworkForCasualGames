using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Управляет уровнем сложности в игре, увеличивая его с течением времени.
/// </summary>
public class Complexity : MonoBehaviour
{
    [Header("Настройки сложности")]
    [Tooltip("Текущий уровень сложности.")]
    [SerializeField] private int levelHard;

    [Tooltip("Оставшееся время до следующего повышения уровня.")]
    [SerializeField] private float time;

    [Tooltip("Время в секундах, необходимое для повышения уровня сложности.")]
    [SerializeField, Min(0.1f)]
    public float defaultTime;

    [Header("События")]
    [Tooltip("Событие, которое вызывается при повышении уровня сложности.")]
    public UnityEvent<int> UpHard;

    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        UpdateTime();
        CheckForLevelUp();
    }

    /// <summary>
    /// Инициализирует начальные значения сложности.
    /// </summary>
    private void Initialize()
    {
        levelHard = 0;
        time = defaultTime;
    }

    /// <summary>
    /// Уменьшает время до следующего повышения уровня.
    /// </summary>
    private void UpdateTime()
    {
        time -= Time.deltaTime;
    }

    /// <summary>
    /// Проверяет, пора ли повышать уровень сложности.
    /// </summary>
    private void CheckForLevelUp()
    {
        if (time <= 0)
        {
            IncreaseLevel();
        }
    }

    /// <summary>
    /// Повышает уровень сложности и сбрасывает таймер.
    /// </summary>
    private void IncreaseLevel()
    {
        levelHard++;
        UpHard?.Invoke(levelHard);
        time = defaultTime;
    }

    /// <summary>
    /// Возвращает текущий уровень сложности.
    /// </summary>
    public int GetLevelHard()
    {
        return levelHard;
    }

    /// <summary>
    /// Возвращает оставшееся время до следующего повышения уровня.
    /// </summary>
    public float GetTime()
    {
        return time;
    }
}
