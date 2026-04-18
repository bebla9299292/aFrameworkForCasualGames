using UnityEngine;
/// <summary>
/// Управляет настройками экрана в игре.
/// </summary>
public class SettingsCode : MonoBehaviour
{
    /// <summary>
    /// Устанавливает режим отображения экрана.
    /// </summary>
    /// <param name="isFullDisplay">True для полноэкранного режима, false для оконного.</param>
    public void DisplaySettings(bool isFullDisplay)
    {
        Screen.fullScreen = isFullDisplay;
    }

    /// <summary>
    /// Переключает между полноэкранным и оконным режимами.
    /// </summary>
    public void ToggleFullScreen()
    {
        // Инвертируем текущий режим экрана
        bool newMode = !Screen.fullScreen;
        // Применяем новый режим
        DisplaySettings(newMode);
        // Выводим в консоль текущее состояние для отладки
        Debug.Log(newMode);
    }
}
