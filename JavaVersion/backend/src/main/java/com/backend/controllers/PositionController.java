package com.backend.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import com.backend.models.Position;
import com.backend.models.Winner;
import com.backend.services.PositionService;

import java.util.List;

@RestController
@CrossOrigin(origins="http://localhost:3000")
@RequestMapping("/api/3enrayas")
public class PositionController {

    private PositionService positionService;

    public PositionController(PositionService pS){

        this.positionService = pS;

    }

    @PostMapping(value = "/duration")
    public String ValidateWinner(@RequestBody String scs) throws Exception {
    
        return positionService.DurationMatch(scs);
    }

    @PostMapping(value = "/winner")
    public Winner ValidateWinner(@RequestBody List<Position> positions, @RequestParam String icon) throws Exception {
    
        return positionService.CheckWinner(icon, positions);
    }

    @PostMapping(value = "/iaplay")
    public String CheckEmptyPosition(@RequestBody List<Position> positions, @RequestParam String icon) throws Exception {
        
        String playerIcon = "";

        switch(icon){
            case "X":
                playerIcon="O";
                break;

            case "O":
                playerIcon="X";
                break;
        }

        return positionService.IA_Play(positionService.IA_Smart(icon, positions) ? icon : playerIcon, positions);
    }

}
