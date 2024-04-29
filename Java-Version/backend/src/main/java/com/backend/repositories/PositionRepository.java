package com.backend.repositories;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.atomic.AtomicBoolean;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.backend.components.PositionComponent;
import com.backend.models.Position;
import com.backend.models.Winner;

@Repository
public abstract class PositionRepository {

    @Autowired
    private PositionComponent positionComponent;

    public String TimeMatch(String s){

        String time = "";

        int min = (Integer.parseInt(s) / 60);

        if(Integer.parseInt(s) < 60){

            time = positionComponent.time.replace("Sec", String.valueOf(s));

            time = time.substring(time.indexOf(s));

            time = "¡"+time;

        }
        else{

            if((Integer.parseInt(s)) % 2 == 0){

                time = positionComponent.time.replace("Min", String.valueOf(min));
    
                time = time.substring(0, time.indexOf(":"));
    
                time = time + "!";
            }
             
            else{
    
                int tempMin = 0;
    
                int tempSec = 0;
    
                for(int i = 60; i <= Integer.parseInt(s); i+=60){
    
                    tempMin+=60;
    
                }
    
               
                tempSec = Integer.parseInt(s) - tempMin;
    
                tempMin = tempMin / 60;
    
                time = positionComponent.time.replace("Min", String.valueOf(tempMin)).replace("Sec", String.valueOf(tempSec));
                
            
            }
    

        }

        return time;

    }

    public Winner VerifyWinner(String icon, List<Position> positions){

        Boolean HasWinner = false;

        String PositionsWinner = "";

        String positionA = "";
        String positionB = "";
        String positionC = "";

        String valueA = "";
        String valueB = "";
        String valueC = "";
        
        List<List<Integer>> combinations = new ArrayList<>() {{
            add(List.of(1, 2, 3));
            add(List.of(4, 5, 6));
            add(List.of(7, 8, 9));
            add(List.of(1, 4, 7));
            add(List.of(2, 5, 8));
            add(List.of(3, 6, 9));
            add(List.of(1, 5, 9));
            add(List.of(3, 5, 7));
        }};

        for (List<Integer> com : combinations)
        {
            for (var pst : positions)
            {
                if (pst.getId().equals("position"+com.get(0)))
                {
                    positionA = pst.getId();

                    valueA = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(1)))
                {
                    positionB = pst.getId();

                    valueB = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(2)))
                {
                    positionC = pst.getId();

                    valueC = pst.getValue();

                }

                if(valueA.equals(icon) && valueB.equals(icon) && valueC.equals(icon))
                {
                    if(positionA.equals("position"+com.get(0)) && positionB.equals("position"+com.get(1)) 
                    && positionC.equals("position"+com.get(2))){

                        HasWinner = true;
    
                        PositionsWinner = positionA + "," + positionB + "," + positionC;

                        return new Winner(icon, HasWinner, PositionsWinner);

                    }
                    
    
                }
            }

           

        }     


        return new Winner(icon, false, "");
    }


    public Boolean ValidatSmartIA(String icon, List<Position> positions){

        Boolean IA_ATTACK = false;

        String positionA = "";
        String positionB = "";
        String positionC = "";

        String valueA = "";
        String valueB = "";
        String valueC = "";
        
        List<List<Integer>> combinations = new ArrayList<>() {{
            add(List.of(1, 2, 3));
            add(List.of(4, 5, 6));
            add(List.of(7, 8, 9));
            add(List.of(1, 4, 7));
            add(List.of(2, 5, 8));
            add(List.of(3, 6, 9));
            add(List.of(1, 5, 9));
            add(List.of(3, 5, 7));
        }};

        for (List<Integer> com : combinations)
        {
            for (var pst : positions)
            {
                if (pst.getId().equals("position"+com.get(0)))
                {
                    positionA = pst.getId();

                    valueA = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(1)))
                {
                    positionB = pst.getId();

                    valueB = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(2)))
                {
                    positionC = pst.getId();

                    valueC = pst.getValue();

                }
            }

            if(valueA.equals("") && valueB.equals(icon) && valueC.equals(icon))
            {
               IA_ATTACK = true;
            }
            else if (valueA.equals(icon) && valueB.equals("") && valueC.equals(icon))
            {
                IA_ATTACK = true;
            }
            else if (valueA.equals(icon) && valueB.equals(icon) && valueC.equals(""))
            {
                IA_ATTACK = true;
            }

        }     


        return IA_ATTACK;
    }


    public String IA_Desition(String icon, List<Position> positions){

        String especificPosition = "";

        String positionA = "";
        String positionB = "";
        String positionC = "";

        String valueA = "";
        String valueB = "";
        String valueC = "";
        
        List<List<Integer>> combinations = new ArrayList<>() {{
            add(List.of(1, 2, 3));
            add(List.of(4, 5, 6));
            add(List.of(7, 8, 9));
            add(List.of(1, 4, 7));
            add(List.of(2, 5, 8));
            add(List.of(3, 6, 9));
            add(List.of(1, 5, 9));
            add(List.of(3, 5, 7));
        }};

        for (List<Integer> com : combinations)
        {
            for (var pst : positions)
            {
                if (pst.getId().equals("position"+com.get(0)))
                {
                    positionA = pst.getId();

                    valueA = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(1)))
                {
                    positionB = pst.getId();

                    valueB = pst.getValue();

                }
                if (pst.getId().equals("position"+com.get(2)))
                {
                    positionC = pst.getId();

                    valueC = pst.getValue();

                }
            }

            if(valueA.equals("") && valueB.equals(icon) && valueC.equals(icon))
            {
                especificPosition = positionA;

                return especificPosition;
            }
            else if (valueA.equals(icon) && valueB.equals("") && valueC.equals(icon))
            {
                especificPosition = positionB;

                return especificPosition;
            }
            else if (valueA.equals(icon) && valueB.equals(icon) && valueC.equals(""))
            {
                especificPosition = positionC;

                return especificPosition;
            }

        }     


        if (especificPosition.equals("")) {

                AtomicBoolean findEmptyPosition = new AtomicBoolean(true);

                while (findEmptyPosition.get()) {

                int num = (int) (Math.random() * 10); 

                String aleatoryId = "position" + num;

                positions.stream()
                        .filter(p -> p.getId().equals(aleatoryId))
                        .forEach(p -> {
                            if (p.getValue().equals("")) {
                                findEmptyPosition.set(false);
                            
                            }
                        });

                especificPosition = aleatoryId;
            }
        }



        return especificPosition;
    }
    
}
