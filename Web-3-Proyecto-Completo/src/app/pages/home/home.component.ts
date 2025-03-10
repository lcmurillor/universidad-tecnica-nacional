import { RestaurantService } from './../../shared/services/restaurant.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  displayedColumns:string[] = ['id']
  dataSource = new MatTableDataSource();
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  public restaurants;

  constructor(private toastr: ToastrService, private restaurant: RestaurantService) { }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit(): void {
    this.getRestaurants();
  }

  getRestaurants(){
    this.restaurant.getAll().subscribe((rest)=>{
      if(rest){
        this.restaurants = rest
      }
    },(err)=>{
      this.toastr.error(err)
    })
  }
}
