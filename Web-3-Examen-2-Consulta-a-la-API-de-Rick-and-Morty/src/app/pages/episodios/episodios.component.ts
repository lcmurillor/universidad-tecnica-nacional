import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { EpisodiosService } from 'src/app/shared/services/episodios.service';

@Component({
  selector: 'app-episodios',
  templateUrl: './episodios.component.html',
  styleUrls: ['./episodios.component.css']
})
export class EpisodiosComponent implements AfterViewInit, OnInit {
  displayedColumns: string[] = ['id','name','air_date','episode']
  dataSource = new MatTableDataSource()
  @ViewChild(MatPaginator) paginator!: MatPaginator
  constructor(
    private ServivoEpisodios: EpisodiosService
  ) { }
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }
  ngOnInit(): void {
    this.cargar()
  }

  cargar(){
    this.ServivoEpisodios.getAll().subscribe((datos: any)=>{
      this.dataSource.data = datos.results
    },(error)=> {
      alert(error)
    })
  }

}
