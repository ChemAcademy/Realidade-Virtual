using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMana : MonoBehaviour
{
    private static Stack<string> sceneStack = new Stack<string>();
    public void Enter()
    {
        sceneStack.Push("Scenes/AR");
        SceneManager.LoadScene("Scenes/AR");
    }

    public void Main()
    {
        sceneStack.Push("Scenes/Home");
        SceneManager.LoadScene("Scenes/Home");
    }

    public void Content()
    {
        sceneStack.Push("Scenes/Content");
        SceneManager.LoadScene("Scenes/Content");
    }

    public void Configure()
    {
        sceneStack.Push("Scenes/Configure");
        SceneManager.LoadScene("Scenes/Configure");
    }

    public void Configured()
    {
        sceneStack.Push("Scenes/Configured");
        SceneManager.LoadScene("Scenes/Configured");
    }

    public void Saved()
    {
        sceneStack.Push("Scenes/Saved");
        SceneManager.LoadScene("Scenes/Saved");
    }

    public void Menu()
    {
        sceneStack.Push("Scenes/Menu");
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void AboutUs()
    {
        sceneStack.Push("Scenes/AboutUs");
        SceneManager.LoadScene("Scenes/AboutUs");
    }

    public void FAQ()
    {
        sceneStack.Push("Scenes/FAQ");
        SceneManager.LoadScene("Scenes/FAQ");
    }

    public void Meet()
    {
        sceneStack.Push("Scenes/Meet");
        SceneManager.LoadScene("Scenes/Meet");
    }

    public void Question1()
    {
        sceneStack.Push("Scenes/Question1");
        SceneManager.LoadScene("Scenes/Question1");
    }

    public void Question2()
    {
        sceneStack.Push("Scenes/Question2");
        SceneManager.LoadScene("Scenes/Question2");
    }

    public void Question3()
    {
        sceneStack.Push("Scenes/Question3");
        SceneManager.LoadScene("Scenes/Question3");
    }

    public void Question4()
    {
        sceneStack.Push("Scenes/Question4");
        SceneManager.LoadScene("Scenes/Question4");
    }

    public void Question5()
    {
        sceneStack.Push("Scenes/Question5");
        SceneManager.LoadScene("Scenes/Question5");
    }

    public void GoBack()
    {
        if (sceneStack.Count >= 1)
        {
            sceneStack.Pop();
            SceneManager.LoadScene(sceneStack.Peek());
        }
    }

}
