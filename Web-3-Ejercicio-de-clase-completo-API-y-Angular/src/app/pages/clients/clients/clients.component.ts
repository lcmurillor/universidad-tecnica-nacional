import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ClientsService } from 'src/app/shared/services/clients.service';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements AfterViewInit, OnInit {
  displayedColumns: string[] = ['id', 'username', 'name', 'surname1', 'surname2','actions'];
  dataSource = new MatTableDataSource();
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(
    private srvClients: ClientsService
  ) { }
  
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit(): void {
    this.Load();
  }

  Load() {
    this.srvClients.consultarTodos().subscribe((list) => {
      this.dataSource.data=list;
    }, (err) => {
      alert(err);
    });
  }

}
