import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog} from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { UsersService } from 'src/app/shared/services/users.service';
import {​​​​​​​​ ModalUserComponent }​​​​​​​​ from'../modal-user/modal-user.component';



@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements AfterViewInit, OnInit {

  displayedColumns: string[] = ['id', 'username', 'name', 'surname1', 'surname2', 'actions'];
  dataSource = new MatTableDataSource();
  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(
    private srvUsers: UsersService,
    private dialog: MatDialog
  ) { }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnInit(): void {
    this.Load();
  }

  Load() {
    this.srvUsers.consultarTodos().subscribe((list) => {
      this.dataSource.data = list;
    }, (err) => {
      alert(err);
    });
  }

  openModal(): void {
    let dialogRef = this.dialog.open(ModalUserComponent, {
      height: '700px',
      width: '700px',
      data: {
        titulo: 'Nuevo Usuario'
      }
    });
    dialogRef.afterClosed().subscribe((result) => {
      this.Load();
    });
  }
}
