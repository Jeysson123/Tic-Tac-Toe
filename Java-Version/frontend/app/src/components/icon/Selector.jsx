import { useState } from "react";
import './styles.css';

const Selector = ({icon}) => {
  const [selectedIcon, setSelectedIcon] = useState(""); // State to store the selected icon

  const handleIconChange = (event) => {
    setSelectedIcon(event.target.value);
    icon(event.target.value);
  };

  return (
    <div>
      <h2>Seleccione Icono</h2>
      <div className="radios">
        <label>
          <input
            type="radio"
            name="icon"
            value="X"
            checked={selectedIcon === "X"}
            onChange={handleIconChange}
          />
          X
        </label>
        <label>
          <input
            type="radio"
            name="icon"
            value="O"
            checked={selectedIcon === "O"}
            onChange={handleIconChange}
          />
          O
        </label>
      </div>
    </div>
  );
}

export default Selector;
