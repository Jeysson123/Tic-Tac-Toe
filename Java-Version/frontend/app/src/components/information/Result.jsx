import { useState, useEffect } from "react";
import './styles.css';

const Result = (props) => {
  const [showPopup, setShowPopup] = useState(true);
  const [showBoxes, setShowBoxes] = useState(false);
  const [boxes, setBoxes] = useState([]);

  useEffect(() => {
    if (props.positions !== null) {
      setShowBoxes(true);

      const luckyBoxes = props.positions.split(",");
      const renamedBoxes = luckyBoxes.map(box => box.replace("position", ""));
      setBoxes(renamedBoxes);
    }
  }, [props.positions]);

  const RestarGame = (event) => {
    event.preventDefault();
    props.screen();
    setShowPopup(false); // Close the popup
  };

  if (!showPopup) {
    return null; // Return null when showPopup is false to hide the popup
  }

  return (
    <div className="popup-container">
      <div className="popup-body">
        <h1>Resultados</h1>
        <hr />
        <h3>{props.lucky}</h3>
        <hr />
        {showBoxes && (
          <>
            <h3>¡Casillas Ganadoras: {boxes[0] + ', ' + boxes[1] + ', ' + boxes[2]}!</h3>
            <hr />
          </>
        )}
        <h3>Duracion: {props.duration}</h3>
        <hr />
        <button onClick={RestarGame}>Cerrar</button>
      </div>
    </div>
  );
};

export default Result;
