import { WeatherService } from './../weather.service';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {

  constructor(private weatherService: WeatherService) { }
  res: any = [];

  ngOnInit(): void {
    this.weatherService.getWeather().subscribe(data => {
      this.res = data;
    })

  }

}
