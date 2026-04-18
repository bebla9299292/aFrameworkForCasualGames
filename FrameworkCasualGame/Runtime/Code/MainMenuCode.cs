using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuCode : MonoBehaviour
{
    [Tooltip("Имя сцены, которую необходимо загрузить.")]
    public string sceneName;
    
    
    /// <summary>
    /// Загружает сцену по имени, указанному в переменной sceneName.
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Активирует и показывает переданный игровой объект (например, панель настроек).
    /// </summary>
    /// <param name="newCanvas">Игровой объект, который нужно сделать видимым.</param>
    public void OpenNewMenu(GameObject newCanvas)
    {
        newCanvas.SetActive(true);
    }
    
    /// <summary>
    /// Деактивирует и скрывает переданный игровой объект (например, панель настроек).
    /// </summary>
    public void CloseNewMenu(GameObject newCanvas)
    {
        newCanvas.SetActive(false);
    }
    
    
    /// <summary>
    /// Завершает работу приложения.
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
