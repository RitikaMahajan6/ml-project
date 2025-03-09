# Unity Detectron Car Obstacle Detection Project

## Overview
This project implements an obstacle detection system for a car using Unity and Detectron. The system utilizes a pre-trained Detectron model to identify obstacles in the environment, enhancing the car's navigation capabilities.

## Project Structure
```
unity-detectron-car
├── Assets
│   ├── Scripts
│   │   └── ObstacleDetection.cs
│   ├── Scenes
│   │   └── MainScene.unity
├── Detectron
│   ├── detectron_model.py
│   ├── requirements.txt
│   └── dataset
│       └── kaggle_dataset
├── README.md
└── .gitignore
```

## Setup Instructions

1. **Clone the Repository**
   Clone this repository to your local machine using:
   ```
   git clone https://github.com/yourusername/unity-detectron-car.git
   ```

2. **Install Python Dependencies**
   Navigate to the `Detectron` directory and install the required Python packages:
   ```
   cd unity-detectron-car/Detectron
   pip install -r requirements.txt
   ```

3. **Download the Dataset**
   Download the dataset from Kaggle and place it in the `Detectron/dataset/kaggle_dataset` directory. Ensure that the dataset is structured correctly for the model to process.

4. **Open the Unity Project**
   Open the `unity-detectron-car` folder in Unity. Make sure you have the necessary Unity version installed.

5. **Run the Scene**
   Open the `MainScene.unity` file located in the `Assets/Scenes` directory. Press the Play button to start the simulation and observe the obstacle detection in action.

## Usage Guidelines
- The `ObstacleDetection.cs` script contains the logic for initializing the Detectron model and processing images from the Unity environment.
- Modify the parameters in the script as needed to adjust the detection sensitivity and performance.
- Ensure that the camera settings in the Unity scene are configured to capture the environment effectively for the model.

## Dataset Information
The dataset used for training and testing the obstacle detection model is sourced from Kaggle. It contains various images and annotations for different types of obstacles that the car may encounter.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments
- Thanks to the developers of Detectron for providing a powerful framework for object detection.
- Special thanks to the Kaggle community for the datasets that enable training and testing of machine learning models.