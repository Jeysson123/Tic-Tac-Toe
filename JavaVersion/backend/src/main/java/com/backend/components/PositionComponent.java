package com.backend.components;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class PositionComponent {

    @Value("${time}")
    public String time;


}
