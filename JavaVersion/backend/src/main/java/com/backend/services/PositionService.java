package com.backend.services;

import java.util.List;

import org.springframework.stereotype.Service;

import com.backend.models.Position;
import com.backend.models.Winner;

public interface PositionService {

    String DurationMatch(String seconds);

    Winner CheckWinner(String icon, List<Position> positions);
    
    Boolean IA_Smart(String icon, List<Position> positions);

    String IA_Play(String icon, List<Position> positions);
}
