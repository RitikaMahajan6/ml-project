using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class ObstacleDetection : MonoBehaviour
{
    private string modelPath = "path/to/your/detectron/model"; // Update with your model path
    private string detectronScriptPath = "path/to/your/detectron/detectron_model.py"; // Update with your script path

    void Start()
    {
        InitializeModel();
    }

    private void InitializeModel()
    {
        // Load the Detectron model
        UnityEngine.Debug.Log("Initializing Detectron model...");
        // Additional initialization code can be added here
    }

    public void ProcessImage(Texture2D inputImage)
    {
        // Convert Texture2D to a format suitable for the Detectron model
        byte[] imageBytes = inputImage.EncodeToPNG();
        File.WriteAllBytes("temp_image.png", imageBytes);

        // Run the Detectron model
        RunDetectronModel("temp_image.png");
    }

    private void RunDetectronModel(string imagePath)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "python",
            Arguments = $"{detectronScriptPath} {imagePath}",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = Process.Start(startInfo))
        {
            using (StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                UnityEngine.Debug.Log("Detection Results: " + result);
                // Handle the results (e.g., parse and visualize obstacles)
            }
        }
    }
}