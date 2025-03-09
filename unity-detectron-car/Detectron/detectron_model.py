import detectron2
from detectron2.engine import DefaultPredictor
from detectron2.config import get_cfg
from detectron2.data import MetadataCatalog
import cv2
import os

class DetectronModel:
    def __init__(self, config_file, model_weights):
        self.cfg = get_cfg()
        self.cfg.merge_from_file(config_file)
        self.cfg.MODEL.WEIGHTS = model_weights
        self.cfg.MODEL.ROI_HEADS.SCORE_THRESH_TEST = 0.5  # Set the threshold for this model
        self.predictor = DefaultPredictor(self.cfg)

    def process_image(self, image_path):
        image = cv2.imread(image_path)
        outputs = self.predictor(image)
        return outputs

    def detect_obstacles(self, image_path):
        outputs = self.process_image(image_path)
        instances = outputs["instances"].to("cpu")
        return instances.pred_boxes, instances.scores, instances.pred_classes

if __name__ == "__main__":
    model = DetectronModel("path/to/config.yaml", "path/to/model_weights.pth")
    image_path = "path/to/test_image.jpg"
    boxes, scores, classes = model.detect_obstacles(image_path)
    print("Detected boxes:", boxes)
    print("Scores:", scores)
    print("Classes:", classes)