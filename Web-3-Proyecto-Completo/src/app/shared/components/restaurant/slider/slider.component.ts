import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.scss'],
  providers: [NgbCarouselConfig]
})
export class SliderComponent implements OnInit {

  restaurante:any[]=[
    {
     img:'assets/restaurantes/casado.fw.png',
     },
    {
      img:'assets/restaurantes/pinacolado.fw.png',
    },
    {
      img:'assets/restaurantes/pinto.fw.png',
    }

  ];


  constructor(private _config:NgbCarouselConfig) {
    _config.interval = 3000;
    _config.pauseOnHover = true;
    _config.showNavigationArrows = false; 
  } 

  ngOnInit() {
  }

}

