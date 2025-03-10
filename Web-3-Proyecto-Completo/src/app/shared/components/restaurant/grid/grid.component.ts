import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RestaurantService } from 'src/app/shared/services/restaurant.service';


/**
 * @title grid
 */
@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html',
  styleUrls: ['./grid.component.scss']
})
export class GridComponent implements OnInit {
  public rest;

  constructor(
    private restaurant : RestaurantService,
    private _route:ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.verificarId();
  }
   
  verificarId(){
    this._route.params.subscribe(params => {
      let id = +params['id']
      let token = localStorage.getItem('token')
      if(id && token){
        this.restaurant.getOne(id).subscribe(resp=>{
          this.rest = resp[0];
          console.log(this.rest)
        },
        err=>{
          console.log(err)
        })
      }
    })
  }
}
