import { SesionModalComponent } from './../sesion-modal/sesion-modal.component';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AuthService } from '../../services/auth.service';
import { isEmpty } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  public _isLogin: boolean = false;
  constructor(
    private dialog: MatDialog,
    private authService: AuthService,
    private router: Router
  ) { }

  ngOnInit(): void {
    if (localStorage.getItem('token')) {
      this._isLogin = true;
    }
  }

  logout() {
    this._isLogin = false;
    this.authService.logout();
  }


  openModal() {
    let dialoRef = this.dialog.open(SesionModalComponent, {
      width: "400px",
      height: "400px"
    });
    dialoRef.afterClosed().subscribe((result) => {
      if (localStorage.getItem('token')) {
        this._isLogin = true;
      }
    });
  }
}
