import './styles.css';
import Start from "../button/Start";
import Selector from "../icon/Selector";
import Result from "../information/Result";
import Position from "../../dao/Position";
import Winner from "../../dao/Winner";
import axios from 'axios';
import { useState, useEffect } from "react";

const Board = () => {
  const [disableFields, setDisableFields] = useState(true);
  const [iconPlayer, setIconPlayer] = useState('');
  const [iconIA, setIconIA] = useState('');
  const [positions, setPositions] = useState([]);
  const [move, setMove] = useState(0);
  const [winner, setWinner] = useState(new Winner(false, ''));
  const [tie, setTie] = useState(false);
  const [lucky, setLucky] = useState('');
  const [seconds, setSeconds] = useState(0);
  const [duration, setDuration] = useState(0);
  const [showResult, setShowResult] = useState(false);

  useEffect(() => {
    if (!disableFields) {
      if (move === 5) {
        setLucky('¡Ha ocurrido un empate!');
        setTie(true);
      }
    }
  }, [disableFields, move]);

  useEffect(() => {
    const intervalId = setInterval(() => {
      setSeconds(prevSeconds => prevSeconds + 1);
    }, 1000);

    return () => {
      clearInterval(intervalId);
    };
  }, []);

  const ClearScreen = () => {
    positions.map(position => {
      const element = document.getElementById(position.id);
      element.style.backgroundColor = "white";
      element.style.color = "black";
      element.value = '';
    });

    setPositions([]);
    setIconPlayer('');
    setIconIA('');
    setDisableFields(true);
    setWinner(new Winner(false, ''));
    setSeconds(0);
    setDuration(0);
    setTie(false);
    setMove(0);
    setShowResult(false);
    setLucky('');
  };

  const InitializeFields = (data) => {
    setDisableFields(data);
  };

  const AplyIcon = (data) => {
    if (data === 'X') {
      setIconPlayer('X');
      setIconIA('O');
    } else {
      setIconPlayer('O');
      setIconIA('X');
    }
  };

  const Play = (e) => {
    e.preventDefault();

    if (!winner.isWinner) {
      // Update move play
      setMove(move + 1);

      // Player play
      const positionId = e.target.id; // Get the ID of the clicked input
      document.getElementById(positionId).value = iconPlayer;

      const tempPositions = [];
      RefreshList(tempPositions);
      CheckWinner(iconPlayer, tempPositions);
      setPositions(tempPositions); // Update the positions array with tempPositions

      // IA Play
      const headers = {
        'Content-Type': 'application/json',
      };

      const inputsData = tempPositions.map(position => ({
        id: position.id,
        value: position.value
      }));

      const data = {
        icon: iconIA,
        places: inputsData
      };

      // Paint IA Icon
      axios.post('/empty-position', data, { headers })
        .then(response => {
          tempPositions.map(position => {
            if (position.id === response.data) {
              document.getElementById(response.data).value = iconIA;
              tempPositions.pop();
              RefreshList(tempPositions);
              CheckWinner(iconIA, tempPositions);
              setPositions(tempPositions); // Update the positions array with tempPositions
            }
            return position; // Return the position in other cases
          });
        })
        .catch(error => console.error(error));
    } else {
      ChangeColorPosition(winner.positions);
      setShowResult(true);

      switch (winner.icon) {
        case iconPlayer:
          setLucky('¡Ganador Jugador : ' + iconPlayer + '!');
          break;
        case iconIA:
          setLucky('¡Ganador IA : ' + iconIA + '!');
          break;
      }

      TotalTimeMatch();
    }
  };

  const RefreshList = (TP) => {
    for (let i = 1; i < 10; i++) {
      const positionId = 'position' + i;
      const element = document.getElementById(positionId);
      if (element) {
        const positionValue = element.value;
        TP.push(new Position(positionId, positionValue));
      } else {
        console.error('Element with ID ' + positionId + ' not found.');
      }
    }
  };

  const CheckWinner = (icon, board) => {
    const headers = {
      'Content-Type': 'application/json',
    };

    const data = {
      icon: icon,
      places: board.map(position => ({
        id: position.id,
        value: position.value
      }))
    };

    axios.post('/check-winner', data, { headers })
      .then(response => {
        if (response.data.isWinner) {
          const updatedWinner = new Winner(response.data.icon, response.data.isWinner, response.data.positions);
          setWinner(updatedWinner);
          return;
        }
      })
      .catch(error => console.error(error));
  };

  const ChangeColorPosition = (positions) => {
    const boxes = positions.split(",");

    boxes.map(box => {
      const element = document.getElementById(box);
      element.style.backgroundColor = "green";
      element.style.color = "white";
    });
  };

  const TotalTimeMatch = () => {
    const headers = {
      'Content-Type': 'application/json',
    };

    const data = {
      seconds: seconds
    };

    axios.post('/check-time', data, { headers })
      .then(response => {
        setDuration(response.data);
      })
      .catch(error => console.error(error));
  };

  return (
    <div>
      <h1>3 En Raya</h1>
      <Selector icon={AplyIcon} />
      <div className="row">
        <div className="column">
          <input type="text" id="position1" disabled={disableFields} onClick={Play} />
          <input type="text" id="position4" disabled={disableFields} onClick={Play} />
          <input type="text" id="position7" disabled={disableFields} onClick={Play} />
        </div>
        <div className="column">
          <input type="text" id="position2" disabled={disableFields} onClick={Play} />
          <input type="text" id="position5" disabled={disableFields} onClick={Play} />
          <input type="text" id="position8" disabled={disableFields} onClick={Play} />
        </div>
        <div className="column">
          <input type="text" id="position3" disabled={disableFields} onClick={Play} />
          <input type="text" id="position6" disabled={disableFields} onClick={Play} />
          <input type="text" id="position9" disabled={disableFields} onClick={Play} />
        </div>
      </div>
      <Start fields={InitializeFields} />
      {showResult && (<Result screen={ClearScreen} lucky={lucky} positions={winner.positions} duration={duration} />)}
      {tie && (<Result screen={ClearScreen} lucky={lucky} positions={null} duration={duration} />)}
    </div>
  );
};

export default Board;
