import {useEffect, useState} from "react";
import './styles.css';
const Start = ({fields}) => {


      const StartGame = (e) => {

            e.preventDefault();

            fields(false);

      }


         return(



                <div>

                     <button className={"button buttonStart"} onClick={StartGame}> Comenzar </button>

                </div>

         );
}

export default Start;
