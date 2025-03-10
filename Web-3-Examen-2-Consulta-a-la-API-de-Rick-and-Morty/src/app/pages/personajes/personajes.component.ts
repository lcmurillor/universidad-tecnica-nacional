import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { PersonajesService } from 'src/app/shared/services/personajes.service';
import { MatDialog} from '@angular/material/dialog';
import { PersonajedetalleComponent } from './personajedetalle/personajedetalle.component';


@Component({
  selector: 'app-personajes',
  templateUrl: './personajes.component.html',
  styleUrls: ['./personajes.component.css']
})
export class PersonajesComponent implements AfterViewInit, OnInit {

  displayedColumns: string[] = ['id','name','species','actions']
  dataSource = new MatTableDataSource()
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  constructor(
      private ServivoPersonajes: PersonajesService,
      private dialog: MatDialog
  ) { }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit(): void {
    this.cargar()
  }

  cargar(){
    this.ServivoPersonajes.getAll().subscribe((datos: any)=>{
      this.dataSource.data = datos.results
    },(error)=> {
      alert(error)
    })
  }

  abrirModal(personaje={}):void{
    let dialogRef = this.dialog.open(PersonajedetalleComponent, {
      height: '650px',
      width: '700px',
      data: {
        titulo: 'Detalles del personaje',
        personaje
      }
    });
    dialogRef.afterClosed().subscribe((result) => {
      this.cargar();
    });
  }

}
