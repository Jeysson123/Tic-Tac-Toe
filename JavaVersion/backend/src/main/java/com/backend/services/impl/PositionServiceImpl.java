package com.backend.services.impl;

import java.util.List;

import org.springframework.stereotype.Service;

import com.backend.models.Position;
import com.backend.models.Winner;
import com.backend.repositories.PositionRepository;
import com.backend.services.PositionService;

@Service
public class PositionServiceImpl extends PositionRepository implements PositionService{

    @Override
    public String DurationMatch(String seconds) {

        return super.TimeMatch(seconds);
    
    }

    @Override
    public Winner CheckWinner(String icon, List<Position> positions) {
        return super.VerifyWinner(icon, positions);
    }

    @Override
    public Boolean IA_Smart(String icon, List<Position> positions) {

        return super.ValidatSmartIA(icon, positions);
    }

    @Override
    public String IA_Play(String icon, List<Position> positions) {

        return super.IA_Desition(icon, positions);
    }

   

  

   
    
}
