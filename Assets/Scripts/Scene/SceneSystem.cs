using Game.Database.UnityScriptableObject;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scene
{
    public class SceneSystem : ISceneSystem
    {
        private ISceneTable SceneTable { get; set; }

        public SceneSystem(ISceneTable sceneTable)
        {
            SceneTable = sceneTable;
        }

        public AsyncOperation ChangeState(eScene type)
        {
            string sceneName = SceneTable.GetScenePath(type);
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            return operation;
        }
    }
}

